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

        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        public frmDrillManagement()
        {
            InitializeComponent();
        }

        private void frmDrillManagement_Load(object sender, EventArgs e)
        {
            LoadDrills();
            FormatDataGridView();
            NameDatagridColumns();
        }

        private void FormatDataGridView()
        {
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NameDatagridColumns()
        {
            dataGridView1.Columns["drillname"].HeaderText = "Drill Name";
       }

        private void LoadDrills()
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

                throw;
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

                throw;
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string drillName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();

            RunDrill(id, drillName);
        }

        private void RunDrill(long DrillID, string DrillName)
        {
            try
            {
                frmDrill form1 = new frmDrill();

                form1.DrillID = DrillID;
                form1.DrillName = DrillName;


                form1.ShowDialog(this);

                form1.Dispose();
                //form1.Show();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LoadSentenceDrills();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LoadDrills();
            }
        }

        private void btnRunDrill_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            string drillName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();

            RunDrill(id, drillName);
        }
    }
}
