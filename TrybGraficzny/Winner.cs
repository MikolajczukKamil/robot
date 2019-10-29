using System;
using System.Windows.Forms;
using Helpers;

namespace TrybGraficzny
{
    public partial class Winner : UserControl
    {
        SubmitCallback Callback;

        public delegate void SubmitCallback();

        public Winner(SubmitCallback fn, Vector position, int moves = 0, int energy = 0)
        {
            Callback = fn;
            InitializeComponent();

            result.Text = $"({position.X}, {position.Y})";
            movesCounter.Text = $"Potrzebne ruchy: {moves}, Pozostało energii: {energy}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Callback?.Invoke();
        }
    }
}
