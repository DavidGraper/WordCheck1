using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCheck
{
    public partial class frmCountdown : Form
    {
        public frmCountdown()
        {
            InitializeComponent();
        }

        private int countDown = 6;

        private void frmCountdown_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown < 1)
            {
                //countDown = 30;
                this.Close();
            }
            label1.Text = countDown.ToString();

            //if (countDown == 0) this.Close();
        }
    }
}
