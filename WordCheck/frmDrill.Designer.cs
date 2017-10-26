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
            this.lblTestWordOrPhrase = new System.Windows.Forms.Label();
            this.lblTitleTestWordOrPhrase = new System.Windows.Forms.Label();
            this.txtHumanResponse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.lblWordsToGo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitleHumanResponse = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestWordOrPhrase
            // 
            this.lblTestWordOrPhrase.AutoSize = true;
            this.lblTestWordOrPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestWordOrPhrase.Location = new System.Drawing.Point(138, 141);
            this.lblTestWordOrPhrase.Name = "lblTestWordOrPhrase";
            this.lblTestWordOrPhrase.Size = new System.Drawing.Size(204, 25);
            this.lblTestWordOrPhrase.TabIndex = 0;
            this.lblTestWordOrPhrase.Text = "Human Response:";
            // 
            // lblTitleTestWordOrPhrase
            // 
            this.lblTitleTestWordOrPhrase.AutoSize = true;
            this.lblTitleTestWordOrPhrase.Location = new System.Drawing.Point(12, 148);
            this.lblTitleTestWordOrPhrase.Name = "lblTitleTestWordOrPhrase";
            this.lblTitleTestWordOrPhrase.Size = new System.Drawing.Size(117, 13);
            this.lblTitleTestWordOrPhrase.TabIndex = 1;
            this.lblTitleTestWordOrPhrase.Text = "English Word / Phrase:";
            // 
            // txtHumanResponse
            // 
            this.txtHumanResponse.Location = new System.Drawing.Point(143, 172);
            this.txtHumanResponse.Name = "txtHumanResponse";
            this.txtHumanResponse.Size = new System.Drawing.Size(248, 20);
            this.txtHumanResponse.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Drill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.AutoSize = true;
            this.lblTotalWords.Location = new System.Drawing.Point(12, 18);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(59, 13);
            this.lblTotalWords.TabIndex = 4;
            this.lblTotalWords.Text = "101 Words";
            // 
            // lblWordsToGo
            // 
            this.lblWordsToGo.AutoSize = true;
            this.lblWordsToGo.Location = new System.Drawing.Point(12, 39);
            this.lblWordsToGo.Name = "lblWordsToGo";
            this.lblWordsToGo.Size = new System.Drawing.Size(185, 13);
            this.lblWordsToGo.TabIndex = 5;
            this.lblWordsToGo.Text = "0 Words Completed, 101 Words to go";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average Speed:  40 wpm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drill Time:  10m 35s";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(15, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 236);
            this.dataGridView1.TabIndex = 8;
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
            // lblTitleHumanResponse
            // 
            this.lblTitleHumanResponse.AutoSize = true;
            this.lblTitleHumanResponse.Location = new System.Drawing.Point(12, 175);
            this.lblTitleHumanResponse.Name = "lblTitleHumanResponse";
            this.lblTitleHumanResponse.Size = new System.Drawing.Size(95, 13);
            this.lblTitleHumanResponse.TabIndex = 9;
            this.lblTitleHumanResponse.Text = "Human Response:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTitleHumanResponse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWordsToGo);
            this.Controls.Add(this.lblTotalWords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHumanResponse);
            this.Controls.Add(this.lblTitleTestWordOrPhrase);
            this.Controls.Add(this.lblTestWordOrPhrase);
            this.Name = "frmDrill";
            this.Text = "Drill \"CRAH Chapter 19\"";
            this.Load += new System.EventHandler(this.frmDrill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestWordOrPhrase;
        private System.Windows.Forms.Label lblTitleTestWordOrPhrase;
        private System.Windows.Forms.TextBox txtHumanResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label lblWordsToGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblTitleHumanResponse;
        private System.Windows.Forms.Button button2;
    }
}