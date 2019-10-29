using System;

namespace Helpers
{
    public class Circle
    {
        public int R;
        public Vector Center;

        public Circle(Vector center, int r)
        {
            Center = center;
            R = r;
        }

        public Lista<Vector> GetPossibleTargets()
        {
            Lista<Vector> possibleTargets = new Lista<Vector>();

            int diameter = 2 * R;

            for (int i = 0; i <= diameter; i++)
            {
                int x = i - R;

                for (int j = 0; j <= diameter; j++)
                {
                    int y = j - R;
                    double error = Math.Abs( Vector.Length(x, y) - R );

                    if (error < 0.5)
                        possibleTargets.Add(new Vector(x, y).Add(Center));
                }
            }

            return possibleTargets;
        }

        public bool IsIn(Vector position)
        {
            double dist = Center.Dist(position) - R;

            return dist < 0.5;
        }

        public bool IsOn(Vector position)
        {
            double error = Math.Abs( Center.Dist(position) - R );

            return error < 0.5;
        }

        public override string ToString()
        {
            return $"O({Center}, {R})";
        }
    }
}
