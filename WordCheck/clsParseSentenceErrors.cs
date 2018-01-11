using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Drawing;

namespace WordCheck
{
    public class clsParseSentenceErrors
    {
        public clsParseSentenceErrors( )
        {
           
        }

        private string StripStringOfPunctuation(string StringIn)
        {
            try
            {
                return Regex.Replace(StringIn, @"[^\w\s]", "");
            }
            catch (Exception ex)
            {
                return string.Format("ERROR IN REGEX: '{0]' ", ex.Message);
            }

        }

        public void GetHighlightedErrors(string CorrectText, string HumanText, ref System.Windows.Forms.LinkLabel LinkLabelIn)
        {
            int correctPointer = 0;
            int humanBasePointer = 0;

            string originalCorrectText = CorrectText;

            //CorrectText = StripStringOfPunctuation(CorrectText);
            //HumanText = StripStringOfPunctuation(HumanText);

            string[] correctWords = CorrectText.Split();
            string[] humanWords = HumanText.Split();

            bool[] wordIsCorrect = new bool[correctWords.Count()];

            // Compare the arrays

            int totalCorrectWords = correctWords.Count();
            int totalHumanWords = humanWords.Count();

            while (correctPointer < totalCorrectWords)
            {
                for (int humanPointer = humanBasePointer; humanPointer < humanWords.Count(); humanPointer++)
                {
                    if (humanWords[humanPointer].ToUpper() == correctWords[correctPointer].ToUpper())
                    {
                        wordIsCorrect[correctPointer] = true;
                        humanBasePointer = humanPointer + 1;
                        break;
                    }
                }
                correctPointer++;

                if (humanBasePointer > humanWords.Count()-1) break;
            }

            //// Format the "correct" sentence with errors marked as a LinkLabel 
            //int start, length;
            //for (int i = 0; i < correctWords.Length; i++)
            //{
            //    LinkLabelIn.Text += correctWords[i];
            //    start = LinkLabelIn.Text.Length;
            //    if (correctWords[i].Substring(0,2) == "**") // If this is an "error" word
            //    {
            //        length = correctWords[i].Length - 1;
            //        LinkLabelIn.Text += " " + correctWords[i].Substring(2, length);
            //        LinkLabelIn.Links.Add(start, length);
            //    }
            //    else
            //    {
            //        LinkLabelIn.Text += " " + correctWords[i];
            //    }
            //}

            //FormattedLlinkLabel1.Text = "You are accessing a government system, and all activity " +
            ////      "will be logged.  If you do not wish to continue, log out now.";

            //linkLabel1.AutoSize = false;
            ////linkLabel1.AutoSize = true;
            ////linkLabel1.Size = new Size(365, 50);
            //linkLabel1.Size = new Size(500, 150);
            ////linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            //linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            //linkLabel1.Links.Clear();
            ////linkLabel1.Links.Add(20, 17).Enabled = false;   // "government system"
            //linkLabel1.Links.Add(19, 5).Enabled = false;   // "government system"
            ////linkLabel1.Links.Add(105, 11).Enabled = false;  // "log out now"
            //linkLabel1.LinkColor = linkLabel1.ForeColor;
            //linkLabel1.DisabledLinkColor = linkLabel1.ForeColor; 

            //string assemblage = "";

            string[] originalCorrectWords = originalCorrectText.Split();

            LinkLabelIn.Text = "";
            LinkLabelIn.Links.Clear();

            for (int j = 0; j < originalCorrectWords.Count(); j++)
			{
                LinkLabelIn.Text += string.Format("{0} ", originalCorrectWords[j]);
                if (!wordIsCorrect[j])
                {
                    LinkLabelIn.Links.Add(LinkLabelIn.Text.Length - originalCorrectWords[j].Length - 1, originalCorrectWords[j].Length);
                }
			}

        }

