using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gdi32_Sin
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();

            for (double x = 0; x < 1000; x+=0.1)
            {
                points.Add(new Point((int)(x*10), (int)(Math.Sin(x * 10 * (Math.PI / 180)) * 100)));
            }

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                Pen axisPen = new Pen(Color.Black, 2);
                Pen graphPen = new Pen(Color.Red, 3);

                g.DrawLine(axisPen, 1, 0, 0, pictureBox.Height);
                g.DrawLine(axisPen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2);

                for (int i=1; i<points.Count; i++)
                {
                    int x1 = points[i-1].X;
                    int y1 = points[i-1].Y;
                    int x2 = points[i].X;
                    int y2 = points[i].Y;

                    g.DrawLine(graphPen, x1, y1 + pictureBox.Height / 2, x2, y2 + pictureBox.Height / 2);
                }

                pictureBox.BackgroundImage = bitmap;
            }
        }
    }
}
