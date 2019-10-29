using System;
using System.Drawing;
using System.Windows.Forms;

namespace Helpers
{
    public class Utils
    {
        public static Image RotateImage(Image image, double angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);

            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics gfx = Graphics.FromImage(rotatedImage))
            {
                gfx.TranslateTransform(image.Width / 2f, image.Height / 2f);

                gfx.RotateTransform((float) angle);

                gfx.TranslateTransform(-image.Width / 2f, -image.Height / 2f);

                gfx.DrawImage(image, new PointF(0, 0));
            }

            return rotatedImage;
        }

        public static int To360Deg(int angle)
        {
            angle %= 360;

            if (angle < 0) angle += 360;

            return angle;
        }

        public static double ToRadians(int deg)
        {
            return deg * Math.PI / 180;
        }

        public static int ToDegrees(double rad)
        {
            return ToSaveInt(rad * 180 / Math.PI);
        }

        public static int ToSaveInt(double dir)
        {
            return (int) Math.Round(dir);
        }

        public static MouseEventHandler MouseEventBubbling(MouseEventHandler Callback)
        {
            return (object sender, MouseEventArgs ev) =>
            {
                Control elem = (Control) sender;

                MouseEventArgs newEvent = new MouseEventArgs(
                    ev.Button,
                    ev.Clicks,
                    ev.X + elem.Location.X,
                    ev.Y + elem.Location.Y,
                    ev.Delta
               );

                Callback(sender, newEvent);
            };
        }

        public static double RoundAround(double value, double by = 1)
        {
            return Math.Round(value / by) * by;
        }

        public static double XFromPolar(double fi, double r = 1) {
            return r * Math.Cos(fi);
        }

        public static double YFromPolar(double fi, double r = 1) {
            return r * Math.Sin(fi);
        }

        public static double XFromPolar(int fi, double r = 1) {
            return XFromPolar(ToRadians(fi), r);
        }

        public static double YFromPolar(int fi, double r = 1) {
            return YFromPolar(ToRadians(fi), r);
        }

        public static double MaxModule(double a, double b)
        {
            return Math.Max(Math.Abs(a), Math.Abs(b));
        }

        public static void ParseResponse(short response, out int accumulator, out int distance)
        {
            accumulator = response & 0b111111111;

            distance = response >> 9;
        }

        public static byte PrepereCommand(byte steps, int direction = 0)
        {
            switch (To360Deg(direction))
            {
                case 0: return PrepereCommand(steps, (byte) 0);
                case 90: return PrepereCommand(steps, (byte) 1);
                case 270: return PrepereCommand(steps, (byte) 2);
                case 180: return PrepereCommand(steps, (byte) 3);
                default: return PrepereCommand(steps, (byte) 0);
            }
        }

        public static byte PrepereCommand(byte steps, byte direction)
        {
            if (steps == 0) throw new Exception("Steps must be a positive value");

            return (byte) ((direction & 0b11) | ((steps - 1) << 2));
        }
    }
}
