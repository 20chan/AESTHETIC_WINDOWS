using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUTH
{
    public partial class Background : Form
    {
        public static Background Instance;

        public Point ImgLoc;
        public Background()
        {
            InitializeComponent();

            Instance = this;

            this.Move += Background_Move;
        }

        private void Background_Move(object sender, EventArgs e)
        {
            this.ImgLoc = new Point(Location.X + pictureBox1.Location.X, Location.Y + pictureBox1.Location.Y);
        }
    }
}
