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
        enum WordState
        {
            added,
            correct,
            skipped,
            unknown
        };

        public clsParseSentenceErrors(System.Drawing.Color IncorrectWordColor)
        {
            IncorrectWordColor1 = IncorrectWordColor;
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
                    //RichTextBoxIn.SelectionColor = Color.MidnightBlue;
                    RichTextBoxIn.SelectionColor = IncorrectWordColor1;
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
                    Color colorCorrect = System.Drawing.SystemColors.MenuHighlight;
                    RichTextBoxIn.SelectionFont = fontCorrect;
                    RichTextBoxIn.SelectionColor = colorCorrect;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", originalCorrectWords[j]);

                }



            }

            //

        }

        public void GetHighlightedErrors3(string CorrectText, string HumanText, ref System.Windows.Forms.RichTextBox RichTextBoxIn,
            ref System.Windows.Forms.ListBox ListBox1, ref System.Windows.Forms.ListBox ListBox2)
        {

            List<string> sentence1 = new List<string>();
            List<clsWordValence> sentenceValences1 = new List<clsWordValence>();

            // Diagnostic
            sentenceValences1 = ParseSentence(CorrectText, HumanText, ref sentence1, ref ListBox1, ref ListBox2);

            RichTextBoxIn.Text = "";

            foreach (clsWordValence wordState1 in sentenceValences1)
            {
                if (wordState1.State == clsWordValence.WordState.added)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Italic);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Red;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);
                }
                else if (wordState1.State == clsWordValence.WordState.correct)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Regular);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Blue;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);
                }
                else if (wordState1.State == clsWordValence.WordState.skipped)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Strikeout);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Red;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);

                }
                else if (wordState1.State == clsWordValence.WordState.unknown)
                {
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Gray;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);
                }

                //else if (sentenceValences1[wordCount] == WordState.skipped)
                //{
                //    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                //    RichTextBoxIn.SelectionColor = System.Drawing.Color.Red;
                //    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState);
                //}
                //else if (sentenceValences1[wordCount] == WordState.unknown)
                //{
                //    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                //    RichTextBoxIn.SelectionColor = System.Drawing.Color.Gray;
                //    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState);
                //}
                //wordCount++;
            }

            //

        }

        private List<clsWordValence> ParseSentence(string CorrectText, string HumanText, ref List<string> ReconstitutedSentence, ref System.Windows.Forms.ListBox Listbox1, ref System.Windows.Forms.ListBox Listbox2)
        //private void ParseSentence(string CorrectText, string HumanText)
        {
            CorrectText = CorrectText.Trim();
            HumanText = HumanText.Trim();

            CorrectText = "Now is the time for all good men to come to the aid of their party.";
            HumanText = "Little Women is good to read";

            string[] correctWords = SplitSentenceIntoWordsAndPunctuation(CorrectText);
            string[] humanWords = SplitSentenceIntoWordsAndPunctuation(HumanText);

            List<int?> correctSentence = new List<int?>();

            //List<clsWordValence> correctSentence = new List<clsWordValence>();
            //List<clsWordValence> humanSentence = new List<clsWordValence>();
            List<clsWordValence> reconstitutedSentence = new List<clsWordValence>();

            //// Load the CorrectWord and HumanWord lists
            //for (int i = 0; i < correctWords.Length; i++) correctSentence.Add(new clsWordValence(correctWords[i], clsWordValence.WordState.unknown));
            //for (int i = 0; i < humanWords.Length; i++) humanSentence.Add(new clsWordValence(humanWords[i], clsWordValence.WordState.unknown));

            //// Insure each list matches the other
            //if (correctWords.Length > humanWords.Length) for (int i = humanWords.Length; i < correctWords.Length; i++) humanSentence.Add(new clsWordValence("", clsWordValence.WordState.unknown));
            //if (correctWords.Length < humanWords.Length) for (int i = correctWords.Length; i < humanWords.Length; i++) correctSentence.Add(new clsWordValence("", clsWordValence.WordState.unknown));

            // Create vector of matches between "correct" and "human" arrays
            Boolean matchFound = false;
            int humanWordsPointer = 0;
            for (int i = 0; i < correctWords.Length; i++)
            {
                for (int j = humanWordsPointer; j < humanWords.Length; j++)
                {
                    if (correctWords[i] == humanWords[j])
                    {
                        matchFound = true;
                        humanWordsPointer = j + 1;
                    }
                }
                if (matchFound)
                    correctSentence.Add(humanWordsPointer);
                else
                    correctSentence.Add(null);

                matchFound = false;
            }

            //// Seek matches in both sentences 
            //int humanSentencePointer = 0;
            //foreach (clsWordValence item in correctSentence)
            //{
            //    for (int i = humanSentencePointer; i < humanSentence.Count(); i++)
            //    {
            //        if (item.Word == humanSentence[i].Word)
            //        {
            //            item.State = humanSentence[i].State = clsWordValence.WordState.correct;
            //            humanSentencePointer = i+1;
            //            break;
            //        }
            //    }
            //}

            //// Adjust valence settings in the two sentences
            //foreach (clsWordValence item in humanSentence)
            //{
            //    if (item.State != clsWordValence.WordState.correct) item.State = clsWordValence.WordState.added;
            //}
            //foreach (clsWordValence item in correctSentence)
            //{
            //    if (item.State != clsWordValence.WordState.correct) item.State = clsWordValence.WordState.skipped;
            //}


            //// Merge matches between sentences
            //for (int i = 0; i < correctSentence.Count(); i++)
            //{
            //    if (correctSentence[i].State == clsWordValence.WordState.correct)
            //    {
            //        reconstitutedSentence.Add(correctSentence[i]);

            //        if (humanSentence[i].State != clsWordValence.WordState.correct)
            //        {
            //            reconstitutedSentence.Add(humanSentence[i]);
            //        }
            //    }
            //    else
            //    {
            //        reconstitutedSentence.Add(correctSentence[i]);
            //        reconstitutedSentence.Add(humanSentence[i]);
            //    }
                
            //    //if (humanSentence[humanSentencePointer].State == clsWordValence.WordState.unknown)

            //    //    reconstitutedSentence.Add(humanSentence[humanSentencePointer]) 
            //    //if (item.State == clsWordValence.WordState.unknown)
            //    //{
            //    //    reconstitutedSentence.Add(new clsWordValence(item.Word, clsWordValence.WordState.skipped));
            //    //    if ((humanSentence[humanSentencePointer].Word != "") && (humanSentence[humanSentencePointer].State != clsWordValence.WordState.correct))
            //    //        reconstitutedSentence.Add(new clsWordValence(humanSentence[humanSentencePointer].Word, clsWordValence.WordState.added));
            //    //}
            //}

            //// Diagnostic - Return Listbox values
            //foreach (clsWordValence item in correctSentence)
            //{
            //    Listbox1.Items.Add(string.Format("{0}\t{1}", item.Word, item.State));
            //}

            //foreach (clsWordValence item in humanSentence)
            //{
            //    Listbox2.Items.Add(string.Format("{0}\t{1}", item.Word, item.State));
            //}

            return reconstitutedSentence;
        }

        private string[] SplitSentenceIntoWordsAndPunctuation(string Input)
        {
            char[] characters = Input.ToCharArray();

            List<string> bufferList = new List<string>();
            string bufferString = string.Empty;

            foreach (char character in characters)
            {
                if (IsBasicLetter(character)) bufferString += character;

                // Split on spaces
                if (character == ' ')
                {
                    // Add previously assembled string to the string list
                    bufferList.Add(bufferString);
                    bufferString = string.Empty;
                }

                // Split on punctuation
                if ((character == '.') || (character == ','))
                {
                    // Add previously assembled string to the string list
                    bufferList.Add(bufferString);
                    bufferString = string.Empty;

                    // Add the punctuation character to the string list
                    bufferList.Add(character.ToString());
                }
            }

            //bufferList.Add(bufferString);
            return bufferList.ToArray();
        }

        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }

        private System.Drawing.Color CorrectWordColor1 { get; set; }
        private System.Drawing.Color IncorrectWordColor1 { get; set; }
        private System.Drawing.Color IncompleteWordColor1 { get; set; }
        private System.Drawing.Color AddedWordColor1 { get; set; }

    }
}
