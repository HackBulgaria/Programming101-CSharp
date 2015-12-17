using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDisplayable
    {
        public System.Drawing.Color Color { get; set; }

        public Rectangle()
        {
            Color = System.Drawing.Color.Yellow;
        }

        public void Draw(System.Drawing.Graphics g)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(Color);
            g.DrawRectangle(pen, 20, 50, 100, 40);
        }
    }
}
