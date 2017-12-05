namespace WordCheck
{
    partial class frmDrill
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mostErrorsToLeastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.lblWordsToGo = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.lblDrillTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHumanResponse = new System.Windows.Forms.TextBox();
            this.lblTitleTestWordOrPhrase = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTestWordOrPhrase = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitleHumanResponse = new System.Windows.Forms.Label();
            this.drillOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowestToFastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Statistics for this Drill:";
            // 
            // mostErrorsToLeastToolStripMenuItem
            // 
            this.mostErrorsToLeastToolStripMenuItem.Name = "mostErrorsToLeastToolStripMenuItem";
            this.mostErrorsToLeastToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mostErrorsToLeastToolStripMenuItem.Text = "Most Errors to Least";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(317, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "label2";
            this.label2.Visible = false;
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
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSpeed.Location = new System.Drawing.Point(18, 85);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(127, 13);
            this.lblAverageSpeed.TabIndex = 6;
            this.lblAverageSpeed.Text = "Average Speed:  40 wpm";
            // 
            // lblDrillTime
            // 
            this.lblDrillTime.AutoSize = true;
            this.lblDrillTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrillTime.Location = new System.Drawing.Point(18, 108);
            this.lblDrillTime.Name = "lblDrillTime";
            this.lblDrillTime.Size = new System.Drawing.Size(87, 13);
            this.lblDrillTime.TabIndex = 7;
            this.lblDrillTime.Text = "Drill Time:  0m 0s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordCheck.Properties.Resources.ExpandArrow_16x;
            this.pictureBox1.Location = new System.Drawing.Point(852, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Title";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(278, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 55);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start Drill";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtHumanResponse
            // 
            this.txtHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHumanResponse.Location = new System.Drawing.Point(317, 193);
            this.txtHumanResponse.Name = "txtHumanResponse";
            this.txtHumanResponse.Size = new System.Drawing.Size(540, 35);
            this.txtHumanResponse.TabIndex = 33;
            // 
            // lblTitleTestWordOrPhrase
            // 
            this.lblTitleTestWordOrPhrase.AutoSize = true;
            this.lblTitleTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTestWordOrPhrase.Location = new System.Drawing.Point(132, 147);
            this.lblTitleTestWordOrPhrase.Name = "lblTitleTestWordOrPhrase";
            this.lblTitleTestWordOrPhrase.Size = new System.Drawing.Size(163, 29);
            this.lblTitleTestWordOrPhrase.TabIndex = 32;
            this.lblTitleTestWordOrPhrase.Text = "English Word:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(20, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 236);
            this.dataGridView1.TabIndex = 35;
            // 
            // alphabeticalToolStripMenuItem
            // 
            this.alphabeticalToolStripMenuItem.Name = "alphabeticalToolStripMenuItem";
            this.alphabeticalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.alphabeticalToolStripMenuItem.Text = "Alphabetical";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // lblTestWordOrPhrase
            // 
            this.lblTestWordOrPhrase.AutoSize = true;
            this.lblTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestWordOrPhrase.Location = new System.Drawing.Point(317, 145);
            this.lblTestWordOrPhrase.Name = "lblTestWordOrPhrase";
            this.lblTestWordOrPhrase.Size = new System.Drawing.Size(169, 29);
            this.lblTestWordOrPhrase.TabIndex = 31;
            this.lblTestWordOrPhrase.Text = "English Word";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalWords);
            this.groupBox1.Controls.Add(this.lblWordsToGo);
            this.groupBox1.Controls.Add(this.lblAverageSpeed);
            this.groupBox1.Controls.Add(this.lblDrillTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(437, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 236);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(454, 305);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(142, 55);
            this.btnStop.TabIndex = 37;
            this.btnStop.Text = "Stop Drill";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTitleHumanResponse
            // 
            this.lblTitleHumanResponse.AutoSize = true;
            this.lblTitleHumanResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHumanResponse.Location = new System.Drawing.Point(15, 196);
            this.lblTitleHumanResponse.Name = "lblTitleHumanResponse";
            this.lblTitleHumanResponse.Size = new System.Drawing.Size(280, 29);
            this.lblTitleHumanResponse.TabIndex = 36;
            this.lblTitleHumanResponse.Text = "Human Steno Response:";
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
            // slowestToFastestToolStripMenuItem
            // 
            this.slowestToFastestToolStripMenuItem.Name = "slowestToFastestToolStripMenuItem";
            this.slowestToFastestToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.slowestToFastestToolStripMenuItem.Text = "Slowest to Fastest";
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
            this.menuStrip1.TabIndex = 41;
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(839, 23);
            this.progressBar1.TabIndex = 39;
            // 
            // frmDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHumanResponse);
            this.Controls.Add(this.lblTitleTestWordOrPhrase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTestWordOrPhrase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTitleHumanResponse);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrill";
            this.Text = "Drill \"CRAH Chapter 19\"";
            this.Load += new System.EventHandler(this.frmDrill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mostErrorsToLeastToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label lblWordsToGo;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.Label lblDrillTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtHumanResponse;
        private System.Windows.Forms.Label lblTitleTestWordOrPhrase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.Label lblTestWordOrPhrase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitleHumanResponse;
        private System.Windows.Forms.ToolStripMenuItem drillOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowestToFastestToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}