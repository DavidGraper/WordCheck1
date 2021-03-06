﻿using System;
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
    public partial class frmTest0 : Form
    {
        clsParseSentenceErrors parseSentenceErrors = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);

        public frmTest0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Red);

            //class1.GetHighlightedErrors(textBox2.Text, textBox1.Text, ref linkLabel1);
            ////class1.GetHighlightedErrors3(textBox2.Text, textBox1.Text, ref richTextBox1);

            //class1 = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int CorrectWords = textBox2.Text.Split(' ').Count();
            //int HumanWords = textBox1.Text.Split(' ').Count();

            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);

            if (textBox1.Text.Contains("???"))
            {
                frmLookupSteno lookup1 = new frmLookupSteno();
                lookup1.ShowDialog();
                textBox1.Text = "";
            }

            if (parseSentenceErrors.GetHighlightedErrors(textBox2.Text, textBox1.Text, ref richTextBox1))
                MessageBox.Show("Done");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //int CorrectWords = textBox2.Text.Split(' ').Count();
            //int HumanWords = textBox1.Text.Split(' ').Count();

            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);
            //class1.GetHighlightedErrors(textBox2.Text, textBox1.Text, ref richTextBox1);

        }

        private void frmTest0_Load(object sender, EventArgs e)
        {
            Font font = new Font("Courier New", 24, FontStyle.Bold);
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Hi ";

            richTextBox1.SelectionColor = Color.Blue;
            font = new Font("Courier New", 24, FontStyle.Underline | FontStyle.Bold);
            richTextBox1.SelectionFont = font; 


            richTextBox1.SelectedText += "Dave";
        }
    }
}
