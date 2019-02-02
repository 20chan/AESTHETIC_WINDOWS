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
    public partial class Magnifier : Form
    {
        Graphics g;
        public Magnifier()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            this.Resize += NeedInvalidate;
            this.Move += NeedInvalidate;

            this.TransparencyKey = this.BackColor;

            new Background().Show();
        }

        private void NeedInvalidate(object sender, EventArgs e)
        {
            var s = Background.Instance.ImgLoc;
            var d = this.Location;
            this.pictureBox1.Location = new Point(s.X - d.X, s.Y - d.Y);
        }
    }
}
