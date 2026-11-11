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
            bmp = new Bitmap(pctrBox.Width, pctrBox.Height);
            pctrBox.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
        }

        public void pctrBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                lastPoint = e.Location;
            }
        }

        public void pctrBox_MouseUP(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;

                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);
                int width = Math.Abs(e.X - startPoint.X);
                int height = Math.Abs(e.Y - startPoint.Y);

                switch (currentTool)
                {
                    case "Прямоугольник":
                        g.DrawRectangle(myPen, x, y, width, height);
                        break;

                    case "Овал":
                        g.DrawEllipse(myPen, x, y, width, height);
                        break;

                    case "Круг":
                        int diameter = Math.Max(width, height);
                        g.DrawEllipse(myPen, x, y, diameter, diameter);
                        break;

                    case "Треугольник":
                        Point topPoint = new Point(x + width / 2, y);
                        Point leftBottom = new Point(x, y + height);
                        Point rightBottom = new Point(x + width, y + height);

                        Point[] trianglePoints = { topPoint, leftBottom, rightBottom };
                        g.DrawPolygon(myPen, trianglePoints);
                        break;
                }
                pctrBox.Invalidate();
            }
        }

        public void pctrBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentTool == "Brush")
            {
                g.DrawLine(myPen, lastPoint, e.Location);
                pctrBox.Invalidate();
                lastPoint = e.Location;
                myPen.StartCap = myPen.EndCap = LineCap.Round;

            }


        }
        public void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            currentTool = item.Text;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.White;
            myPen.Width = 15f;
        }

        private void toolStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            currentTool = "Brush";
            myPen.Width = 3f;
            myPen.Color = Color.Black;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
            {
                case "Микро":
                    myPen.Width = 1f;
                    break;

                case "Маленький":
                    myPen.Width = 4f;
                    break;

                case "Средний":
                    myPen.Width = 8f;
                    break;

                case "Большой":
                    myPen.Width = 15f;
                    break;

            }
        }

        private void toolStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            using (ColorDialog ColorDialog = new ColorDialog()) 
            {
                ColorDialog.FullOpen = true;
                ColorDialog.Color = currentColor;
                if(ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = ColorDialog.Color;
                    myPen.Color = currentColor;
                }
            }
        }
    }
}