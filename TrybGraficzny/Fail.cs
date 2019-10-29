using System;
using System.Windows.Forms;

namespace TrybGraficzny
{
    public partial class Fail : UserControl
    {
        SubmitCallback Callback;
        bool resetGame;

        public delegate void SubmitCallback(bool resetGame);

        public Fail(SubmitCallback fn, string Message = "", bool reset = true)
        {
            Callback = fn;
            resetGame = reset;
            InitializeComponent();
            errorMessage.Text = Message;

            if (!reset)
                submit.Text = "Powtót do misji";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Callback?.Invoke(resetGame);
        }
    }
}
