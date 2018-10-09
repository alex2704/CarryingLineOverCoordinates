using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        const int n = 4;
        Graphics g;
        Graphics g1;
        SolidBrush mySolidbrush;
        Pen myPen;
        Bitmap bitmap;
        int count = n;
        PointF[] p = new PointF[n];
        PointF[] a = new PointF[n];
        int check = 1;
        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
            draw_myCurve_btn.Enabled = false;
            myPen = new Pen(Color.Black,1);
            bitmap = new Bitmap(ClientSize.Width,
              ClientSize.Height);
            g = Graphics.FromImage(bitmap);
            g1 = this.CreateGraphics();
            Transfer_btn.Enabled = false;
        }
        private void DrawArr(PointF[] p)
        {
            myPen = new Pen(Color.Black,2);
            mySolidbrush = new SolidBrush(Color.Red);
            for (int i = 0; i < n; i++)
                g.FillRectangle(mySolidbrush, p[i].X,p[i].Y,6,6);
        }
        PointF[] StepPoint = new PointF[n];
        private static void CheckDistance(PointF[] p, PointF[] a, PointF[] StepPoint)
        {
            float distanceX, distanceY;
            float stepX, stepY;
            for (int i = 0; i < p.Length; i++)
            {
                distanceX = a[i].X - p[i].X;
                stepX = distanceX / 100;
                distanceY = a[i].Y - p[i].Y;
                stepY = distanceY / 100;
                StepPoint[i] = new PointF(stepX, stepY);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (count > 0 && check % 2 != 0)
            {
                p[n - count] = new Point(e.X,e.Y);
                g.DrawRectangle(myPen, e.X, e.Y, 2,2);
                count--;
            }
            else if (count > 0 && check % 2 == 0)
            {
                a[n - count] = new Point(e.X, e.Y);
                g.DrawRectangle(myPen, e.X, e.Y, 2, 2);
                count--;
            }
            if(count == 0 && check % 2 != 0)
            {
                draw_myCurve_btn.Enabled = true;
                drawing = true;
                DrawArr(p);
            }
            else if(count == 0 && check % 2 == 0)
            {
                Transfer_btn.Enabled = true;
                DrawArr(a);
            }
            g1.DrawImage(bitmap, ClientRectangle);
        }

        private void draw_myCurve_btn_Click(object sender, EventArgs e)
        {
            if (drawing && check % 2 != 0)
                g.DrawCurve(myPen, p, 1);
            g1.DrawImage(bitmap, ClientRectangle);
            drawing = false;
            count = 4;
            check++;
            draw_myCurve_btn.Enabled = false;
        }
        Pen specialPen = new Pen(Color.White,2);
        private void timer1_Tick(object sender, EventArgs e)
        {
                g.DrawCurve(specialPen, p);
                p[0].X += StepPoint[0].X;
                p[0].Y += StepPoint[0].Y;
                p[1].X += StepPoint[1].X;
                p[1].Y += StepPoint[1].Y;
                p[2].X += StepPoint[2].X;
                p[2].Y += StepPoint[2].Y;
                p[3].X += StepPoint[3].X;
                p[3].Y += StepPoint[3].Y;
                g.DrawCurve(myPen,p);
                g1.DrawImage(bitmap, ClientRectangle);
            if (p[0].X - 0.01 <= a[0].X && p[0].X + 0.01 >= a[0].X)
            {
                timer1.Enabled = false;
                Transfer_btn.Enabled = false;
                draw_myCurve_btn.Enabled = false;
            }
        }

        private void Transfer_btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;

            }
            else
            {
                timer1.Enabled = true;
            }
            CheckDistance(p, a, StepPoint);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Color cl = Color.FromArgb(255, 255, 255);
            g1.Clear(cl);
            g.Clear(cl);
            drawing = false;
            count = n;
            check = 1;
        }
    }
}
