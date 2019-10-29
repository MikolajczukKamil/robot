using System;

namespace RobotLib
{
    public class Robot
    {
        class RVector
        {
            public int X;
            public int Y;

            public RVector(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        RVector Target;
        RVector Position = new RVector(0, 0);
        RVector Direction = new RVector(0, 0);

        short Accumulator;
        double Angle = Math.PI / 2;

        static int EnergiPerMove = 1;
        static int EnergiPerTurn = 1;
        static int EnergiPerResponse = 1;

        public Robot(int targetX, int targetY, short accumulator = 150)
        {
            TurnBy(0);

            Target = new RVector(targetX, targetY);
            Accumulator = accumulator;
        }

        public short Action(byte command)
        {
            Turn(GetTurnValue(command));
            Move(GetMoveValue(command));

            return PrepereResponse();
        }

        void Move(int x)
        {
            GetEnergy(x * EnergiPerMove);

            Position.X += x * Direction.X;
            Position.Y += x * Direction.Y;
        }

        void Turn(int x)
        {
            switch (x)
            {
                case 1:
                    // left
                    GetEnergy(EnergiPerTurn);
                    TurnBy(90);
                    break;

                case 2:
                    // right
                    GetEnergy(EnergiPerTurn);
                    TurnBy(-90);
                    break;

                case 3:
                    // opposite
                    GetEnergy(2 * EnergiPerTurn);
                    TurnBy(180);
                    break;
            }
        }

        short PrepereResponse()
        {
            GetEnergy(EnergiPerResponse);

            return (short)(Accumulator | (short)(DistanceToTarget() << 9));
        }

        short DistanceToTarget()
        {
            int distX = Position.X - Target.X;
            int distY = Position.Y - Target.Y;

            int distance = ToSaveInt(Math.Sqrt(distX * distX + distY * distY));

            if (distance > 63) distance = 63;

            return (short) distance;
        }

        int GetTurnValue(byte command)
        {
            return command & 0b11;
        }

        int GetMoveValue(byte command)
        {
            return (command >> 2) + 1;
        }

        void GetEnergy(int value)
        {
            if (Accumulator < value)
                throw new BatteryException();

            Accumulator -= (short) value;
        }

        void TurnBy(int fi)
        {
            Angle += fi * Math.PI / 180;

            Direction.X = ToSaveInt(Math.Cos(Angle));
            Direction.Y = ToSaveInt(Math.Sin(Angle));
        }

        int ToSaveInt(double val)
        {
            return (int)Math.Round(val);
        }
    }
}
