using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResult.Text += "Starting" + Environment.NewLine;
            BeginSlowWork();
            txtResult.Text += "Continued main thread" + Environment.NewLine;
        }

        private void Callback()
        {
            txtResult.Text += "Callback called" + Environment.NewLine;
        }

        private void BeginSlowWork()
        {
            var thread = new Thread(delegate()
            {
                Thread.Sleep(10000);

                BeginInvoke((Action)Callback);
            });
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
