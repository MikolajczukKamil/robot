using System;
using System.Windows.Forms;
using RobotLib;
using RobotAI;
using Helpers;

namespace TrybGraficzny
{
    public partial class Main : Form
    {
        int Steps = 1;
        int ManySteps = 0;
        int Energy = MaxEnergy;
        int Distance = MaxDistance;
        int Direction = DefaultDirection;
        int StepsDirection = DefaultDirection;

        Vector Target;
        Vector Position = Vector.Zero;

        Form Window;
        Robot Robot;
        ImgContainer Arrows;
        RobotAIController Ai;

        static int MaxEnergy = 150;
        static int MaxDistance = 63;
        static int DefaultDirection = 90;

        static Random Rand = new Random();

        public Main()
        {
            InitializeComponent();

            PrepereArrows();
            
            GameMap.AfterSelectTargetCallBack(AfterSelectAim);
        }

        void RestartGame()
        {
            Steps = 1;
            ManySteps = 0;
            Energy = MaxEnergy;
            Distance = MaxDistance;
            Position = Vector.Zero;
            Direction = DefaultDirection;
            StepsDirection = DefaultDirection;

            int maxX = GameMap.Size.Width / Map.Step / 2;
            int maxY = GameMap.Size.Height / Map.Step / 2;

            Window = null;
            Ai = new RobotAIController();
            Robot = new Robot(Rand.Next(-maxX, maxX), Rand.Next(-maxY, maxY), (short) MaxEnergy);

            GameMap.GoRobot(Position, Direction);
            AfterSelectAim(NextTarget());
            UpdateInfoTable();
        }

        Vector NextTarget()
        {
            return Vector.FromPolar(Direction).Add(Position);
        }

        void PrepereArrows()
        {
            Arrows = new ImgContainer(DirectionArrow.Image, 90);

            DirectionArrow.Image.Dispose();
            StepsDirectionArrow.Image.Dispose();

            DirectionArrow.Image = null;
            StepsDirectionArrow.Image = null;
        }

        void AfterSelectAim(Vector newTarget)
        {
            if (Position.EqualsTo(newTarget)) return;

            Target = newTarget;
            GameMap.SetAim(newTarget);

            Vector diff = Vector.Subtract(newTarget, Position);

            Steps = Math.Abs(diff.Sum());
            StepsDirection = diff.AngleDeg();

            UpdateInfoTable();
        }

        void UpdateInfoTable()
        {
            StepsBox.Text = Steps.ToString();
            EnergyBox.Text = Energy.ToString();
            DistanceBox.Text = Distance.ToString();
            ManyStepsBox.Text = ManySteps.ToString();
            PositionBox.Text = $"({Position.X}, {Position.Y})";

            DirectionArrow.Image = Arrows.GetImageByAngle(Direction);
            StepsDirectionArrow.Image = Arrows.GetImageByAngle(StepsDirection - Direction + 90);
        }

        void NextStep(object sender, EventArgs e)
        {
            ManySteps++;

            byte command = Utils.PrepereCommand((byte) Steps, StepsDirection - Direction);

            try
            {
                Utils.ParseResponse(Robot.Action(command), out Energy, out Distance);
                
                Position = Vector.FromPolar(StepsDirection).Multiply(Steps).Add(Position);
                Direction = Utils.To360Deg(StepsDirection);
                AfterSelectAim(NextTarget());

                Ai.OnMove(Position, Distance);
                GameMap.GoRobot(Position, Direction);

                UpdateInfoTable();

                if(Distance == 0)
                    OpenDialog(new Winner(ResetWindow, Position, ManySteps, Energy));
                else if(Energy == 0)
                    OpenDialog(new BatteryDead(ResetWindow));
                
            }
            catch (BatteryException)
            {
                OpenDialog(new BatteryDead(ResetWindow));
            }
            catch (Exception err)
            {
                OpenDialog(new Fail(ResetWindow, err.Message));
            }
            
        }

        void OpenDialog(Control component)
        {
            Window = new Form();

            Window.StartPosition = FormStartPosition.CenterScreen;
            Window.FormBorderStyle = FormBorderStyle.None;

            Window.Size = component.Size;

            Window.Controls.Add(component);
            Window.ShowDialog();
        }

        void ResetWindow(bool resetGame)
        {
            Window?.Close();

            if(resetGame) RestartGame();
        }

        void ResetWindow()
        {
            ResetWindow(true);
        }

        void AIMove(object sender, EventArgs e)
        {
            try
            {
                AfterSelectAim(Ai.PredictMove());
            }
            catch (Exception err)
            {
                OpenDialog(new Fail(ResetWindow, err.Message, false));
            }
        }

        void ButtonReset_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        void Main_Load(object sender, EventArgs e)
        {
            RestartGame();
        }

        void ButtonDescription_Click(object sender, EventArgs e)
        {
            OpenDialog(new Description(ResetWindow));
        }
    }
}
