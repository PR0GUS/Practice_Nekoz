using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class Form1 : Form
    {

        List<Star> myStars = new List<Star>();

  
        Color fillCol = Color.Yellow;
        Color lineCol = Color.Black;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("���������");
            comboBox1.Items.Add("������������");
            comboBox1.Items.Add("����������");
            comboBox1.SelectedIndex = 0;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fillCol = cd.Color;
            }
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                lineCol = cd.Color;
            }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            int s = (int)numericUpDown1.Value;

            Star newStar = new Star();
            newStar.type = comboBox1.SelectedIndex;
            newStar.size = s;

            newStar.x = mouseX;
            newStar.y = mouseY;

            newStar.fColor = fillCol;
            newStar.lColor = lineCol;

            myStars.Add(newStar);
            listBox1.Items.Add("ǳ��� " + (newStar.type + 1) + " �� [" + mouseX + ";" + mouseY + "]");

            UpdateCanvas();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �� ����� ���� ��� ��������!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myStars.Clear();
            listBox1.Items.Clear();
            UpdateCanvas();
        }


        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int i = listBox1.SelectedIndex;
                myStars.RemoveAt(i);
                listBox1.Items.RemoveAt(i);
                UpdateCanvas();
            }
        }


        void UpdateCanvas()
        {
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);

            foreach (Star s in myStars)
            {
                Pen p = new Pen(s.lColor, 2);
                SolidBrush sb = new SolidBrush(s.fColor);

                if (s.type == 0) 
                {
                    g.FillRectangle(sb, s.x - s.size / 2, s.y - s.size / 2, s.size, s.size);
                    g.DrawRectangle(p, s.x - s.size / 2, s.y - s.size / 2, s.size, s.size);
                }
                else if (s.type == 1) 
                {
                    g.DrawLine(p, s.x - s.size, s.y, s.x + s.size, s.y);
                    g.DrawLine(p, s.x, s.y - s.size, s.x, s.y + s.size);
                }
                else 
                {
                    Point[] pts = {
                        new Point(s.x, s.y - s.size),
                        new Point(s.x + s.size, s.y),
                        new Point(s.x, s.y + s.size),
                        new Point(s.x - s.size, s.y)
                    };
                    g.FillPolygon(sb, pts);
                    g.DrawPolygon(p, pts);
                }
            }
            pictureBox1.Image = b;
        }
    }

   
    public class Star
    {
        public int type, x, y, size;
        public Color fColor, lColor;
    }
}