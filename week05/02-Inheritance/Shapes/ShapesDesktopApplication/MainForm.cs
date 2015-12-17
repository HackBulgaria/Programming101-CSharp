using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDesktopApplication
{
    public partial class MainForm : Form
    {
        private List<Shapes.IDisplayable> displayableObjects;

        public MainForm()
        {
            InitializeComponent();

            displayableObjects = new List<Shapes.IDisplayable>();
            displayableObjects.Add(new Shapes.Rectangle());
        }

        private void pnlDrawArea_Paint(object sender, PaintEventArgs e)
        {
            foreach(var obj in displayableObjects)
            {
                obj.Draw(e.Graphics);
            }
        }
    }
}
