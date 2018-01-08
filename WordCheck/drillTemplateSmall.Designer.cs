namespace WordCheck
{
    partial class drillTemplateSmall
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitleTestWordOrPhrase = new System.Windows.Forms.Label();
            this.lblWordsToGo = new System.Windows.Forms.Label();
            this.lblTestWordOrPhrase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHumanResponse = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitleHumanResponse = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drillOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowestToFastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostErrorsToLeastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Word Drill:  \"CRAH Chapter 19\"";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(278, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 35);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "Start Drill";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitleTestWordOrPhrase
            // 
            this.lblTitleTestWordOrPhrase.AutoSize = true;
            this.lblTitleTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTestWordOrPhrase.Location = new System.Drawing.Point(15, 118);
            this.lblTitleTestWordOrPhrase.Name = "lblTitleTestWordOrPhrase";
            this.lblTitleTestWordOrPhrase.Size = new System.Drawing.Size(107, 20);
            this.lblTitleTestWordOrPhrase.TabIndex = 30;
            this.lblTitleTestWordOrPhrase.Text = "English Word:";
            // 
            // lblWordsToGo
            // 
            this.lblWordsToGo.AutoSize = true;
            this.lblWordsToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsToGo.Location = new System.Drawing.Point(18, 62);
            this.lblWordsToGo.Name = "lblWordsToGo";
            this.lblWordsToGo.Size = new System.Drawing.Size(185, 13);
            this.lblWordsToGo.TabIndex = 5;
            this.lblWordsToGo.Text = "0 Words Completed, 101 Words to go";
            // 
            // lblTestWordOrPhrase
            // 
            this.lblTestWordOrPhrase.AutoSize = true;
            this.lblTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestWordOrPhrase.Location = new System.Drawing.Point(344, 118);
            this.lblTestWordOrPhrase.Name = "lblTestWordOrPhrase";
            this.lblTestWordOrPhrase.Size = new System.Drawing.Size(0, 20);
            this.lblTestWordOrPhrase.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average Speed:  40 wpm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalWords);
            this.groupBox1.Controls.Add(this.lblWordsToGo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(437, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 156);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.AutoSize = true;
            this.lblTotalWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWords.Location = new System.Drawing.Point(18, 40);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(59, 13);
            this.lblTotalWords.TabIndex = 4;
            this.lblTotalWords.Text = "101 Words";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drill Time:  10m 35s";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(344, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // txtHumanResponse
            // 
            this.txtHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHumanResponse.Location = new System.Drawing.Point(344, 147);
            this.txtHumanResponse.Name = "txtHumanResponse";
            this.txtHumanResponse.Size = new System.Drawing.Size(514, 26);
            this.txtHumanResponse.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(20, 305);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Size = new System.Drawing.Size(394, 236);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(454, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 35);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop Drill";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTitleHumanResponse
            // 
            this.lblTitleHumanResponse.AutoSize = true;
            this.lblTitleHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHumanResponse.Location = new System.Drawing.Point(15, 149);
            this.lblTitleHumanResponse.Name = "lblTitleHumanResponse";
            this.lblTitleHumanResponse.Size = new System.Drawing.Size(189, 20);
            this.lblTitleHumanResponse.TabIndex = 34;
            this.lblTitleHumanResponse.Text = "Human Steno Response:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeOptionsToolStripMenuItem,
            this.drillOptionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // sizeOptionsToolStripMenuItem
            // 
            this.sizeOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.extraLargeToolStripMenuItem});
            this.sizeOptionsToolStripMenuItem.Name = "sizeOptionsToolStripMenuItem";
            this.sizeOptionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sizeOptionsToolStripMenuItem.Text = "Size Options";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // extraLargeToolStripMenuItem
            // 
            this.extraLargeToolStripMenuItem.Name = "extraLargeToolStripMenuItem";
            this.extraLargeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.extraLargeToolStripMenuItem.Text = "Extra Large";
            // 
            // drillOptionsToolStripMenuItem
            // 
            this.drillOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem,
            this.alphabeticalToolStripMenuItem,
            this.slowestToFastestToolStripMenuItem,
            this.mostErrorsToLeastToolStripMenuItem});
            this.drillOptionsToolStripMenuItem.Name = "drillOptionsToolStripMenuItem";
            this.drillOptionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.drillOptionsToolStripMenuItem.Text = "Drill Options";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // alphabeticalToolStripMenuItem
            // 
            this.alphabeticalToolStripMenuItem.Name = "alphabeticalToolStripMenuItem";
            this.alphabeticalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.alphabeticalToolStripMenuItem.Text = "Alphabetical";
            // 
            // slowestToFastestToolStripMenuItem
            // 
            this.slowestToFastestToolStripMenuItem.Name = "slowestToFastestToolStripMenuItem";
            this.slowestToFastestToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.slowestToFastestToolStripMenuItem.Text = "Slowest to Fastest";
            // 
            // mostErrorsToLeastToolStripMenuItem
            // 
            this.mostErrorsToLeastToolStripMenuItem.Name = "mostErrorsToLeastToolStripMenuItem";
            this.mostErrorsToLeastToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mostErrorsToLeastToolStripMenuItem.Text = "Most Errors to Least";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 82);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(839, 23);
            this.progressBar1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordCheck.Properties.Resources.ContractArrow_16x;
            this.pictureBox1.Location = new System.Drawing.Point(833, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(472, 182);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 25);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // drillTemplateSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitleTestWordOrPhrase);
            this.Controls.Add(this.lblTestWordOrPhrase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHumanResponse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTitleHumanResponse);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Name = "drillTemplateSmall";
            this.Text = "drillTemplateSmall";
            this.Load += new System.EventHandler(this.drillTemplateSmall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitleTestWordOrPhrase;
        private System.Windows.Forms.Label lblWordsToGo;
        private System.Windows.Forms.Label lblTestWordOrPhrase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtHumanResponse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitleHumanResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drillOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowestToFastestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostErrorsToLeastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}