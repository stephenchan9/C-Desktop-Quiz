namespace WindowsFormsApplication1
{
    partial class TotalScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalScore));
            this.TotalGrid = new System.Windows.Forms.DataGridView();
            this.chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.CSUFlogo = new System.Windows.Forms.PictureBox();
            this.lblReview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalGrid
            // 
            this.TotalGrid.AllowUserToAddRows = false;
            this.TotalGrid.AllowUserToDeleteRows = false;
            this.TotalGrid.AllowUserToResizeColumns = false;
            this.TotalGrid.AllowUserToResizeRows = false;
            this.TotalGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TotalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chapter,
            this.Score,
            this.Date});
            this.TotalGrid.Location = new System.Drawing.Point(159, 67);
            this.TotalGrid.Name = "TotalGrid";
            this.TotalGrid.ReadOnly = true;
            this.TotalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TotalGrid.Size = new System.Drawing.Size(304, 285);
            this.TotalGrid.TabIndex = 0;
            // 
            // chapter
            // 
            this.chapter.HeaderText = "Chapter";
            this.chapter.Name = "chapter";
            this.chapter.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.BackColor = System.Drawing.Color.Orange;
            this.btnReturn.Location = new System.Drawing.Point(236, 372);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 46);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CSUFlogo
            // 
            this.CSUFlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CSUFlogo.Image = ((System.Drawing.Image)(resources.GetObject("CSUFlogo.Image")));
            this.CSUFlogo.Location = new System.Drawing.Point(12, 12);
            this.CSUFlogo.Name = "CSUFlogo";
            this.CSUFlogo.Size = new System.Drawing.Size(64, 115);
            this.CSUFlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSUFlogo.TabIndex = 13;
            this.CSUFlogo.TabStop = false;
            // 
            // lblReview
            // 
            this.lblReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblReview.Location = new System.Drawing.Point(205, 9);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(188, 55);
            this.lblReview.TabIndex = 14;
            this.lblReview.Text = "Review";
            // 
            // TotalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(646, 430);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.CSUFlogo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.TotalGrid);
            this.Name = "TotalScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Score";
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TotalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox CSUFlogo;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}