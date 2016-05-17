namespace WindowsFormsApplication1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnmember = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.CSUFlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.Orange;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(132, 349);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 46);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnmember
            // 
            this.btnmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmember.BackColor = System.Drawing.Color.Orange;
            this.btnmember.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmember.Location = new System.Drawing.Point(328, 349);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(153, 46);
            this.btnmember.TabIndex = 5;
            this.btnmember.Text = "Member Login";
            this.btnmember.UseVisualStyleBackColor = false;
            this.btnmember.Click += new System.EventHandler(this.btnmember_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(298, 160);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Location = new System.Drawing.Point(298, 246);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(138, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.Location = new System.Drawing.Point(298, 204);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(138, 20);
            this.txtemail.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(298, 288);
            this.txtPass.MaxLength = 20;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(138, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lbluser
            // 
            this.lbluser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(166, 246);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(88, 21);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Username:";
            // 
            // lblpass
            // 
            this.lblpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(168, 288);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(88, 21);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password:";
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(166, 204);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(55, 21);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(166, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lblIntro
            // 
            this.lblIntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Blue;
            this.lblIntro.Location = new System.Drawing.Point(164, 102);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(329, 32);
            this.lblIntro.TabIndex = 10;
            this.lblIntro.Text = "New Member Registration";
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbltitle.Location = new System.Drawing.Point(125, 49);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(403, 42);
            this.lbltitle.TabIndex = 11;
            this.lbltitle.Text = "CPSC 362 Study Tool";
            // 
            // CSUFlogo
            // 
            this.CSUFlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CSUFlogo.Image = ((System.Drawing.Image)(resources.GetObject("CSUFlogo.Image")));
            this.CSUFlogo.Location = new System.Drawing.Point(12, 12);
            this.CSUFlogo.Name = "CSUFlogo";
            this.CSUFlogo.Size = new System.Drawing.Size(64, 115);
            this.CSUFlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CSUFlogo.TabIndex = 12;
            this.CSUFlogo.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(646, 430);
            this.Controls.Add(this.CSUFlogo);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnmember);
            this.Controls.Add(this.btnRegister);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.CSUFlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox CSUFlogo;
    }
}