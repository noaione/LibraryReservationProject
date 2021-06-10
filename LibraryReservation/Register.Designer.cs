
namespace LibraryReservation
{
    partial class frmRegister
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
            this.lblProject = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtInPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtInUsername = new System.Windows.Forms.TextBox();
            this.lblLoginClick = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.txtInFullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(32, 16);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(100, 25);
            this.lblProject.TabIndex = 15;
            this.lblProject.Text = "Register";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Location = new System.Drawing.Point(32, 232);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(133, 13);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Already have an Account?";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(32, 192);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtInPassword
            // 
            this.txtInPassword.Location = new System.Drawing.Point(32, 160);
            this.txtInPassword.Name = "txtInPassword";
            this.txtInPassword.PasswordChar = '*';
            this.txtInPassword.Size = new System.Drawing.Size(155, 20);
            this.txtInPassword.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 104);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // txtInUsername
            // 
            this.txtInUsername.Location = new System.Drawing.Point(32, 120);
            this.txtInUsername.Name = "txtInUsername";
            this.txtInUsername.Size = new System.Drawing.Size(155, 20);
            this.txtInUsername.TabIndex = 9;
            // 
            // lblLoginClick
            // 
            this.lblLoginClick.AutoSize = true;
            this.lblLoginClick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLoginClick.Location = new System.Drawing.Point(168, 232);
            this.lblLoginClick.Name = "lblLoginClick";
            this.lblLoginClick.Size = new System.Drawing.Size(42, 13);
            this.lblLoginClick.TabIndex = 16;
            this.lblLoginClick.Text = "Sign in!";
            this.lblLoginClick.Click += new System.EventHandler(this.lblLoginClick_Click);
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(32, 56);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(54, 13);
            this.lblRealName.TabIndex = 18;
            this.lblRealName.Text = "Full Name";
            // 
            // txtInFullName
            // 
            this.txtInFullName.Location = new System.Drawing.Point(32, 72);
            this.txtInFullName.Name = "txtInFullName";
            this.txtInFullName.Size = new System.Drawing.Size(155, 20);
            this.txtInFullName.TabIndex = 17;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 290);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.txtInFullName);
            this.Controls.Add(this.lblLoginClick);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtInPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtInUsername);
            this.Name = "frmRegister";
            this.Text = "Library Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtInPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtInUsername;
        private System.Windows.Forms.Label lblLoginClick;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.TextBox txtInFullName;
    }
}