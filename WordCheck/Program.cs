using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCheck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDrill());
            //Application.Run(new frmDrillManagement());
            //Application.Run(new drillTemplateSmall());
            //Application.Run(new frmCountdown());
            Application.Run(new frmTest0());
            //Application.Run(new frmSentenceDrill());
        }
    }
}
