namespace WordCheck
{
    partial class frmSentenceDrill
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drillOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowestToFastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostErrorsToLeastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStandardDeviation = new System.Windows.Forms.Label();
            this.lblTotalSentences = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.lblDrillTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitleHumanResponse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHumanResponse = new System.Windows.Forms.TextBox();
            this.lblTitleTestWordOrPhrase = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRetestingWords = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblHuman = new System.Windows.Forms.Label();
            this.rchTestSentence = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1233, 23);
            this.progressBar1.TabIndex = 53;
            // 
            // extraLargeToolStripMenuItem
            // 
            this.extraLargeToolStripMenuItem.Name = "extraLargeToolStripMenuItem";
            this.extraLargeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.extraLargeToolStripMenuItem.Text = "Extra Large";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.normalToolStripMenuItem.Text = "Normal";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeOptionsToolStripMenuItem,
            this.drillOptionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStandardDeviation);
            this.groupBox2.Controls.Add(this.lblTotalSentences);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAverageSpeed);
            this.groupBox2.Controls.Add(this.lblDrillTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(732, 666);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 236);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // lblStandardDeviation
            // 
            this.lblStandardDeviation.AutoSize = true;
            this.lblStandardDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardDeviation.Location = new System.Drawing.Point(18, 132);
            this.lblStandardDeviation.Name = "lblStandardDeviation";
            this.lblStandardDeviation.Size = new System.Drawing.Size(101, 13);
            this.lblStandardDeviation.TabIndex = 9;
            this.lblStandardDeviation.Text = "Standard Deviation:";
            // 
            // lblTotalSentences
            // 
            this.lblTotalSentences.AutoSize = true;
            this.lblTotalSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSentences.Location = new System.Drawing.Point(18, 40);
            this.lblTotalSentences.Name = "lblTotalSentences";
            this.lblTotalSentences.Size = new System.Drawing.Size(59, 13);
            this.lblTotalSentences.TabIndex = 4;
            this.lblTotalSentences.Text = "101 Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0 Words Completed, 101 Words to go";
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSpeed.Location = new System.Drawing.Point(18, 112);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(150, 13);
            this.lblAverageSpeed.TabIndex = 6;
            this.lblAverageSpeed.Text = "Average Speed (in seconds):  ";
            // 
            // lblDrillTime
            // 
            this.lblDrillTime.AutoSize = true;
            this.lblDrillTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrillTime.Location = new System.Drawing.Point(18, 84);
            this.lblDrillTime.Name = "lblDrillTime";
            this.lblDrillTime.Size = new System.Drawing.Size(87, 13);
            this.lblDrillTime.TabIndex = 7;
            this.lblDrillTime.Text = "Drill Time:  0m 0s";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(742, 486);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(142, 55);
            this.btnStop.TabIndex = 51;
            this.btnStop.Text = "Stop Drill";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTitleHumanResponse
            // 
            this.lblTitleHumanResponse.AutoSize = true;
            this.lblTitleHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHumanResponse.Location = new System.Drawing.Point(20, 303);
            this.lblTitleHumanResponse.Name = "lblTitleHumanResponse";
            this.lblTitleHumanResponse.Size = new System.Drawing.Size(158, 58);
            this.lblTitleHumanResponse.TabIndex = 50;
            this.lblTitleHumanResponse.Text = "Human Steno\r\n Response:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordCheck.Properties.Resources.ExpandArrow_16x;
            this.pictureBox1.Location = new System.Drawing.Point(1360, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Title";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(566, 486);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 55);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Start Drill";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtHumanResponse
            // 
            this.txtHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHumanResponse.Location = new System.Drawing.Point(233, 156);
            this.txtHumanResponse.Multiline = true;
            this.txtHumanResponse.Name = "txtHumanResponse";
            this.txtHumanResponse.Size = new System.Drawing.Size(1035, 130);
            this.txtHumanResponse.TabIndex = 47;
            this.txtHumanResponse.TextChanged += new System.EventHandler(this.txtHumanResponse_TextChanged);
            this.txtHumanResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHumanResponse_KeyDown);
            // 
            // lblTitleTestWordOrPhrase
            // 
            this.lblTitleTestWordOrPhrase.AutoSize = true;
            this.lblTitleTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTestWordOrPhrase.Location = new System.Drawing.Point(20, 176);
            this.lblTitleTestWordOrPhrase.Name = "lblTitleTestWordOrPhrase";
            this.lblTitleTestWordOrPhrase.Size = new System.Drawing.Size(207, 29);
            this.lblTitleTestWordOrPhrase.TabIndex = 46;
            this.lblTitleTestWordOrPhrase.Text = "English Sentence:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Statistics for this Drill:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(314, 666);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 236);
            this.dataGridView1.TabIndex = 49;
            // 
            // lblRetestingWords
            // 
            this.lblRetestingWords.AutoSize = true;
            this.lblRetestingWords.Location = new System.Drawing.Point(22, 418);
            this.lblRetestingWords.Name = "lblRetestingWords";
            this.lblRetestingWords.Size = new System.Drawing.Size(93, 13);
            this.lblRetestingWords.TabIndex = 60;
            this.lblRetestingWords.Text = "lblRetestingWords";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(233, 303);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1035, 145);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(22, 486);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(35, 13);
            this.lblComputer.TabIndex = 62;
            this.lblComputer.Text = "label4";
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Location = new System.Drawing.Point(22, 516);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(35, 13);
            this.lblHuman.TabIndex = 63;
            this.lblHuman.Text = "label7";
            // 
            // rchTestSentence
            // 
            this.rchTestSentence.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rchTestSentence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchTestSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTestSentence.Location = new System.Drawing.Point(233, 156);
            this.rchTestSentence.Name = "rchTestSentence";
            this.rchTestSentence.Size = new System.Drawing.Size(1035, 134);
            this.rchTestSentence.TabIndex = 64;
            this.rchTestSentence.Text = "";
            // 
            // frmSentenceDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rchTestSentence);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblRetestingWords);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTitleHumanResponse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHumanResponse);
            this.Controls.Add(this.lblTitleTestWordOrPhrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSentenceDrill";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.frmSentenceDrill_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drillOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowestToFastestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostErrorsToLeastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitleHumanResponse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtHumanResponse;
        private System.Windows.Forms.Label lblTitleTestWordOrPhrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRetestingWords;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStandardDeviation;
        private System.Windows.Forms.Label lblTotalSentences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.Label lblDrillTime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.RichTextBox rchTestSentence;
    }
}