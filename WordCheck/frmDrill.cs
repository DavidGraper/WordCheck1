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
        Boolean match = false;
        int mistakes = 0;

        public frmDrill()
        {
            InitializeComponent();

            timer1.Interval = 10;
            timer1.Tick += Timer_Tick;
        }

        #region Private Methods

        private List<string> LoadDrill()
        {
            List<string> return1 = new List<string>();

            try
            {

                //data_application application1 = new data_application();
                var query = from q in dc1.data_drill_dictionaries
                            where q.data_drill.drillname == "Chapter 19"
                            select q.data_dictionary.english;

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
            if (lblTestWordOrPhrase.Text.ToLower().Trim() == txtHumanResponse.Text.ToLower().Trim())
            {
                match = true;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> words = LoadDrill();
            List<string> words = LoadSentenceDrill();

            int totalWords = words.Count;
            int completedWords = 0;

            lblTotalWords.Text = string.Format("Total words = {0}", totalWords.ToString());

            timeStart = DateTime.Now;
            txtHumanResponse.Focus();

            timer1.Start();
            foreach (string word in words)
            {
                lblTestWordOrPhrase.Text = word;
                completedWords += 1;

                timeStart = DateTime.Now;

                while (!match)
                {
                    SendKeys.Flush();
                }

                txtHumanResponse.Text = "";
                timeEnd = DateTime.Now;
                TimeSpan span1 = timeEnd - timeStart;

                //listBox1.Items.Add(word + " : " + span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString());
                //listBox1.Items.AddRange(new object[] { word,span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString() } );

                //string[] row = {  word, span1.Seconds.ToString() + ":" + span1.Milliseconds.ToString(), mistakes.ToString() } ;
                //ListViewItem item1 = new ListViewItem(row);
                //listView1.Items.Add(item1);

                string time1 = span1.Seconds.ToString("D3") + ":" + span1.Milliseconds.ToString("D3");

                dataGridView1.Rows.Add(word, time1);

                // Test

                match = false;

                UpdateWordCounts(words.Count, completedWords);

            }

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
        }

        #region Properties

        public long DrillID { get; set; }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            Application.DoEvents();
            this.Close();

            //this.Close();
            //// SendKeys.Flush();
            //timer1.Stop();
            //this.Close();
            //if (MessageBox.Show("OK to quit drill?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    if (MessageBox.Show("OK to discard testing results?", "Don't Save Drill Info?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Didn't save");
            //        this.Close();
            //        //this.Hide();
            //        //return;
            //    }
            //    else
            //    { MessageBox.Show("Did save"); }
            //}

        }
    }
}
