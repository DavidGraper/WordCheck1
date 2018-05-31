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

        clsParseSentenceErrors parseSentenceErrors = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);

        string cachedHumanEntry = string.Empty;

        double StandardDeviation = 0;
        double Average = 0;
        double FirstRunOfDrillAverage = 0;

        #region Initialize

        public frmSentenceDrill()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += Timer_Tick;
        }

        private void frmSentenceDrill_Load(object sender, EventArgs e)
        {
            lblTotalSentences.Text = "";
            this.Text = DrillName;
            DrillRandom = randomToolStripMenuItem.Checked;

            // Initially collapse the "details" section of the page
            pictureBox1.Image = Properties.Resources.ExpandArrow_16x;
            this.Size = new Size(1404, 656);

            EnableQuizControls(false);
        }

        #endregion

        #region Private Methods

        private void EnableQuizControls(Boolean Visible)
        {
            btnStopDrill.Enabled =
            lblTitleTestWordOrPhrase.Enabled =
            lblTitleHumanResponse.Enabled =
            progressBar1.Visible = Visible;
        }

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

                // Randomizing
                if (DrillRandom)
                {
                    Random rand = new Random();
                    return1 = return1.OrderBy(c => rand.Next()).Select(c => c).ToList();
                }

                // Set upper limit of progress bar
                progressBar1.Maximum = return1.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return return1;
        }

        private void RunDrill(ref double totalMilliSeconds, ref double averageMilliSeconds, List<data_sentencedrills_sentence> sentences)
        {
            lblTotalSentences.Text = string.Format("Total sentences = {0}", sentences.Count.ToString());

            // Initialize drill episode
            int completedSentences = 0;
            txtHumanResponse.Focus();
            timer1.Start();

            foreach (data_sentencedrills_sentence sentence in sentences)
            {

                // Update drill sentence richtextbox
                rchTestSentence.Text = sentence.data_sentence.sentence;

                CurrentSentenceID = sentence.id;

                // Wait for human to correctly enter sentence (or click abort)
                timeStart = DateTime.Now;

                while (!match && !abort)
                {
                    SendKeys.Flush();
                }

                if (abort) return;

                // Human has entered proper sentence

                // Clear controls, get timespan required for human to enter proper sentence
                txtHumanResponse.Text = "";
                richTextBox1.Text = "";
                timeEnd = DateTime.Now;
                TimeSpan span1 = timeEnd - timeStart;

                // Convert the timespan into familiar SS:MM format
                string time1 = span1.Seconds.ToString("D3") + ":" + span1.Milliseconds.ToString("D3");

                // Collect the time required for this drill sentence, save it to the list of speeds of the responses to the drilled sentences
                data_sentencecorrect correct1 = new data_sentencecorrect();
                correct1.date = DateTime.Now;
                correct1.msspeed = (long)span1.TotalMilliseconds;
                correct1.sentenceid = sentence.sentenceid;
                corrects.Add(correct1);

                string tempSentenceFragment = sentence.data_sentence.sentence.Substring(0, (sentence.data_sentence.sentence.Length > 20 ? 20 : sentence.data_sentence.sentence.Length));
                dataGridView1.Rows.Add(tempSentenceFragment, time1);

                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                // Update average speed
                totalMilliSeconds += span1.TotalMilliseconds;
                averageMilliSeconds = totalMilliSeconds / completedSentences;
                lblAverageSpeed.Text = string.Format("Average speed = {0} seconds per sentence", Math.Round((averageMilliSeconds / 1000), 2));

                // Clear "match" flag, update controls, and continue (present the next drill sentence to the human)
                match = false;

                UpdateOnScreenSentenceCounts(sentences.Count, completedSentences);
                progressBar1.Value++;
            }

            MessageBox.Show("Drill Complete!");

            // Entirely exit form if abort flag set
            if (abort) this.Close();

            timer1.Stop();
            WriteResultsToDB();
            UpdateOnScreenStatistics();

            btnStopDrill.Enabled = false;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeUsedInDrillLabel();
        }

        private void UpdateOnScreenStatistics()
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

        private void UpdateTimeUsedInDrillLabel()
        {

            // Update drill time used on screen
            TimeSpan drillTime = DateTime.Now - timeDrillStart;
            lblDrillTime.Text = string.Format("Drill Time:  {0} minutes, {1} seconds", drillTime.Minutes, drillTime.Seconds);
        }

        private void WriteResultsToDB()
        {
            foreach (data_sentencecorrect item in corrects)
            {
                dc1.pr_AddCorrectSentenceRecord(DrillID, item.sentenceid, item.msspeed, item.date);
            }

            dc1.SubmitChanges();
        }

        private void UpdateOnScreenSentenceCounts(int TotalSentences, int SentencesCompleted)
        {
            lblSentencesToGo.Text = string.Format("Sentences completed: {0}, sentences to go: {1}",
                SentencesCompleted.ToString(), (TotalSentences - SentencesCompleted).ToString());

            // Color changes based on proximity to end of list
            if ((TotalSentences - SentencesCompleted) == 10)
            {
                lblSentencesToGo.BackColor = SystemColors.ControlText;
                lblSentencesToGo.ForeColor = SystemColors.Control;
            }

            if ((TotalSentences - SentencesCompleted) == 0)
            {
                lblSentencesToGo.BackColor = SystemColors.Control;
                lblSentencesToGo.ForeColor = SystemColors.ControlText;
            }
        }

        #endregion

        #region Handle Controls

        //private void txtHumanResponse_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //string correctSentence = rchTestSentence.Text;
        //    //string humanSentence = txtHumanResponse.Text;

        //    //int CorrectWords = correctSentence.Split(' ').Count();
        //    //int HumanWords = humanSentence.Split(' ').Count();

        //    //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);
        //    //class1.GetHighlightedErrors(correctSentence, humanSentence, ref richTextBox1);
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {

            // Clear statistics
            double totalMilliSeconds = 0;
            double averageMilliSeconds = 0;

            // Give human a 5-second warning
            frmCountdown frm1 = new frmCountdown();
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog();

            // Load drill sentences
            sentences = LoadDrill();

            // Upate controls
            progressBar1.Maximum = sentences.Count;
            EnableQuizControls(true);

            // Start drill
            timeDrillStart = DateTime.Now;
            RunDrill(ref totalMilliSeconds, ref averageMilliSeconds, sentences);
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
            randomToolStripMenuItem.Checked = !randomToolStripMenuItem.Checked;
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
            EnableQuizControls(true);

            List<data_sentencedrills_sentence> sentences = LoadDrill();
            RunDrill(ref totalMilliSeconds, ref averageMilliSeconds, sentences);


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

            if (txtHumanResponse.Text.Contains("???"))
            {
                frmLookupSteno lookup1 = new frmLookupSteno();
                lookup1.ShowDialog();
                txtHumanResponse.Text = "";
                return;
            }

            //int CorrectWords = rchTestSentence.Text.Split(' ').Count();
            //int HumanWords = txtHumanResponse.Text.Split(' ').Count();

            string CorrectText = rchTestSentence.Text.ToLower();
            string HumanText = txtHumanResponse.Text.ToLower();

            //clsParseSentenceErrors class1 = new clsParseSentenceErrors(System.Drawing.Color.Blue, System.Drawing.Color.Red);

            if (parseSentenceErrors.GetHighlightedErrors(HumanText, CorrectText, ref richTextBox1)) match = true;






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

        private void chkInputToggle_CheckedChanged(object sender, EventArgs e)
        {
            rchTestSentence.Visible = chkInputToggle.Checked;
            txtHumanResponse.Visible = !chkInputToggle.Checked;
        }
    }
}

