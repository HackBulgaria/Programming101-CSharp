using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IDisplayable
    {
        System.Drawing.Color Color { get; set; }
        void Draw(System.Drawing.Graphics g);
    }
}
