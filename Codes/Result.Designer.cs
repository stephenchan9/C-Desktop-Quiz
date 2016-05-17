namespace WindowsFormsApplication1
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.QuestionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblscore = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.CSUFlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid
            // 
            this.ResultGrid.AllowUserToAddRows = false;
            this.ResultGrid.AllowUserToDeleteRows = false;
            this.ResultGrid.AllowUserToResizeColumns = false;
            this.ResultGrid.AllowUserToResizeRows = false;
            this.ResultGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionC,
            this.AnswerC,
            this.PageC});
            this.ResultGrid.Location = new System.Drawing.Point(151, 73);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            this.ResultGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ResultGrid.Size = new System.Drawing.Size(344, 287);
            this.ResultGrid.TabIndex = 0;
            // 
            // QuestionC
            // 
            this.QuestionC.HeaderText = "Question";
            this.QuestionC.Name = "QuestionC";
            this.QuestionC.ReadOnly = true;
            // 
            // AnswerC
            // 
            this.AnswerC.HeaderText = "Answer";
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.ReadOnly = true;
            // 
            // PageC
            // 
            this.PageC.HeaderText = "Page Number";
            this.PageC.Name = "PageC";
            this.PageC.ReadOnly = true;
            // 
            // lblscore
            // 
            this.lblscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Black;
            this.lblscore.Location = new System.Drawing.Point(241, 382);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(71, 24);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score:";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(347, 382);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 24);
            this.lbltotal.TabIndex = 2;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Location = new System.Drawing.Point(299, 425);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 24);
            this.lblPercent.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(171, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Question";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogoff.BackColor = System.Drawing.Color.Orange;
            this.btnLogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.Location = new System.Drawing.Point(351, 505);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(124, 46);
            this.btnLogoff.TabIndex = 5;
            this.btnLogoff.Text = "Log off";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResult.Location = new System.Drawing.Point(235, 15);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(180, 55);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result ";
            // 
            // lbltime
            // 
            this.lbltime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Red;
            this.lbltime.Location = new System.Drawing.Point(295, 467);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 24);
            this.lbltime.TabIndex = 7;
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
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(646, 553);
            this.Controls.Add(this.CSUFlogo);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.ResultGrid);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageC;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.PictureBox CSUFlogo;

    }
}