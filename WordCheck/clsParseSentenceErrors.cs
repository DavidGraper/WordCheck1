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

        #region Initialize

        public clsParseSentenceErrors(System.Drawing.Color CorrectWordColor, System.Drawing.Color IncorrectWordColor)
        {
            CorrectWordColor1 = CorrectWordColor;
            IncorrectWordColor1 = IncorrectWordColor;
        }

        #endregion

        #region Private Methods

        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }

        private List<clsWordValence> ParseSentence(string CorrectText, string HumanText, ref List<string> ReconstitutedSentence)
        {
            CorrectText = CorrectText.Trim();
            HumanText = HumanText.Trim();

            // Diagnostic - Load problem sentence for debugging
            //HumanText = "Little Women is the good book to";

            string[] correctWords = SplitSentenceIntoWordsAndPunctuation(CorrectText);
            string[] humanWords = SplitSentenceIntoWordsAndPunctuation(HumanText);

            List<clsWordMatch> humansentence = new List<clsWordMatch>();
            List<clsWordValence> reconstitutedSentence = new List<clsWordValence>();

            // Create vector of matches between "human" and "correct" arrays
            int correctWordsPointer = 0;
            for (int i = 0; i < humanWords.Length; i++)
            {
                clsWordMatch humanWord = new clsWordMatch(humanWords[i], null);
                for (int j = correctWordsPointer; j < correctWords.Length; j++)
                {
                    if (humanWords[i] == correctWords[j])
                    {
                        correctWordsPointer = j;
                        humanWord.MatchPosition = correctWordsPointer;
                        break;
                    }
                }
                humansentence.Add(humanWord);
            }

            // Reconstitute sentence
            int? correctSentenceStartPointer = null;
            int correctSentenceEndPointer = 0;

            // If no human sentence, all words are marked "Skipped"
            if (humansentence.Count == 0)
            {
                for (int i = 0; i < correctWords.Count(); i++)
                {
                    reconstitutedSentence.Add(new clsWordValence(correctWords[i], clsWordValence.WordState.skipped));
                }
                return reconstitutedSentence;
            }

            foreach (clsWordMatch item in humansentence)
            {

                if (item.MatchPosition == null) reconstitutedSentence.Add(new clsWordValence(item.Word, clsWordValence.WordState.added));
                else
                {
                    correctSentenceEndPointer = (int)item.MatchPosition;

                    if (correctSentenceStartPointer == null)  // On first match between human and correct words
                    {
                        for (int i = 0; i < correctSentenceEndPointer; i++)
                            reconstitutedSentence.Add(new clsWordValence(correctWords[i], clsWordValence.WordState.skipped));

                        reconstitutedSentence.Add(new clsWordValence(item.Word, clsWordValence.WordState.correct));
                        correctSentenceStartPointer = correctSentenceEndPointer + 1;
                    }
                    else  // On all subsequent matches
                    {
                        for (int i = (int)correctSentenceStartPointer; i < correctSentenceEndPointer; i++)
                            reconstitutedSentence.Add(new clsWordValence(correctWords[i], clsWordValence.WordState.skipped));

                        reconstitutedSentence.Add(new clsWordValence(item.Word, clsWordValence.WordState.correct));
                        correctSentenceStartPointer = correctSentenceEndPointer + 1;
                    }
                }
            }

            // If there are any remaining entries in the "Correct" words, add them as "Skipped"
            correctSentenceEndPointer++;
            for (int i = correctSentenceEndPointer; i < correctWords.Count(); i++)
            {
                reconstitutedSentence.Add(new clsWordValence(correctWords[i], clsWordValence.WordState.skipped));
            }

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

            // Handle any last word in the string
            if (bufferString.Length > 0) bufferList.Add(bufferString);

            return bufferList.ToArray();
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

        #endregion

        #region Public Methods

        public void GetHighlightedErrors(string CorrectText, string HumanText, ref System.Windows.Forms.RichTextBox RichTextBoxIn,
            ref System.Windows.Forms.ListBox ListBox1, ref System.Windows.Forms.ListBox ListBox2)
        {

            List<string> sentence1 = new List<string>();
            List<clsWordValence> sentenceValences1 = new List<clsWordValence>();

            // Diagnostic
            sentenceValences1 = ParseSentence(CorrectText, HumanText, ref sentence1);

            RichTextBoxIn.Text = "";

            foreach (clsWordValence wordState1 in sentenceValences1)
            {
                if (wordState1.State == clsWordValence.WordState.added)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Italic);
                    RichTextBoxIn.SelectionColor = IncorrectWordColor1;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);
                }
                else if (wordState1.State == clsWordValence.WordState.correct)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Regular);
                    RichTextBoxIn.SelectionColor = CorrectWordColor1;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);
                }
                else if (wordState1.State == clsWordValence.WordState.skipped)
                {
                    RichTextBoxIn.SelectionFont = new Font("Courier New", 18, FontStyle.Strikeout);
                    RichTextBoxIn.SelectionColor = IncorrectWordColor1;
                    RichTextBoxIn.SelectedText += string.Format("{0} ", wordState1.Word);

                }
            }
        }

        #endregion

        #region Properties

        private System.Drawing.Color CorrectWordColor1 { get; set; }
        private System.Drawing.Color IncorrectWordColor1 { get; set; }

        #endregion

    }
}
