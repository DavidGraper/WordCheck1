namespace WordCheck
{
    partial class frmDrillManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdoEnglish2StenoWords = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoEnglish2StenoSentences = new System.Windows.Forms.RadioButton();
            this.rdoStenoToEnglishWords = new System.Windows.Forms.RadioButton();
            this.btnRunDrill = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(564, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Drills";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(452, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Drill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(566, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Drill";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rdoEnglish2StenoWords
            // 
            this.rdoEnglish2StenoWords.AutoSize = true;
            this.rdoEnglish2StenoWords.Checked = true;
            this.rdoEnglish2StenoWords.Location = new System.Drawing.Point(15, 73);
            this.rdoEnglish2StenoWords.Name = "rdoEnglish2StenoWords";
            this.rdoEnglish2StenoWords.Size = new System.Drawing.Size(156, 17);
            this.rdoEnglish2StenoWords.TabIndex = 4;
            this.rdoEnglish2StenoWords.TabStop = true;
            this.rdoEnglish2StenoWords.Text = "English-to-Steno Word Drills";
            this.rdoEnglish2StenoWords.UseVisualStyleBackColor = true;
            this.rdoEnglish2StenoWords.CheckedChanged += new System.EventHandler(this.rdoEnglish2StenoWords_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show Drills:";
            // 
            // rdoEnglish2StenoSentences
            // 
            this.rdoEnglish2StenoSentences.AutoSize = true;
            this.rdoEnglish2StenoSentences.Location = new System.Drawing.Point(15, 96);
            this.rdoEnglish2StenoSentences.Name = "rdoEnglish2StenoSentences";
            this.rdoEnglish2StenoSentences.Size = new System.Drawing.Size(176, 17);
            this.rdoEnglish2StenoSentences.TabIndex = 6;
            this.rdoEnglish2StenoSentences.Text = "English-to-Steno Sentence Drills";
            this.rdoEnglish2StenoSentences.UseVisualStyleBackColor = true;
            this.rdoEnglish2StenoSentences.CheckedChanged += new System.EventHandler(this.rdoEnglish2StenoSentences_Checked);
            // 
            // rdoStenoToEnglishWords
            // 
            this.rdoStenoToEnglishWords.AutoSize = true;
            this.rdoStenoToEnglishWords.Location = new System.Drawing.Point(15, 119);
            this.rdoStenoToEnglishWords.Name = "rdoStenoToEnglishWords";
            this.rdoStenoToEnglishWords.Size = new System.Drawing.Size(156, 17);
            this.rdoStenoToEnglishWords.TabIndex = 7;
            this.rdoStenoToEnglishWords.Text = "Steno-to-English Word Drills";
            this.rdoStenoToEnglishWords.UseVisualStyleBackColor = true;
            this.rdoStenoToEnglishWords.CheckedChanged += new System.EventHandler(this.rdoStenoToEnglishWords_CheckedChanged);
            // 
            // btnRunDrill
            // 
            this.btnRunDrill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunDrill.Location = new System.Drawing.Point(327, 321);
            this.btnRunDrill.Name = "btnRunDrill";
            this.btnRunDrill.Size = new System.Drawing.Size(95, 23);
            this.btnRunDrill.TabIndex = 8;
            this.btnRunDrill.Text = "Run Drill";
            this.btnRunDrill.UseVisualStyleBackColor = true;
            this.btnRunDrill.Click += new System.EventHandler(this.btnRunDrill_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryMaintenanceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dictionaryMaintenanceToolStripMenuItem
            // 
            this.dictionaryMaintenanceToolStripMenuItem.Name = "dictionaryMaintenanceToolStripMenuItem";
            this.dictionaryMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.dictionaryMaintenanceToolStripMenuItem.Text = "Dictionary Maintenance";
            this.dictionaryMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.dictionaryMaintenanceToolStripMenuItem_Click);
            // 
            // frmDrillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 363);
            this.Controls.Add(this.btnRunDrill);
            this.Controls.Add(this.rdoStenoToEnglishWords);
            this.Controls.Add(this.rdoEnglish2StenoSentences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoEnglish2StenoWords);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDrillManagement";
            this.Text = "frmDrillManagement";
            this.Load += new System.EventHandler(this.frmDrillManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoEnglish2StenoWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoEnglish2StenoSentences;
        private System.Windows.Forms.RadioButton rdoStenoToEnglishWords;
        private System.Windows.Forms.Button btnRunDrill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryMaintenanceToolStripMenuItem;
    }
}