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
    public partial class frmWordDrill : Form
    {
        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        private DateTime timeStart;
        private DateTime timeEnd;
        private DateTime timeDrillStart;

        private Boolean match = false;
        private Boolean abort = false;

        // Internal vars passed between methods
        private long CurrentWordID;
        private long HumanWordStrokeCount;
        private int ErrorCount = 0;
        private int DictionaryWordStrokeCount;

        // Lists of word confusions and time required for correctly entering words
        List<data_wordconfusion> mistakes = new List<data_wordconfusion>();
        List<data_wordcorrect> corrects = new List<data_wordcorrect>();

        // List of words in the selected drill
        List<data_drill_dictionary> words = new List<data_drill_dictionary>();

        string cachedHumanEntry = string.Empty;

        double StandardDeviation = 0;
        double Average = 0;
        double FirstRunOfDrillAverage = 0;

        #region Initialize

        public frmWordDrill()
        {
            InitializeComponent();

            timer1.Interval = 10;
            timer1.Tick += Timer_Tick;
        }

        private void frmDrill_Load(object sender, EventArgs e)
        {

            lblTotalWords.Text = "";
            lblTitle.Text = DrillName;
            DrillRandom = randomToolStripMenuItem.Checked;

            // Initially collapse the "details" section of the page
            pictureBox1.Image = Properties.Resources.ExpandArrow_16x;
            this.Size = new Size(896, 411);

            EnableQuizControls(false);
        }

        #endregion

        #region Private Methods

        private void EnableQuizControls(Boolean Visible)
        {
            btnStopDrill.Enabled =
            lblTestWordOrPhrase.Enabled =
            lblTitleHumanResponse.Enabled =
            lblTitleTestWordOrPhrase.Enabled =
            progressBar1.Visible = Visible;
        }

        private List<data_drill_dictionary> LoadDrill()
        {
            List<data_drill_dictionary> return1 = new List<data_drill_dictionary>();

            try
            {
                var query = from q in dc1.data_drill_dictionaries
                            where q.data_drill.id == DrillID
                            select q;

                foreach (var item in query)
                {
                    return1.Add(item);
                }

                if (DrillRandom)
                {
                    Random rand = new Random();
                    return1 = return1.OrderBy(c => rand.Next()).Select(c => c).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return return1;
        }

        private void LoadLightningDrill(ref List<data_drill_dictionary> Words, Boolean ByStandardDeviation)
        {
            try
            {
                foreach (data_wordcorrect item in corrects)
                {

                    // If user specifies Standard Deviation, "problem" words are those with response times >= 2 SDs;
                    // otherwise "problem" words are all those with response times greater than the average
                    if (ByStandardDeviation)
                        if (item.msspeed < (Average + 2 * (StandardDeviation))) Words.Remove(Words.Find(word => word.dictionaryid == item.wordid));
                        else
                        if ((item.msspeed / 1000.00) < FirstRunOfDrillAverage) Words.Remove(Words.Find(word => word.dictionaryid == item.wordid));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RunDrill(ref double totalMilliSeconds, ref double averageMilliSeconds, List<data_drill_dictionary> words)
        {

            lblTotalWords.Text = string.Format("Total words = {0}", words.Count.ToString());

            // Initialize drill episode
            int completedWords = 0;
            txtHumanResponse.Focus();
            timer1.Start();

            foreach (data_drill_dictionary word in words)
            {

                // Update hidden "correct" steno label for the drill word
                lblSuggestCorrectSteno.Text = word.data_dictionary.steno;
                lblSuggestCorrectSteno.Visible = false;

                // Update drill word label
                lblTestWordOrPhrase.Text = word.data_dictionary.english;
                CurrentWordID = word.data_dictionary.id;

                // Get the number of strokes in the current word
                DictionaryWordStrokeCount = word.data_dictionary.steno.Count(x => x == '/') + 1;
                completedWords += 1;

                // Wait for human to correctly enter proferred word (or abort)
                timeStart = DateTime.Now;

                while (!match && !abort)
                {
                    SendKeys.Flush();
                }

                if (abort) return;

                // Human has entered proper word.  

                // Clear controls, get timespan required for human to make proper entry
                txtHumanResponse.Text = "";
                timeEnd = DateTime.Now;
                TimeSpan span1 = timeEnd - timeStart;

                // Convert the timespan into familiar SS:MM format
                string time1 = span1.Seconds.ToString("D3") + ":" + span1.Milliseconds.ToString("D3");

                // Collect the time required for this drill word, save it to the list of the speeds of the responses to the drilled words
                data_wordcorrect correct1 = new data_wordcorrect();
                correct1.date = DateTime.Now;
                correct1.msspeed = (long)span1.TotalMilliseconds;
                correct1.wordid = word.data_dictionary.id;
                corrects.Add(correct1);

                // Update the response speed to the on-screen datagridview
                dataGridView1.Rows.Add(word.data_dictionary.english, time1);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                // Update the average drill-word speed
                totalMilliSeconds += span1.TotalMilliseconds;
                averageMilliSeconds = totalMilliSeconds / completedWords;
                lblAverageSpeed.Text = string.Format("Average speed = {0} seconds per word", Math.Round((averageMilliSeconds / 1000), 2));

                // Clear "match" flag, update controls, and continue (present the next drill word to the human)
                match = false;

                UpdateOnScreenWordCounts(words.Count, completedWords);
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

        private void ShowStenoHint(Boolean ShowHint)
        {

            // Show steno for word (which was already loaded earlier)
            lblSuggestCorrectSteno.Visible = ShowHint;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeUsedInDrillLabel();

            // Compare human response to what the drill is expecting
            string expectedResponse = lblTestWordOrPhrase.Text.ToLower().Trim();
            string humanResponse = txtHumanResponse.Text.ToLower().Trim();

            // If no response from human
            if (humanResponse == "")
            {
                match = false;

                cachedHumanEntry = string.Empty;
                HumanWordStrokeCount = 0;

                return;
            }

            // If human response matches test word
            if (humanResponse == expectedResponse)
            {
                match = true;

                // Clear "attempt" info
                cachedHumanEntry = string.Empty;
                HumanWordStrokeCount = 0;
                ErrorCount = 0;
                ShowStenoHint(false);

                return;
            }

            // If the human response is 1) not a match of the test word; and 2) a new entry from the human
            if ((expectedResponse != humanResponse) && (humanResponse != cachedHumanEntry))
            {

                // If human has tried more than once to enter the word, show the correct steno
                ErrorCount++;
                if (ErrorCount > 1) ShowStenoHint(true);

                HumanWordStrokeCount++;

                // If the number of strokes the human has entered meets or exceeds the strokes expected, 
                // the human is not in this midst of entering a word.  This is a mistake, and is logged.
                if (HumanWordStrokeCount >= DictionaryWordStrokeCount)
                {

                    // Cache the human's response
                    cachedHumanEntry = humanResponse;

                    // Add the human's error to list of mistakes
                    data_wordconfusion dw1 = new data_wordconfusion();
                    dw1.incorrectdate = DateTime.Now;
                    dw1.incorrectword = humanResponse;
                    dw1.wordid = CurrentWordID;

                    mistakes.Add(dw1);
                }
                else // If the human's stroke count is less than what's expected
                {
                    if (humanResponse.Length > 0) // If the human's entered anything, just cache it
                    {
                        cachedHumanEntry = humanResponse;
                    }
                    else  // Otherwise, just clear the cache
                    {
                        cachedHumanEntry = "";
                        HumanWordStrokeCount = 0;
                    }
                }
            }
        }

        private void UpdateOnScreenStatistics()
        {
            Average = getAverage(corrects) / 1000.00;
            string averageSpeedInSeconds = Average.ToString();
            string varianceInSeconds = (getVariance(corrects) / 1000.00).ToString();
            StandardDeviation = getStandardDeviation(getVariance(corrects)) / 1000.00;

            string stdevInSeconds = StandardDeviation.ToString();

            lblAverageSpeed.Text = string.Format("Average speed (in seconds):  {0}", averageSpeedInSeconds);
            lblStandardDeviation.Text = string.Format("Standard Deviation (in seconds):  {0}", stdevInSeconds);

            // This drill average is done only once after initial completion of drill
            if (FirstRunOfDrillAverage == 0) FirstRunOfDrillAverage = Average;
        }

        private void UpdateOnScreenWordCounts(int TotalWords, int WordsCompleted)
        {
            lblWordsToGo.Text = string.Format("Words completed: {0}, words to go: {1}",
                WordsCompleted.ToString(), (TotalWords - WordsCompleted).ToString());

            // Color changes when last 10 words are reached
            if ((TotalWords - WordsCompleted) == 10)
            {
                lblWordsToGo.BackColor = SystemColors.ControlText;
                lblWordsToGo.ForeColor = SystemColors.Control;
            }

            if ((TotalWords - WordsCompleted) == 0)
            {
                lblWordsToGo.BackColor = SystemColors.Control;
                lblWordsToGo.ForeColor = SystemColors.ControlText;
            }
        }

        private void UpdateTimeUsedInDrillLabel()
        {

            // Update drill time used on screen
            TimeSpan drillTime = DateTime.Now - timeDrillStart;
            lblDrillTime.Text = string.Format("Drill Time:  {0} minutes, {1} seconds", drillTime.Minutes, drillTime.Seconds);
        }

        private void WriteResultsToDB()
        {
            try
            {

                // Log mistakes / human confusions
                foreach (data_wordconfusion item in mistakes)
                {
                    if (item.incorrectword.Contains("khr-s")) continue;
                    if (item.incorrectword == "") continue;

                    dc1.pr_AddMistakeRecord(DrillID, item.wordid, item.incorrectword);
                }

                // Log correct word timing
                foreach (data_wordcorrect item in corrects)
                {
                    dc1.pr_AddCorrectRecord(DrillID, item.wordid, item.msspeed, item.date);
                }

                dc1.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on WriteResultsToDB: " + ex.Message);
            }
        }

        #endregion

        #region Handle Controls

        private void btnStart_Click(object sender, EventArgs e)
        {

            // Clear statistics
            double totalMilliSeconds = 0;
            double averageMilliSeconds = 0;

            // Give human 5-second warning
            frmCountdown frm1 = new frmCountdown();
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog();

            // Load drill words 
            words = LoadDrill();

            // Update controls
            progressBar1.Maximum = words.Count;
            EnableQuizControls(true);

            // Start drill
            timeDrillStart = DateTime.Now;
            RunDrill(ref totalMilliSeconds, ref averageMilliSeconds, words);
        }

        private void btnTestProblemWords_Click(object sender, EventArgs e)
        {

            // Clear statistics
            double totalMilliSeconds = 0;
            double averageMilliSeconds = 0;

            // Clear controls
            dataGridView1.Rows.Clear();
            lblTotalWords.Text =
                lblWordsToGo.Text =
                lblDrillTime.Text =
                lblAverageSpeed.Text =
                lblStandardDeviation.Text = "";
            progressBar1.Value = 0;

            // Give human 5-second warning
            frmCountdown frm1 = new frmCountdown();
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog();

            // Load drill words for another go round
            LoadLightningDrill(ref words, UseStandardDeviationReDrill);
            corrects.Clear();

            // Update controls
            progressBar1.Maximum = words.Count;
            lblRetestingWords.Text = words.Count.ToString();
            EnableQuizControls(true);

            // Hack
            if (FirstRunOfDrillAverage == 0) FirstRunOfDrillAverage = Average;

            // Start Drill
            timeDrillStart = DateTime.Now;
            RunDrill(ref totalMilliSeconds, ref averageMilliSeconds, words);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (MessageBox.Show("Save results to database?", "Save drill statistics?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                WriteResultsToDB();

            // Set global abort flag
            abort = true;
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomToolStripMenuItem.Checked =
                DrillRandom =
                !randomToolStripMenuItem.Checked;
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

        #endregion

        #region Statistical 

        private long getAverage(List<data_wordcorrect> correctsIn)
        {
            long sum = 0;

            if (correctsIn.Count > 1)
            {

                // Sum up the values
                foreach (data_wordcorrect wdc in correctsIn)
                {
                    sum += wdc.msspeed;
                }

                // Divide by the number of values
                return sum / (long)correctsIn.Count;
            }
            else { return correctsIn[0].msspeed; }
        }

        private double getStandardDeviation(double variance)
        {
            return Math.Sqrt(variance);
        }

        private double getVariance(List<data_wordcorrect> correctsIn)
        {
            if (correctsIn.Count > 1)
            {

                // Get the average of the values
                double avg = getAverage(correctsIn);

                // Now figure out how far each point is from the mean
                // So we subtract from the number the average
                // Then raise it to the power of 2
                double sumOfSquares = 0.0;

                foreach (data_wordcorrect dwc in correctsIn)
                {
                    sumOfSquares += Math.Pow((dwc.msspeed - avg), 2.0);
                }

                // Finally divide it by n - 1 (for standard deviation variance)
                // Or use length without subtracting one ( for population standard deviation variance)
                //return sumOfSquares / (double)(correctsIn.Count - 1);
                return sumOfSquares / (double)(correctsIn.Count);
            }
            else { return 0.0; }
        }

        #endregion

        #region Properties

        public Boolean Abort { get; set; }
        public long DrillID { get; set; }
        public string DrillName { get; set; }
        public Boolean DrillRandom { get; set; }
        public Boolean UseStandardDeviationReDrill { get; set; }

        #endregion

    }
}
