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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items[0].ToString();

            DateTime start = DateTime.Now;

            //while (textBox1.Text != label1.Text)
            //    {
            //        //
            //    }

            DateTime end = DateTime.Now;

            TimeSpan difference = start - end;

            listBox2.Items.Add(textBox1.Text + difference.Seconds.ToString());

        }
    }
}
