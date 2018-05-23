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
    public partial class frmSentenceDrill : Form
    {
        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        private DateTime timeStart;
        private DateTime timeEnd;
        private DateTime timeDrillStart;

        private Boolean match = false;
        private Boolean abort = false;

        private long CurrentSentenceID;

        // Lists of time required for correctly entering sentences
        List<data_sentencecorrect> corrects = new List<data_sentencecorrect>();

        // List of sentences in the selected drill
        List<data_sentencedrills_sentence> sentences = new List<data_sentencedrills_sentence>();

        #region Initialize

        public frmSentenceDrill()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += Timer_Tick;
        }

        private void frmSentenceDrill_Load(object sender, EventArgs e)
        {
            lblTitle.Text = DrillName;
            pictureBox1.Image = Properties.Resources.ExpandArrow_16x;

            SetEnabledControls(false);

            timer1.Start();
        }

        #endregion

        #region Private Methods

        private List<data_sentencedrills_sentence> LoadDrill()
        {
            List<data_sentencedrills_sentence> return1 = new List<data_sentencedrills_sentence>();

            try
            {
                var query = from q in dc1.data_sentencedrills_sentences
                            where q.sentencedrillid == DrillID
                            select q;

                foreach (var item in query)
                {
                    return1.Add(item);
                }

                // Randomizing?
                Random rand = new Random();
                return1 = return1.OrderBy(c => rand.Next()).Select(c => c).ToList();

                // Set upper limit of progress bar
                progressBar1.Maximum = return1.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return return1;
        }

        //        private void LoadLightningDrill(ref List<data_sentencedrills_sentence> Words)
        //        {
        //            try
        //            {
        //                foreach (data_wordcorrect item in corrects)
        //                {
        //                    //if (item.msspeed < (Average + 2 * (StandardDeviation)))
        //                     if ((item.msspeed / 1000.00) < QuizAverage)
        //                    {
        //                        Words.Remove(Words.Find(word => word.dictionaryid == item.wordid));
        //                    }
        //                }

        //                // Set upper limit of progress bar
        //                progressBar1.Maximum = Words.Count;
        //                lblRetestingWords.Text = Words.Count.ToString();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }

        //        private List<string> LoadSentenceDrill()
        //        {
        //            List<string> return1 = new List<string>();

        //            try
        //            {

        //                //data_application application1 = new data_application();
        //                var query = from q in dc1.data_sentencedrills_sentence
        //                            where q.data_sentencedrill.drillname == "Chapter 19 - Punctuation"
        //                            select q.data_sentence.sentence;

        //                foreach (var item in query)
        //                {
        //                    return1.Add(item);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }

        //            return return1;
        //        }

        public void Timer_Tick(object sender, EventArgs e)
        {

            // Update on-screen time statistics
            TimeSpan drillTime = DateTime.Now - timeDrillStart;
            lblDrillTime.Text = string.Format("Drill Time:  {0} minutes, {1} seconds", drillTime.Minutes, drillTime.Seconds);

            // Get expected text and human-entered text
            string expectedResponse = rchTestSentence.Text.ToLower().Trim();
            string humanResponse = txtHumanResponse.Text.ToLower().Trim();

            lblComputer.Text = expectedResponse;
            lblHuman.Text = humanResponse;

            // Before checking discrepancies, exit under certain conditions 

            // 1.  If human has entered nothing
            if (humanResponse == "")
            {
                //entryBuffer = string.Empty;
                return;
            }

            // 2.  If the human's response is an exact match to the sentence
            if (humanResponse == expectedResponse)
            {

                //MessageBox.Show("Done");
                // Lots of BOINGs here

                match = true;

                //ErrorCount0 = 0;
                lblTotalSentences.Visible = false;
                //richTextBox1.Visible = false;

                return;
            }

            //// If there is a new entry from the human
            //if (humanResponse != entryBuffer)
            //{

                //// If human makes more than two mistakes, display the 
                //ErrorCount0++;
                //if (ErrorCount0 > 1) label2.Visible = true;

                //UpdateErrorMessage(ref lnkLabel);



                //HumanSentenceCount++;

                //// If the number of strokes meets or exceeds the strokes expected, this is a mistake
                //if (HumanSentenceCount >= SentenceWordCount)
                //{

                //    // Cache human's
                //    entryBuffer = humanResponse;

                //    data_wordconfusion dw1 = new data_wordconfusion();
                //    dw1.incorrectdate = DateTime.Now;
                //    dw1.incorrectword = humanResponse;
                //    dw1.wordid = CurrentSentenceID;

                //    mistakes.Add(dw1);
                //}
                //else
                //{
                //    if (humanResponse.Length > 0)
                //    {

                //        // Cache human's actual entry
                //        entryBuffer = humanResponse;
                //    }
                //    else
                //    {
                //        entryBuffer = "";
                //        HumanSentenceCount = 0;
                //    }
                //}
            //}
        }

        //        private void WriteResultsToDB()
        //        {
        //            foreach (data_wordconfusion item in mistakes)
        //            {
        //                if (item.incorrectword.Contains("khr-s")) continue;
        //                if (item.incorrectword == "") continue;

        //                dc1.pr_AddMistakeRecord(DrillID, item.wordid, item.incorrectword);
        //            }

        //            foreach (data_wordcorrect item in corrects)
        //            {
        //                dc1.pr_AddCorrectRecord(DrillID, item.wordid, item.msspeed, item.date);
        //            }

        //            dc1.SubmitChanges();
        //        }

        //        private void UpdateWordCounts(int TotalWords, int WordsCompleted)
        //        {
        //            lblWordsToGo.Text = string.Format("Words completed: {0}, words to go: {1}",
        //                WordsCompleted.ToString(), (TotalWords - WordsCompleted).ToString());

        //            // Color changes based on proximity to end of list
        //            if ((TotalWords - WordsCompleted) == 10)
        //            {
        //                lblWordsToGo.BackColor = SystemColors.ControlText;
        //                lblWordsToGo.ForeColor = SystemColors.Control;
        //            }

        //            if ((TotalWords - WordsCompleted) == 0)
        //            {
        //                lblWordsToGo.BackColor = SystemColors.Control;
        //                lblWordsToGo.ForeColor = SystemColors.ControlText;
        //            }

        //        }

        private void SetEnabledControls(Boolean Visible)
        {
            btnStop.Enabled =
            lblTitleHumanResponse.Enabled =
            lblTitleTestWordOrPhrase.Enabled =
            progressBar1.Visible = Visible;
        }

        private void UpdateStatistics()
        {
            //Average = getAverage(corrects) / 1000.00;
            //string averageSpeedInSeconds = Average.ToString();
            //string varianceInSeconds = (variance(corrects) / 1000.00).ToString();
            //StandardDeviation = standardDeviation(variance(corrects)) / 1000.00;

            //string stdevInSeconds = StandardDeviation.ToString();

            //lblAverageSpeed.Text = string.Format("Average speed (in seconds):  { 0} ", averageSpeedInSeconds);
            //lblStandardDeviation.Text = string.Format("Standard Deviation (in seconds):  {0}", stdevInSeconds);

            //// Done once
            //if (QuizAverage == 0) QuizAverage = Average;
        }

        #endregion

        #region Handle Controls

        private void txtHumanResponse_KeyDown(object sender, KeyEventArgs e)
        {
            //string correctSentence = rchTestSentence.Text;
            //string humanSentence = txtHumanResponse.Text;

            //int CorrectWords = correctSentence.Split(' ').Count();
            //int HumanWords = humanSentence.Split(' ').Count();

            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);
            //class1.GetHighlightedErrors(correctSentence, humanSentence, ref richTextBox1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double totalMilliSeconds = 0;
            double averageMilliSeconds = 0;

            frmCountdown frm1 = new frmCountdown();

            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog();

            timeDrillStart = DateTime.Now;

            SetEnabledControls(true);

            //List<data_sentencedrills_sentence> words = LoadDrill();
            sentences = LoadDrill();
            NewMethod(ref totalMilliSeconds, ref averageMilliSeconds, sentences);

            timer1.Start();

            // Ask about quick review
            // MessageBox.Show("Quick Review?");

            // Determine words > 1 Standardard Deviation and ask if you'd like to re-try them
            // LoadLightningDrill(ref words);

            // Run again
            // totalMilliSeconds = averageMilliSeconds = 0;
            // NewMethod(ref totalMilliSeconds, ref averageMilliSeconds, words);

        }

        private void NewMethod(ref double totalMilliSeconds, ref double averageMilliSeconds, List<data_sentencedrills_sentence> sentences)
        {
            int totalWords = sentences.Count;

            DateTime timeStart;
            DateTime timeEnd;

            lblTotalSentences.Text = string.Format("Total sentences = {0}", totalWords.ToString());

            timeStart = DateTime.Now;
            txtHumanResponse.Focus();

            // Start ticking
            timer1.Start();


            foreach (data_sentencedrills_sentence sentence in sentences)
            {
                //label2.Text = sentence.data_sentence.sentence;


                rchTestSentence.Text = sentence.data_sentence.sentence;
                CurrentSentenceID = sentence.id;

                string[] correctWordsInSentence = sentence.data_sentence.sentence.Split(' ');
                List<string> correctWords = correctWordsInSentence.ToList<string>();

                List<string> humanWords = new List<string>();

                // Get the number of words in the current sentence
                // SentenceWordCount = sentence.data_sentence.sentence.Split(' ').Length;
                //completedWords += 1;

                timeStart = DateTime.Now;

                while (!match && !abort)
                {
                    SendKeys.Flush();
                }

                if (abort) break;

                txtHumanResponse.Text = "";
                timeEnd = DateTime.Now;
                TimeSpan span1 = timeEnd - timeStart;

                //string time1 = span1.Seconds.ToString("D3") + ":" + span1.Milliseconds.ToString("D3");

                //data_wordcorrect correct1 = new data_wordcorrect();
                //correct1.date = DateTime.Now;
                //correct1.msspeed = (long)span1.TotalMilliseconds;
                //correct1.wordid = sentence.data_dictionary.id;
                //corrects.Add(correct1);

                //dataGridView1.Rows.Add(sentence.data_dictionary.english, time1);

                //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                //// Update average speed
                //totalMilliSeconds += span1.TotalMilliseconds;
                //averageMilliSeconds = totalMilliSeconds / completedWords;


                //lblAverageSpeed.Text = string.Format("Average speed = {0} seconds per word", Math.Round((averageMilliSeconds / 1000), 2));

                match = false;

                //UpdateWordCounts(sentences.Count, completedWords);

                progressBar1.Value++;

            }

            if (abort) this.Close();

            MessageBox.Show("Done!");

            //match = true;

            btnStop.Enabled = false;
            btnStart.Enabled = false;

            //WriteResultsToDB();


            timer1.Stop();

            UpdateStatistics();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1 = null;
            //this.Close();

            //this.Close();
            //// SendKeys.Flush();
            //timer1.Stop();
            //this.Close();
            //if (MessageBox.Show("OK to quit drill?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    timer1.Stop();
            //    if (MessageBox.Show("OK to discard testing results?", "Don't Save Drill Info?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        // MessageBox.Show("Didn't save");
            //        this.Close();
            //    }
            //    else
            //    { MessageBox.Show("Did save"); }
            //}

            abort = true;

            //WriteResultsToDB();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomToolStripMenuItem.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 737)
            {
                pictureBox1.Image = Properties.Resources.ExpandArrow_16x;
                this.Size = new Size(896, 411);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.ContractArrow_16x;
                this.Size = new Size(896, 737);
            }

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Clear statistics
            double totalMilliSeconds = 0;
            double averageMilliSeconds = 0;

            progressBar1.Value = 0;

            // Present a "Test starting in <x> seconds ..." warning screen
            frmCountdown frm1 = new frmCountdown();
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog();

            // Begin drill
            timeDrillStart = DateTime.Now;
            SetEnabledControls(true);

            List<data_sentencedrills_sentence> sentences = LoadDrill();
            NewMethod(ref totalMilliSeconds, ref averageMilliSeconds, sentences);


            //// Ask about quick review
            //// MessageBox.Show("Quick Review?");

            //// Hack
            //if (QuizAverage == 0) QuizAverage = Average;

            //// Determine words < average for retesting
            //// LoadLightningDrill(ref sentences);

            //corrects.Clear();

            //// Run again
            //// totalMilliSeconds = averageMilliSeconds = 0;
            //NewMethod(ref totalMilliSeconds, ref averageMilliSeconds, this.sentences);
        }

        private void txtHumanResponse_TextChanged(object sender, EventArgs e)
        {

            SendKeys.Flush();

            //string testText = rchTestSentence.Text.Trim();
            //string humanText = txtHumanResponse.Text.Trim();

            int CorrectWords = rchTestSentence.Text.Split(' ').Count();
            int HumanWords = txtHumanResponse.Text.Split(' ').Count();

            clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);
            if (class1.GetHighlightedErrors(txtHumanResponse.Text, rchTestSentence.Text, ref richTextBox1))
                MessageBox.Show("Done");







            //int CorrectWords = testText.Split(' ').Count();
            //int HumanWords = humanText.Split(' ').Count();

            //string[] cwords = testText.Split(' ');
            //string[] hwords = humanText.Split(' ');

            //// Hack
            //Boolean isLastCharacterPeriod = false;
            //if (humanText.Length > 1)
            //{
            //    isLastCharacterPeriod = (humanText.Substring(humanText.Length - 1, 1) == ".");
            //}

            ////if ((CorrectWords == HumanWords) && (rchTestSentence.Text != txtHumanResponse.Text)) 
            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.CadetBlue, System.Drawing.Color.Red);
            ////class1.GetHighlightedErrors3(rchTestSentence.Text, txtHumanResponse.Text, ref richTextBox1, re);

            //if (isLastCharacterPeriod && (rchTestSentence.Text != txtHumanResponse.Text))
            //{


            //    richTextBox1.Visible = true;
            //    //return;
            //}

            //lblHuman.Text = humanText;
            //lblComputer.Text = testText;

            //if (testText == humanText)
            //{
            //    //richTextBox1.Visible = false;
            //    //MessageBox.Show("Done!");
            //    //match = true;
            //}


        }

        #endregion

        #region Properties

        public Boolean Abort { get; set; }
        public long DrillID { get; set; }
        public string DrillName { get; set; }
        public Boolean DrillRandom { get; set; }
        public Boolean UseStandardDeviationReDrill { get; set; }


        #endregion

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (this.Size.Height == 965)
            {
                pictureBox1.Image = Properties.Resources.ExpandArrow_16x;
                this.Size = new Size(1404, 594);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.ContractArrow_16x;
                this.Size = new Size(1404, 965);
            }
        }

    }
}

