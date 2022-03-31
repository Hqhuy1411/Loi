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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "KeyChar " + e.KeyChar;
        }
        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {
            label2.Text = "KeyCode " + e.KeyCode + ", KeyData " + e.KeyData
               + ", KeyValue =" + e.KeyValue;
        }
    }
}
