
namespace LibraryReservation
{
    partial class frmLogin
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
            this.txtInUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtInPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegisterClick = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInUsername
            // 
            this.txtInUsername.Location = new System.Drawing.Point(32, 72);
            this.txtInUsername.Name = "txtInUsername";
            this.txtInUsername.Size = new System.Drawing.Size(155, 20);
            this.txtInUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtInPassword
            // 
            this.txtInPassword.Location = new System.Drawing.Point(32, 120);
            this.txtInPassword.Name = "txtInPassword";
            this.txtInPassword.PasswordChar = '*';
            this.txtInPassword.Size = new System.Drawing.Size(155, 20);
            this.txtInPassword.TabIndex = 4;
            this.txtInPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(32, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegisterClick
            // 
            this.lblRegisterClick.AutoSize = true;
            this.lblRegisterClick.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegisterClick.Location = new System.Drawing.Point(152, 192);
            this.lblRegisterClick.Name = "lblRegisterClick";
            this.lblRegisterClick.Size = new System.Drawing.Size(46, 13);
            this.lblRegisterClick.TabIndex = 7;
            this.lblRegisterClick.Text = "Register";
            this.lblRegisterClick.Click += new System.EventHandler(this.lblRegisterClick_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(32, 16);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(70, 25);
            this.lblProject.TabIndex = 8;
            this.lblProject.Text = "Login";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(32, 192);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(122, 13);
            this.lblRegister.TabIndex = 9;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 338);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblRegisterClick);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtInPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtInUsername);
            this.Name = "frmLogin";
            this.Text = "Library Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtInPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegisterClick;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblRegister;
    }
}

