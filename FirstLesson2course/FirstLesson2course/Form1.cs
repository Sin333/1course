using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLesson2course
{
    public partial class Form1 : Form
    {
        int x_md, y_md, Width_pen = 3 ,Alpha=255,Red_color=15,Green_color=30,Blue_color=255;
        //solidbrush
        Color PColor = new Color();
        Pen p = new Pen(Color.DarkOrange);
        SolidBrush myBrush = new SolidBrush(Color.DarkOrange);
        bool bPaint,bFigure=true;
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = p.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Start Paint
            bPaint = true;
            //Координаты мыши начальная точка
            x_md = e.X;
            y_md = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bPaint)
            {
                //Create Graphics object
                Graphics g = CreateGraphics();
                //Опр позицию мыши при перемещении
                int x_mm = e.X, y_mm = e.Y;
                //if (bFigure)
                //{
                    
                    Rectangle rect = new Rectangle(e.X, e.Y, Width_pen, Width_pen);
                    //g.FillEllipse(myBrush, rect);
                    g.DrawEllipse(p, rect);
                //}
                //g.DrawLine(p, x_md, y_md, x_mm, y_mm);
                x_md = x_mm;
                y_md = y_mm;
                g.Dispose();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bPaint = false;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Graphics g = CreateGraphics();
                g.Clear(this.BackColor);
                g.Dispose();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();
            Width_pen = vScrollBar1.Value;
            p.Width = Width_pen;
            
        }
        //Check Color
        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            PColor=colorDialog1.Color;
            p = new Pen(PColor, Width_pen);
        }
        //Alpha
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox3.Text);
                if (Alpha != tmp)
                    Alpha = tmp;
                p = new Pen(Color.FromArgb(Alpha, Red_color, Green_color, Blue_color), Width_pen);
            }
            catch
            {
                textBox3.Text = "" + Alpha;
                errorMassage();
            }
        }
        //Red
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox4.Text);
                if (Red_color != tmp)
                    Red_color = tmp;
                p = new Pen(Color.FromArgb(Alpha, Red_color, Green_color, Blue_color), Width_pen);
            }
            catch
            {
                textBox4.Text = "" + Red_color;
                errorMassage();
            }
        }
        //Green
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox5.Text);
                if (Green_color != tmp)
                    Green_color = tmp;
                p = new Pen(Color.FromArgb(Alpha, Red_color, Green_color, Blue_color), Width_pen);
            }
            catch
            {
                textBox5.Text = "" + Green_color;
                errorMassage();
            }
        }
        //Blue
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox6.Text);
                if (Blue_color != tmp)
                    Blue_color = tmp;
                p = new Pen(Color.FromArgb(Alpha, Red_color, Green_color, Blue_color), Width_pen);
            }
            catch
            {
                textBox6.Text = "" + Blue_color;
                errorMassage();
            }
        }
        //Wight pen
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox1.Text);
                if (Width_pen != tmp)
                    Width_pen = tmp;
                p = new Pen(Color.FromArgb(Alpha, Red_color, Green_color, Blue_color), Width_pen);
            }
            catch
            {
                textBox1.Text = ""+Width_pen;
                errorMassage();
                
            }
        }
        //Clear
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();
        }
        //errorka
        public void errorMassage()
        {
            MessageBox.Show("Error неверно введены данные");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + Width_pen;
            textBox3.Text = "" + Alpha;
            textBox4.Text = "" + Red_color;
            textBox5.Text = "" + Green_color;
            textBox6.Text = "" + Blue_color;
        }
    }
}
