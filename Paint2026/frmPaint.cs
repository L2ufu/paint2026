using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace PaintWinApp
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Graphics g;
        public bool isDrawing = false;
        public Point startPoint;
        public Point lastPoint;
        public string currentTool = "Brush";
        public Color currentColor = Color.Black;
        public Rectangle selectionRect;
        public Pen myPen = new Pen(Color.Black, 3f);
        public Form1()
        {
            InitializeComponent();
        }

        public void pctrBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }
        public void pctrBox_MouseUP(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
        public void pctrBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (pctrBox.Image == null)
                {
                    pctrBox.Image = new Bitmap(pctrBox.Width, pctrBox.Height);
                }

                using (Graphics g = Graphics.FromImage(pctrBox.Image))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(myPen, lastPoint, e.Location);
                }

                pctrBox.Invalidate();
                lastPoint = e.Location;
            }
        }
    }
}