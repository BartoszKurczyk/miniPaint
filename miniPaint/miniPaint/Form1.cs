using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace miniPaint
{
    public partial class Form1 : Form
    {
        int startX, startY;
        Pen drawingPen;
        Figure figure;
        bool drawFlag;
        

        public Form1()
        {
            InitializeComponent();
            drawingPen = Pens.Black;
            figure = new Sandbox();
            drawFlag = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            startX = e.X;
            startY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawFlag)
            {
                Graphics graph = panel1.CreateGraphics();
                figure.Draw(drawingPen, graph, startX, startY, e.X, e.Y);
            }
            drawFlag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag)
            {
                Graphics graph = panel1.CreateGraphics();
                figure.DrawMove(drawingPen, graph, e.X, e.Y, 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawingPen = Pens.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawingPen = Pens.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawingPen = Pens.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figure = new Sandbox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figure = new Line();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figure = new Rectangle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
