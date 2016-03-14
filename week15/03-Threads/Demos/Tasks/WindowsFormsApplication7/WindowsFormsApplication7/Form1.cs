using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtResult.Text += "Starting" + Environment.NewLine;
            var task = SlowWorkAsync();
            txtResult.Text += "Continued main thread" + Environment.NewLine;

            int result = await task;

            txtResult.Text += "Callback called "+result + Environment.NewLine;
        }

        private Task<int> SlowWorkAsync()
        {
            return Task.Run(delegate ()
            {
                Thread.Sleep(10000);

                return 5;
            });
        }
    }
}
