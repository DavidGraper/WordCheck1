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
    public partial class frmLookupSteno : Form
    {
        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        public frmLookupSteno()
        {
            InitializeComponent();
        }

        private void StenoLookup() 
        {
            try
            {
                var query = from q in dc1.pr_LookupWord(txtInput.Text.Trim())
                            select q;

                //if (query.Count() == 0)
                //    lblSteno.Text = "(No entry found)";
                //else
                //{
                    foreach (var item in query)
                        lblSteno.Text = item.steno;

                // In case match can't be found
                if (lblSteno.Text == "Steno")
                    lblSteno.Text = "(No entry found)";
                  
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                StenoLookup();
                lblSteno.Visible = true;
            }
            else if (e.KeyChar == (char)27)
                this.Close();
        }
    }
}
