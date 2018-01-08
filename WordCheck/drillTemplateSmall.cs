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
    public partial class drillTemplateSmall : Form
    {
        public drillTemplateSmall()
        {
            InitializeComponent();
        }

        private void drillTemplateSmall_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            //linkLabel1.Text = "You are accessing a government system, and all activity " +
            //      "will be logged.  If you do not wish to continue, log out now.";

            linkLabel1.Text = "Q.  When Dan and I marry, will you recommend a good photographer to videotape our marriage ceremony?";

            linkLabel1.AutoSize = false;
            //linkLabel1.AutoSize = true;
            //linkLabel1.Size = new Size(365, 50);
            linkLabel1.Size = new Size(500, 150);
            //linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.Links.Clear();
            //linkLabel1.Links.Add(20, 17).Enabled = false;   // "government system"
            linkLabel1.Links.Add(19, 5).Enabled = false;   // "government system"
            //linkLabel1.Links.Add(105, 11).Enabled = false;  // "log out now"
            linkLabel1.LinkColor = linkLabel1.ForeColor;
            linkLabel1.DisabledLinkColor = linkLabel1.ForeColor;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}
