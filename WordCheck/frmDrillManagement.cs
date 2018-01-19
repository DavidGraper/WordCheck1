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
    public partial class frmDrillManagement : Form
    {

        public enum DrillType
        {
            Words,
            Sentences,
            StenoWords,
            StenoSentences
        }

        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        #region Initialize

        public frmDrillManagement()
        {
            InitializeComponent();
        }

        private void frmDrillManagement_Load(object sender, EventArgs e)
        {
            LoadWordDrills();
            FormatDataGridView();
            NameDatagridColumns();
        }

        #endregion

        #region Private Methods

        private void FormatDataGridView()
        {
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadWordDrills()
        {
            try
            {
                var query = from q in dc1.data_drills
                            orderby q.drillname
                            select q;

                dataGridView1.DataSource = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure on LoadWordDrills : ", ex.Message);
            }
        }

        private void LoadSentenceDrills()
        {
            try
            {
                var query = from q in dc1.data_sentencedrills
                            orderby q.drillname
                            select q;

                dataGridView1.DataSource = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure on LoadSentenceDrills : ", ex.Message);
            }
        }

        private void NameDatagridColumns()
        {
            dataGridView1.Columns["drillname"].HeaderText = "Drill Name";
        }

        private void RunDrill(long DrillID, string DrillName)
        {
            try
            {
                if (CurrentDrillType == DrillType.Words)
                {
                    frmWordDrill form1 = new frmWordDrill();
                    form1.DrillID = DrillID;
                    form1.DrillName = DrillName;
                    form1.ShowDialog(this);
                    form1.Dispose();
                }
                else if (CurrentDrillType == DrillType.Sentences)
                {
                    frmSentenceDrill form1 = new frmSentenceDrill();
                    form1.DrillID = DrillID;
                    form1.DrillName = DrillName;
                    form1.ShowDialog(this);
                    form1.Dispose();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error on RunDrill: ", ex);
            }
        }

        private void ShowErrorMessage(string Description, Exception ExceptionIn)
        {
            string errorText = string.Format("ERROR:  {0} : '{1}'",
                Description, ExceptionIn.Message);

            MessageBox.Show(errorText, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Handle Controls

        private void btnRunDrill_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string drillName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();

            RunDrill(id, drillName);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string drillName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();

            RunDrill(id, drillName);
        }

        private void rdoEnglish2StenoSentences_Checked(object sender, EventArgs e)
        {
            if (rdoEnglish2StenoSentences.Checked)
            {
                CurrentDrillType = DrillType.Sentences;
                LoadSentenceDrills();
            }
        }

        private void rdoEnglish2StenoWords_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEnglish2StenoWords.Checked)
            {
                CurrentDrillType = DrillType.Words;
                LoadWordDrills();
            }
        }

        private void rdoStenoToEnglishWords_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStenoToEnglishWords.Checked)
            {
                CurrentDrillType = DrillType.StenoWords;
                //LoadStenoWordDrills();
            }
        }

        #endregion

        #region Properties

        public DrillType CurrentDrillType { get; set; }

        #endregion

    }

}
