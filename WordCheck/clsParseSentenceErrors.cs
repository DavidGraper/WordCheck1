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

        public void GetHighlightedErrors3(string CorrectText, string HumanText, ref System.Windows.Forms.RichTextBox RichTextBoxIn)
        {
            int correctPointer = 0;
            int humanBasePointer = 0;

            List<string> sentence1 = new List<string>();
            List<WordState> sentenceValences1 = new List<WordState>();

            // Diagnostic
            ParseSentence(CorrectText, HumanText, ref sentence1, ref sentenceValences1);

            RichTextBoxIn.Text = "";


            int wordCount = 0;
            foreach (string word in sentence1)
            {
                if (sentenceValences1[wordCount] == WordState.added)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Strikeout);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.IndianRed;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", word);
                }
                else if (sentenceValences1[wordCount] == WordState.correct)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Green;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", word);
                }
                else if (sentenceValences1[wordCount] == WordState.skipped)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Red;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", word);
                }
                else if (sentenceValences1[wordCount] == WordState.unknown)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Bold);
                    RichTextBoxIn.SelectionColor = System.Drawing.Color.Gray;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", word);
                }
                wordCount++;
            }

            //

        }

        private void ParseSentence(string CorrectText, string HumanText, ref List<string> ReconstitutedSentence, ref List<WordState> ReconstitutedSentenceWordValues)
        //private void ParseSentence(string CorrectText, string HumanText)
        {
            CorrectText = CorrectText.Trim();
            HumanText = HumanText.Trim();


            string[] correctWords = SplitSentenceIntoWordsAndPunctuation(CorrectText);
            string[] humanWords = SplitSentenceIntoWordsAndPunctuation(HumanText);
            List<clsWordValence> correctSentence = new List<clsWordValence>();
            List<clsWordValence> humanSentence = new List<clsWordValence>();
            List<clsWordValence> reconstitutedSentence = new List<clsWordValence>();

            // Mark all words as "unknown" if human text is empty
            if (HumanText.Length == 0)
            {
                foreach (string word in correctWords)
                {
                    reconstitutedSentence.Add(word);
                    reconstitutedSentenceWordValences.Add(WordState.unknown);
                }
            }
            else
            {

                // Parse sentence
                //do
                //{
                //    if (correctWords[correctPointer] == humanWords[humanPointer])
                //    {
                //        reconstitutedSentence.Add(humanWords[humanPointer]);
                //        reconstitutedSentenceWordValences.Add(WordState.correct);
                //        correctPointer++;
                //        humanPointer++;
                //    }
                //    else
                //    {
                //        reconstitutedSentence.Add(humanWords[humanPointer]);
                //        reconstitutedSentenceWordValences.Add(WordState.added);
                //        humanPointer++;
                //    }
                //} while ((correctPointer < correctWords.Length) && (humanPointer < humanWords.Length));

                // If we haven't reached the end of the correct words, include them and mark them "incomplete"

                // Parse sentence



                int correctBasePointer = 0;
                Boolean matchFound = false;

                for (int humanPointer = 0; humanPointer < humanWords.Length; humanPointer++)
                {
                    for (int correctPointer = correctBasePointer; correctPointer < correctWords.Length; correctPointer++)
                    {
                        if (correctWords[correctPointer] == humanWords[humanPointer])
                        {
                            matchFound = true;
                            correctBasePointer = correctPointer;
                            break;
                        }
                    }

                    if (matchFound)
                    {
                        reconstitutedSentence.Add(humanWords[humanPointer]);

                    }
                    else
                    {
                        reconstitutedSentence.Add(humanWords[humanPointer]);
                    }

                    int k = 0;
                    if (reconstitutedSentence.Count() > 1) k = 0;

                }


                //// Backfill reconstituted sentence
                //if (correctPointer < correctWords.Count())
                //{
                //    for (int i = correctPointer; i < correctWords.Length; i++)
                //    {
                //        reconstitutedSentence.Add(correctWords[i]);
                //        reconstitutedSentenceWordValences.Add(WordState.unknown);
                //    }
                //}
            }

            ReconstitutedSentence = reconstitutedSentence;
            ReconstitutedSentenceWordValues = reconstitutedSentenceWordValences;

           

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

            bufferList.Add(bufferString);
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
