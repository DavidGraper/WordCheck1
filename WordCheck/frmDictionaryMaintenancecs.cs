using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json;

namespace WordCheck
{
    public partial class frmDictionaryMaintenancecs : Form
    {
        DataClasses1DataContext dc1 = new DataClasses1DataContext();

        public frmDictionaryMaintenancecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (StreamReader r = new StreamReader(@"c:\temp\graper7.json"))
            //{
            //    string json = r.ReadToEnd();
            //    //json = "[" + json + "]";
            //    List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            //}

            openFileDialog1.Multiselect = true;
            DialogResult result1 = openFileDialog1.ShowDialog();

            string steno;
            string english;

            foreach (string fileName in openFileDialog1.FileNames)
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    string json = r.ReadToEnd();

                    dynamic array = JsonConvert.DeserializeObject(json);

                    foreach (var item in array)
                    {

                        steno = item.Name;
                        english = item.Value;

                        // Only add words, not directives
                        if (!english.Contains(@"{"))
                            dc1.pr_AddDictionaryEntry(steno, english);
                    }
                }
            }

            MessageBox.Show("Done");
        }
    }

    public class Item
    {
        public string name;
        public string value;
    }
}
