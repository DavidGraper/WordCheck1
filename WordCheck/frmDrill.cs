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
    public partial class frmDrill : Form
    {

        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        private DateTime timeStart;
        private DateTime timeEnd;
        private Boolean match = false;
        private Boolean abort = false;

        private long CurrentWordID;
        private long HumanWordStrokeCount;

        private int ErrorCount0 = 0;

        private int DictionaryWordStrokeCount;

        private string CachedText;

        List<data_wordconfusion> mistakes = new List<data_wordconfusion>();
        List<data_wordcorrect> corrects = new List<data_wordcorrect>();

        string entryBuffer = string.Empty;

        public frmDrill()
        {
            InitializeComponent();

            timer1.Interval = 10;
            timer1.Tick += Timer_Tick;
        }

        #region Private Methods

        private List<data_drill_dictionary> LoadDrill()
        {
            List<data_drill_dictionary> return1 = new List<data_drill_dictionary>();

            try
            {

                //data_application application1 = new data_application();
                var query = from q in dc1.data_drill_dictionaries
                            //where q.data_drill.drillname == "Chapter 19"
                            where q.data_drill.drillname == "500 Most Common Words Used in English"
                            select q;

                foreach (var item in query)
                {
                    return1.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return return1;
        }

        private List<string> LoadSentenceDrill()
        {
            List<string> return1 = new List<string>();

            try
            {

                //data_application application1 = new data_application();
                var query = from q in dc1.data_sentencedrills_sentences
                            where q.data_sentencedrill.drillname == "Chapter 19 - Punctuation"
                            select q.data_sentence.sentence;

                foreach (var item in query)
                {
                    return1.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return return1;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {

            string expectedResponse = lblTestWordOrPhrase.Text.ToLower().Trim();
            string humanResponse = txtHumanResponse.Text.ToLower().Trim();

            //label2.Text = HumanWordStrokeCount.ToString();

            // mistakeBuffer:  
            // StrokePauseCount: 

            if (humanResponse == "")
            {
                entryBuffer = string.Empty;
                HumanWordStrokeCount = 0;
                return;
            }

            // If the human response is a match to the test word
            if (humanResponse == expectedResponse)
            {

                entryBuffer = string.Empty;
                //DictionaryWordStrokeCount = 0;
                HumanWordStrokeCount = 0;
                match = true;

                ErrorCount0 = 0;
                label2.Visible = false;

                return;
            }

            //// If the human response is blank
            //if (humanResponse == "")
            //{
            //    entryBuffer = string.Empty;
            //    DictionaryWordStrokeCount = 0;
            //    HumanWordStrokeCount = 0;
            //    match = false;
            //    return;
            //}

            // If the human response is 1) not a match of the test word; and 2) a new entry from the human
            if ((expectedResponse != humanResponse) && (humanResponse != entryBuffer))
            {

                ErrorCount0++;
                if (ErrorCount0 > 1) label2.Visible = true;


                HumanWordStrokeCount++;

                // If the number of strokes meets or exceeds the strokes expected, this is a istake
                if (HumanWordStrokeCount >= DictionaryWordStrokeCount)
                {

                    // Cache human's 
                    entryBuffer = humanResponse;

                    data_wordconfusion dw1 = new data_wordconfusion();
                    dw1.incorrectdate = DateTime.Now;
                    dw1.incorrectword = humanResponse;
                    dw1.wordid = CurrentWordID;

                    mistakes.Add(dw1);
                }
                else
                {
                    if (humanResponse.Length > 0)
                    {

                        // Cache human's actual entry
                        entryBuffer = humanResponse;
                    }
                    else
                    {
                        entryBuffer = "";
                        HumanWordStrokeCount = 0;
                    }
                }
            }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            frmCountdown frm1 = new frmCountdown();
            frm1.ShowDialog();

            SetEnabledControls(true);

            List<data_drill_dictionary> words = LoadDrill();

            int totalWords = words.Count;
            int completedWords = 0;

            lblTotalWords.Text = string.Format("Total words = {0}", totalWords.ToString());

            timeStart = DateTime.Now;
            txtHumanResponse.Focus();

            timer1.Start();
            foreach (data_drill_dictionary word in words)
            {
                label2.Text = word.data_dictionary.steno;


                lblTestWordOrPhrase.Text = word.data_dictionary.english;
                CurrentWordID = word.data_dictionary.id;

                // Get the number of strokes in the current word
                DictionaryWordStrokeCount = word.data_dictionary.steno.Count(x => x == '/') + 1;
                completedWords += 1;

                timeStart = DateTime.Now;

                while (!match && !abort)
                {
                    SendKeys.Flush();
                }

                if (abort) break;

                txtHumanResponse.Text = "";
                timeEnd = DateTime.Now;
                TimeSpan span1 = timeEnd - timeStart;

                //listBox1.Items.Add(word + " : " + span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString());
                //listBox1.Items.AddRange(new object[] { word,span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString() } );

                //string[] row = {  word, span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString(), mistakes.ToString() } ;
                //ListViewItem item1 = new ListViewItem(row);
                //listView1.Items.Add(item1);

                string time1 = span1.Seconds.ToString("D3") + ":" + span1.Milliseconds.ToString("D3");

                data_wordcorrect correct1 = new data_wordcorrect();
                correct1.date = DateTime.Now;
                correct1.msspeed = (long)span1.TotalMilliseconds;
                correct1.wordid = word.data_dictionary.id;
                corrects.Add(correct1);

                dataGridView1.Rows.Add(word.data_dictionary.english, time1);

                // Test

                match = false;

                UpdateWordCounts(words.Count, completedWords);

            }

            if (abort) this.Close();

            MessageBox.Show("Done!");
            timer1.Stop();
        }

        private void UpdateWordCounts(int TotalWords, int WordsCompleted)
        {
            lblWordsToGo.Text = string.Format("Words completed: {0}, words to go: {1}",
                WordsCompleted.ToString(), (TotalWords - WordsCompleted).ToString());

            // Color changes based on proximity to end of list
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

        private void frmDrill_Load(object sender, EventArgs e)
        {

            lblTotalWords.Text = "";

            //this.Height = 368;
            //this.Width = 896;

            SetEnabledControls(false);
        }

        private void SetEnabledControls(Boolean Visible)
        {
            btnStop.Enabled =
            lblTestWordOrPhrase.Enabled =
            lblTitleHumanResponse.Enabled =
            lblTitleTestWordOrPhrase.Enabled =
            progressBar1.Visible = Visible;
        }

        #region Properties

        public long DrillID { get; set; }
        public Boolean Abort { get; set; }

        #endregion

        private void button2_Click(object sender, EventArgs e)
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


            foreach (data_wordconfusion item in mistakes)
            {
                if (item.incorrectword.Contains("khr-s")) continue;
                if (item.incorrectword == "") continue;

                dc1.pr_AddMistakeRecord(item.wordid, item.incorrectword);
            }

            foreach (data_wordcorrect item in corrects)
            {
                dc1.pr_AddCorrectRecord(item.wordid, item.msspeed, item.date);
            }

            dc1.SubmitChanges();

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
