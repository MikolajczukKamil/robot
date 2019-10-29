using System;
using Helpers;

namespace RobotAI
{
    public class RobotAIController
    {
        // Universal
        int Direction = 90;
        Vector Position = Vector.Zero;

        static int MaxMovePerTurn = 31;
        static int MaxDistanceFromTarget = 63;

        public void OnMove(Vector position, int distance)
        {
            Direction = Vector.Subtract(position, Position).AngleDeg();
            Position = position;

            if (distance < MaxDistanceFromTarget)
                MoveWithinReach(distance);

            else
            {
                BlindMove();

                if (!NoMoveInRange())
                    MoveOutsideReach();
            }
        }

        public Vector PredictMove()
        {
            if (NoMoveInRange())
            {
                if (NoMoveOutsideRange())
                    return MoveTo(FirstMove());

                return MoveTo(PredictMoveToFindRange());
            }

            int limit;

            if(OneMoveInRange() && NoMoveOutsideRange()) 
                return MoveTo(SecondMove(out limit), limit);

            return MoveTo(PredictMoveToTarget(out limit), limit);
        }

        Vector MoveTo(Vector target, int maxMove = int.MaxValue)
        {
            int max = Math.Min(MaxMovePerTurn, maxMove);

            return Vector.Subtract(target, Position).Longer().Limit(max).Add(Position);
        }

        Vector FirstMove()
        {
            return new Vector(0, 1);
        }

        // The target is within reach
        Lista<Vector> PossibleTargets;
        Lista<Circle> Moves = new Lista<Circle>();

        static int FirstFreeMove = 2;
        static int MaxMoveForUncertainTarget = 10;

        void MoveWithinReach(int distance)
        {
            Circle range = new Circle(Position, distance);

            Moves.Add(range);

            if (PossibleTargets == null) PossibleTargets = range.GetPossibleTargets();
            else LimitTargetsOn(range);
        }

        void MoveOutsideReach()
        {
            LimitTargetsInside(new Circle(Position, MaxDistanceFromTarget - 1));
        }

        bool NoMoveInRange()
        {
            return Moves.Empty();
        }

        bool OneMoveInRange()
        {
            return Moves.HaveLength(1);
        }

        Vector SecondMove(out int limit)
        {
            limit = FirstFreeMove;

            return Vector.Wersor(Position).Multiply(FirstFreeMove).Add(Position);
        }

        Vector PredictMoveToTarget(out int limit)
        {
            limit = int.MaxValue;

            if (PossibleTargets.Empty())
                throw new RobotAIGotLostException();

            Lista<Vector> nearests = NearestsMoves();

            if (nearests.HaveLength(1))
                return nearests.First();

            limit = MaxMoveForUncertainTarget;
            
            return MostExtremePosition(nearests);
        }

        void LimitTargetsOn(Circle range)
        {
            foreach (Vector move in PossibleTargets)
                if (!range.IsOn(move))
                    PossibleTargets.Remove(move);
        }

        void LimitTargetsInside(Circle distance)
        {
            foreach (Vector move in PossibleTargets)
                if (distance.IsIn(move))
                    PossibleTargets.Remove(move);
        }

        Vector MostExtremePosition(Lista<Vector> moves)
        {
            int maxDiff = 0;
            int minDiff = 0;

            Vector best = null;

            foreach (Vector move in moves)
            {
                Vector diff = Vector.Subtract(move, Position).Abs();

                int myMax = diff.Max();
                int myMin = diff.Min();

                if (myMax > maxDiff || (myMax == maxDiff && myMin > minDiff))
                {
                    maxDiff = myMax;
                    minDiff = myMin;

                    best = move;
                }
            }

            return best;
        }

        Lista<Vector> NearestsMoves()
        {
            Lista<Vector> nearests = new Lista<Vector>();

            int dst = int.MaxValue;

            foreach (Vector elem in PossibleTargets)
            {
                int tmpDst = Utils.ToSaveInt(elem.Dist(Position));

                if (tmpDst < dst)
                {
                    nearests.Clear();
                    nearests.Add(elem);

                    dst = tmpDst;
                }
                else if (tmpDst == dst) nearests.Add(elem);
            }

            return nearests;
        }


        // The target is out of reach
        int TraiIndex = 0;
        Lista<Vector> TrailToTarget = new Lista<Vector>();

        static int PathsScale = 10;
        static int MaxDistanceBetweenPaths = 8; // Floor(Sqrt(2) * (MaxDistanceFromTarget - 1) / PathsScale)

        void BlindMove()
        {
            if (TrailToTarget.Empty())
                TrailToTarget.Add(Position);

            Vector tmpTarget = TrailToTarget.First();

            if (tmpTarget.Dist(Position) < 10)
            {
                TraiIndex++;
                TrailToTarget.Remove(tmpTarget);
                TrailToTarget.Add(PathElement(TraiIndex));
            }
        }

        bool NoMoveOutsideRange()
        {
            return TrailToTarget.Empty();
        }

        Vector PredictMoveToFindRange()
        {
            return TrailToTarget.First();
        }

        Vector PathElement(int n)
        {
            return new Vector(PathCordinate(n), PathCordinate(n + 1));
        }

        int PathCordinate(int n)
        {
            int w = n / 2;

            int k = 2 * (w % 2) - 1;

            return PathsScale * k * PathFn((n + 2) / 4);
        }

        int PathFn(int x)
        {
            // f(x) => x == 0 ? 0 : f(x - 1) + Min(x, MaxDistanceBetweenPaths)

            if (x < 1) return 0;

            int last = Math.Min(x, MaxDistanceBetweenPaths);

            int sum1toLast = (1 + last) * last / 2;

            return (x - last) * MaxDistanceBetweenPaths + sum1toLast;
        }


        // For text version
        public int[] MoveCommand(Vector move)
        {
            Vector diff = Vector.Subtract(move, Position);

            int dir = diff.AngleDeg() - Direction;
            int steps = diff.Abs().Sum();

            switch(Utils.To360Deg(dir))
            {
                case 90:
                    dir = 1;
                    break;
                case 180:
                    dir = 3;
                    break;
                case 270:
                    dir = 2;
                    break;
                default:
                    dir = 0;
                    break;
            }

            return new int[] { steps, dir };
        }

        public Vector PositionFrom(int steps, int dir)
        {
            return Vector.FromPolar(Direction + dir, steps).Add(Position);
        }  
    }
}
