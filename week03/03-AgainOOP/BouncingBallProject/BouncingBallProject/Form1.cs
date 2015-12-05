using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BouncingBallProject
{
    public partial class Form1 : Form
    {
        Point center = new Point(100, 100);
        Point direction = new Point(3, 0);
        int radius = 50;

        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.timer.Interval = 30;
            this.timer.Tick += timer_Tick;
            this.timer.Start();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillEllipse(Brushes.Blue, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);

            center.Offset(direction);
            if (center.X > this.Width && direction.X > 0)
            {
                direction.X = -direction.X;
            }
            if (center.X < 0 && direction.X < 0)
            {
                direction.X = -direction.X;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
