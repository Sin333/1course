using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        int Hour, Minute, Second;

        public Form1()
        {
            InitializeComponent();
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm tt";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;
        }
        //clock image
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        //Draw line
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen penH = new Pen(Color.Black,5);
            Pen penM = new Pen(Color.Black, 3);
            Pen penS = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            //Hours
            Point pH1 = new Point(110, 75);
            Point pH2 = new Point(110, 185);//!Not Touch
            g.DrawLine(penH, pH1, pH2);
            //Minute
            Point pM1 = new Point(110, 75);
            Point pM2 = new Point(110, 185);//!Not Touch
            g.DrawLine(penM, pM1, pM2);
            Point pS1 = new Point(110, 75);
            Point pS2 = new Point(110, 185);//!Not Touch
            g.DrawLine(penS, pS1, pS2);
            int k = 0;
            //while(k==0)
            //{
                if (Hour < DateTime.Now.Hour)
                {
                    e.Graphics.DrawLine(penH, pH1, pH2);
                    Hour = DateTime.Now.Hour;
                }
                if (Minute < DateTime.Now.Minute)
                {
                    e.Graphics.DrawLine(penM, pM1, pM2);
                    Minute = DateTime.Now.Minute;
                }
                if (Second < DateTime.Now.Second)
                {
                    e.Graphics.DrawLine(penS, pS1, pS2);
                //e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 200, 80);
                Second = DateTime.Now.Second;
                }
            //}
            //
        }
    }
}
