using System;
using System.Drawing;
using System.Windows.Forms;
using Helpers;

namespace TrybGraficzny
{
    public partial class Map : UserControl
    {
        public static int Step = 25;
        static int LineWidth = 6;
        static int MaxDistance = 31;

        int Direction = 90;

        Vector Root;
        Vector Position = Vector.Zero;
        Vector TargetPosition = Vector.Zero;

        ImgContainer Robots;
        SelectTargetCallBack CallBack;

        public Map()
        {
            InitializeComponent();
            OnResize(new EventArgs());

            PrepereRobot();
            TargetBox.Visible = false;
            TmpMoveBox.Visible = false;
            NextMoveBox.Visible = false;

            TargetBox.MouseMove += Utils.MouseEventBubbling(Map_MouseMove);
            TmpMoveBox.MouseMove += Utils.MouseEventBubbling(Map_MouseMove);
            NextMoveBox.MouseMove += Utils.MouseEventBubbling(Map_MouseMove);

            TargetBox.MouseClick += Utils.MouseEventBubbling(Map_Click);
            TmpMoveBox.MouseClick += Utils.MouseEventBubbling(Map_Click);
            NextMoveBox.MouseClick += Utils.MouseEventBubbling(Map_Click);
        }

        public void GoRobot(Vector pos, int Direction)
        {
            Position = pos;

            TurnRobot(Direction);

            NextMoveBox.Visible = false;

            RobotBox.Location = new Point(Position.X * Step + Root.X, Root.Y - Position.Y * Step);
        }

        public void SetAim(Vector pos)
        {
            TargetBox.Location = new Point((pos.X * Step) + Root.X, Root.Y - (pos.Y * Step));
            TargetBox.Visible = true;
            TargetPosition = pos;

            DrowAimPath(pos);
        }


        void PrepereRobot()
        {
            Robots = new ImgContainer(RobotBox.Image, 270);

            RobotBox.Image.Dispose();

            RobotBox.Image = Robots.GetImageByAngle(90);
        }

        void DrowLine(Control elem, Vector from, Vector to)
        {
            Vector pos;
            Vector size;

            if(from.Y == to.Y)
            {
                if(from.X == to.X)
                {
                    elem.Visible = false;
                    return;
                }

                int startX = Math.Min(from.X, to.X);

                pos = new Vector(startX * Step, -(from.Y * Step) + (Step / 2) - (LineWidth / 2)).Add(Root);

                if (startX == from.X) pos.X += Step;

                size = new Vector(Step * Math.Abs(from.X - to.X) - 1, LineWidth);

            } else {
                if (from.Y == to.Y)
                {
                    elem.Visible = false;
                    return;
                }

                int stopY = Math.Max(from.Y, to.Y);

                pos = new Vector((from.X * Step) + (Step / 2) - (LineWidth / 2), -(stopY * Step)).Add(Root);

                if (stopY == from.Y) pos.Y += Step;

                size = new Vector(LineWidth, Step * Math.Abs(from.Y - to.Y) - 1);
            }

            elem.Size = new Size(size.X, size.Y);
            elem.Location = new Point(pos.X, pos.Y);
            elem.Visible = true;
        }

        Vector GetGridVector(Vector point)
        {
            double x =  (point.X - Root.X) - (Position.X * Step);
            double y = -(point.Y - Root.Y) - (Position.Y * Step);

            double distance = Math.Ceiling(Utils.MaxModule(x, y) / Step);

            if (y < x && distance > 1) distance--;

            double len = Math.Min(distance, MaxDistance);

            x -= Step / 2.0;
            y += Step / 2.0;

            double fi = Utils.RoundAround(Math.Atan2(y, x), Math.PI / 2);

            return Vector.FromPolar(fi, len).Add(Position);
        }

        void DrowAimPath(Vector lineTo)
        {
            DrowLine(NextMoveBox, Position, lineTo);
        }

        void TurnRobot(int dir)
        {
            Direction = dir;

            RobotBox.Image = Robots.GetImageByAngle(Direction);
        }

        void HideTmpPath_Event(object sender, EventArgs e)
        {
            Control elem = (Control)sender;

            if(!elem.RectangleToScreen(elem.ClientRectangle).Contains(Cursor.Position))
                TmpMoveBox.Visible = false;
        }

        void Map_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs) e;
            Vector selectedPlace = GetGridVector(new Vector(ev.X, ev.Y));
            
            CallBack?.Invoke(selectedPlace);
        }

        void Map_MouseMove(object sender, MouseEventArgs e)
        {
            Vector lineTo = GetGridVector(new Vector(e.X, e.Y));

            DrowLine(TmpMoveBox, Position, lineTo);
        }

        public void AfterSelectTargetCallBack(SelectTargetCallBack fn)
        {
            CallBack = fn;
        }

        protected override void OnResize(EventArgs e)
        {
            Root = new Vector(Size.Width / 2 - (Step / 2), Size.Height / 2 - (Step / 2));

            if (Robots != null)
            {
                GoRobot(Position, Direction);
                SetAim(TargetPosition);
            }
        }

        public delegate void SelectTargetCallBack(Vector target);
    }
}