        public void GetHighlightedErrors2(string CorrectText, string HumanText, ref System.Windows.Forms.RichTextBox RichTextBoxIn)
        {
            int correctPointer = 0;
            int humanBasePointer = 0;

            string originalCorrectText = CorrectText;

            //CorrectText = StripStringOfPunctuation(CorrectText);
            //HumanText = StripStringOfPunctuation(HumanText);

            CorrectText = CorrectText.Trim();
            HumanText = HumanText.Trim();

            string[] correctWords = CorrectText.Split();
            string[] humanWords = HumanText.Split();

            bool[] wordIsCorrect = new bool[correctWords.Count()];

            // Compare the arrays

            int totalCorrectWords = correctWords.Count();
            int totalHumanWords = humanWords.Count();

            while (correctPointer < totalCorrectWords)
            {
                for (int humanPointer = humanBasePointer; humanPointer < humanWords.Count(); humanPointer++)
                {
                    if (humanWords[humanPointer].ToUpper() == correctWords[correctPointer].ToUpper())
                    {
                        wordIsCorrect[correctPointer] = true;

                        humanBasePointer = humanPointer + 1;
                        break;
                    }
                }
                correctPointer++;

                if (humanBasePointer > humanWords.Count() - 1) break;
            }

            //// Format the "correct" sentence with errors marked as a LinkLabel 
            //int start, length;
            //for (int i = 0; i < correctWords.Length; i++)
            //{
            //    LinkLabelIn.Text += correctWords[i];
            //    start = LinkLabelIn.Text.Length;
            //    if (correctWords[i].Substring(0,2) == "**") // If this is an "error" word
            //    {
            //        length = correctWords[i].Length - 1;
            //        LinkLabelIn.Text += " " + correctWords[i].Substring(2, length);
            //        LinkLabelIn.Links.Add(start, length);
            //    }
            //    else
            //    {
            //        LinkLabelIn.Text += " " + correctWords[i];
            //    }
            //}

            //FormattedLlinkLabel1.Text = "You are accessing a government system, and all activity " +
            ////      "will be logged.  If you do not wish to continue, log out now.";

            //linkLabel1.AutoSize = false;
            ////linkLabel1.AutoSize = true;
            ////linkLabel1.Size = new Size(365, 50);
            //linkLabel1.Size = new Size(500, 150);
            ////linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            //linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            //linkLabel1.Links.Clear();
            ////linkLabel1.Links.Add(20, 17).Enabled = false;   // "government system"
            //linkLabel1.Links.Add(19, 5).Enabled = false;   // "government system"
            ////linkLabel1.Links.Add(105, 11).Enabled = false;  // "log out now"
            //linkLabel1.LinkColor = linkLabel1.ForeColor;
            //linkLabel1.DisabledLinkColor = linkLabel1.ForeColor; 

            //string assemblage = "";

            string[] originalCorrectWords = originalCorrectText.Split();

            RichTextBoxIn.Text = "";
            //RichTextBoxIn.Links.Clear();

            for (int j = 0; j < originalCorrectWords.Count(); j++)
            {



                if (!wordIsCorrect[j])
                {
                    RichTextBoxIn.SelectionColor = Color.Blue;
                    Font fontIncorrect = new Font("Courier New", 18, FontStyle.Underline | FontStyle.Bold);
                    RichTextBoxIn.SelectionFont = fontIncorrect;
                    RichTextBoxIn.SelectedText += string.Format("{0}", originalCorrectWords[j]);

                    fontIncorrect = new Font("Courier New", 18, FontStyle.Bold);
                    RichTextBoxIn.SelectionFont = fontIncorrect;
                    RichTextBoxIn.SelectedText += " ";
                }
                else
                {
                Font fontCorrect = new Font("Courier New", 18, FontStyle.Bold);
                RichTextBoxIn.SelectionFont = fontCorrect;
                RichTextBoxIn.SelectionColor = Color.Red; 
                RichTextBoxIn.SelectedText += string.Format("{0} ", originalCorrectWords[j]);

                }



            }

            //

        }




    }
}
