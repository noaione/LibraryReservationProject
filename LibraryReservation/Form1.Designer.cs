
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtInUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtInPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegisterClick = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.BtnShowHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowHide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInUsername
            // 
            this.txtInUsername.Location = new System.Drawing.Point(48, 111);
            this.txtInUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInUsername.Name = "txtInUsername";
            this.txtInUsername.Size = new System.Drawing.Size(230, 26);
            this.txtInUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(48, 86);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 160);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtInPassword
            // 
            this.txtInPassword.Location = new System.Drawing.Point(48, 185);
            this.txtInPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInPassword.Name = "txtInPassword";
            this.txtInPassword.PasswordChar = '*';
            this.txtInPassword.Size = new System.Drawing.Size(230, 26);
            this.txtInPassword.TabIndex = 4;
            this.txtInPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(48, 234);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegisterClick
            // 
            this.lblRegisterClick.AutoSize = true;
            this.lblRegisterClick.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegisterClick.Location = new System.Drawing.Point(228, 295);
            this.lblRegisterClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterClick.Name = "lblRegisterClick";
            this.lblRegisterClick.Size = new System.Drawing.Size(69, 20);
            this.lblRegisterClick.TabIndex = 7;
            this.lblRegisterClick.Text = "Register";
            this.lblRegisterClick.Click += new System.EventHandler(this.lblRegisterClick_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(48, 25);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(101, 37);
            this.lblProject.TabIndex = 8;
            this.lblProject.Text = "Login";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(48, 295);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(177, 20);
            this.lblRegister.TabIndex = 9;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // BtnShowHide
            // 
            this.BtnShowHide.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowHide.Image")));
            this.BtnShowHide.Location = new System.Drawing.Point(286, 185);
            this.BtnShowHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnShowHide.Name = "BtnShowHide";
            this.BtnShowHide.Size = new System.Drawing.Size(48, 49);
            this.BtnShowHide.TabIndex = 23;
            this.BtnShowHide.TabStop = false;
            this.BtnShowHide.Click += new System.EventHandler(this.BtnShowHide_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 520);
            this.Controls.Add(this.BtnShowHide);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblRegisterClick);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtInPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtInUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Text = "Library Reservation";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowHide)).EndInit();
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
        private System.Windows.Forms.PictureBox BtnShowHide;
    }
}

