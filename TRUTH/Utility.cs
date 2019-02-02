using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TRUTH
{
    public static class Utility
    {
        static Bitmap pix = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public static void Magnify(Graphics g, int x, int y, int width, int height)
        {
            var lefttop = new Point(x, y);
            var _size = new Size(width, height);
            using (var bmp = new Bitmap(width, height))
            using (var gbmp = Graphics.FromImage(bmp))
            {
                gbmp.CopyFromScreen(lefttop, new Point(), _size);
                g.CompositingQuality = CompositingQuality.HighSpeed;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.None;
                g.SmoothingMode = SmoothingMode.None;
                for (int _x = 0; _x < width; _x++)
                    for (int _y = 0; _y < height; _y++)
                        g.FillRectangle(new SolidBrush(Color.FromArgb(bmp.GetPixel(_x, _y).ToArgb() ^ 0xffffff)), _x, _y, 1, 1);
            }
        }
    }
}
