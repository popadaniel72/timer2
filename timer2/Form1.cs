using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer2
{
    public partial class Form1 : Form
    {
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
            r = g = b = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b+=16;
            if (b == 256) { b = 0; g+=16; }
            if (g == 256) { g = 0; r+=16; }
            if(r == 256) { r = g = b = 0; }
            Form1.ActiveForm.BackColor = Color.FromArgb(r,g,b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void poza_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < 5) poza.Top += e.Y;
            if (e.Y > poza.Height - 5) poza.Top -= poza.Height - e.Y;
            if (e.X < 5) poza.Left += e.X;
            Form1.ActiveForm.Invalidate();
        }

        private void poza_Click(object sender, EventArgs e)
        {

        }
    }
}
