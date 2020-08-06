using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx = -20;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Left = mp.X;
            label2.Top = mp.Y;
            label2.Text = "" + mp.X + "," + mp.Y;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * 11 / 10;
            }

            if (label1.Left+label1.Width > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 11 / 10;
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 11 / 10;
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 11 / 10;
            }
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            //MessageBox.Show("幅"+ClientSize.Width);
            //MessageBox.Show("高さ"+ClientSize.Height);
        }
    }
}
