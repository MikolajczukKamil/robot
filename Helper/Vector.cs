using System;

namespace Helpers
{
    public class Vector
    {
        public int X;
        public int Y;

        public static Vector Zero = new Vector(0, 0);

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector(double x, double y)
        {
            X = Utils.ToSaveInt(x);
            Y = Utils.ToSaveInt(y);
        }


        public int Sum()
        {
            return X + Y;
        }

        public bool EqualsTo(Vector other)
        {
            return X == other.X && Y == other.Y;
        }

        public double Dist(Vector other)
        {
            double dX = X - other.X;
            double dY = Y - other.Y;

            return Math.Sqrt(dX * dX + dY * dY);
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public bool IsSingleSide()
        {
            return X == 0 || Y == 0;
        }

        public int Max()
        {
            return Math.Max(X, Y);
        }

        public int Min()
        {
            return Math.Min(X, Y);
        }

        public double Angle()
        {
            return Math.Atan2(Y, X);
        }

        public int AngleDeg()
        {
            return Utils.ToDegrees(Angle());
        }


        public Vector Abs()
        {
            X = Math.Abs(X);
            Y = Math.Abs(Y);

            return this;
        }

        public Vector Add(Vector other)
        {
            X += other.X;
            Y += other.Y;

            return this;
        }

        public Vector Subtract(Vector other)
        {
            X -= other.X;
            Y -= other.Y;

            return this;
        }

        public Vector Multiply(int value)
        {
            X *= value;
            Y *= value;

            return this;
        }

        public Vector Multiply(double value)
        {
            X = Utils.ToSaveInt(X * value);
            Y = Utils.ToSaveInt(Y * value);

            return this;
        }

        public Vector Wersor()
        {
            X = Math.Sign(X);
            Y = Math.Sign(Y);

            return this;
        }

        public Vector Shorter()
        {
            if (Math.Abs(X) < Math.Abs(Y)) Y = 0;
            else X = 0;

            return this;
        }

        public Vector Longer()
        {
            if (Math.Abs(X) > Math.Abs(Y)) Y = 0;
            else X = 0;

            return this;
        }

        public Vector Limit(int max)
        {
            if (Math.Abs(X) > max) X = Math.Sign(X) * max;
            if (Math.Abs(Y) > max) Y = Math.Sign(Y) * max;

            return this;
        }

        public Vector Copy()
        {
            return new Vector(X, Y);
        }


        public static Vector FromPolar(double fi, double r = 1)
        {
            return new Vector(Utils.XFromPolar(fi, r), Utils.YFromPolar(fi, r));
        }

        public static Vector FromPolar(int fi, double r = 1)
        {
            return new Vector(Utils.XFromPolar(fi, r), Utils.YFromPolar(fi, r));
        }

        public static Vector Add(Vector a, Vector b)
        {
            return a.Copy().Add(b);
        }

        public static Vector Subtract(Vector a, Vector b)
        {
            return a.Copy().Subtract(b);
        }

        public static Vector Multiply(Vector a, int value)
        {
            return a.Copy().Multiply(value);
        }

        public static Vector Multiply(Vector a, double value)
        {
            return a.Copy().Multiply(value);
        }

        public static Vector Wersor(Vector a)
        {
            return a.Copy().Wersor();
        }

        public static Vector Abs(Vector a)
        {
            return a.Copy().Abs();
        }

        public static Vector Shorter(Vector a)
        {
            return a.Copy().Shorter();
        }

        public static Vector Longer(Vector a)
        {
            return a.Copy().Longer();
        }

        public static Vector Limit(Vector a, int max)
        {
            return a.Copy().Limit(max);
        }

        public static double Length(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
