using System;
using System.Windows.Forms;

namespace TrybGraficzny
{
    public partial class BatteryDead : UserControl
    {
        SubmitCallback Callback;

        public delegate void SubmitCallback();

        public BatteryDead(SubmitCallback fn)
        {
            Callback = fn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Callback?.Invoke();
        }
    }
}
