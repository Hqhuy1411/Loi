using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7
{
    public partial class Form1 : Form
    {
        Point point;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{
            //    Graphics g = this.CreateGraphics();
            //    Pen pen = new Pen(Color.Red, 2f);
            //    g.DrawLine(pen, point, e.Location);
            //}
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Red, 2f);
                g.DrawLine(pen, point, e.Location);
            }
        }
    }
}
