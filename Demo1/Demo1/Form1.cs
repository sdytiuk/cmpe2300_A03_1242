using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        int initialX;
        int value;

        public Form1()
        {
            InitializeComponent();
            Text = "Demo1";
            lblScroll.Text = "Click and drag";
            lblScroll.MouseDown += LblScroll_MouseDown;
            lblScroll.MouseMove += LblScroll_MouseMove;
            lblScroll.MouseUp += LblScroll_MouseUp;
        }

        private void LblScroll_MouseUp(object sender, MouseEventArgs e)
        {
            lblScroll.Capture = false;
        }

        private void LblScroll_MouseMove(object sender, MouseEventArgs e)
        {
            if (!lblScroll.Capture)
                return;
            value = (e.X - initialX)/10;
            lblScroll.Text = value.ToString();
        }

        private void LblScroll_MouseDown(object sender, MouseEventArgs e)
        {
            lblScroll.Capture = true;
            initialX = e.X;
        }
    }
}
