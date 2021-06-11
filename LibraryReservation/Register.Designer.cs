
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(48, 25);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(142, 37);
            this.lblProject.TabIndex = 15;
            this.lblProject.Text = "Register";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Location = new System.Drawing.Point(48, 379);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(194, 20);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Already have an Account?";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(52, 325);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(52, 200);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtInPassword
            // 
            this.txtInPassword.Location = new System.Drawing.Point(52, 224);
            this.txtInPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInPassword.Name = "txtInPassword";
            this.txtInPassword.PasswordChar = '*';
            this.txtInPassword.Size = new System.Drawing.Size(230, 26);
            this.txtInPassword.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(52, 138);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // txtInUsername
            // 
            this.txtInUsername.Location = new System.Drawing.Point(52, 163);
            this.txtInUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInUsername.Name = "txtInUsername";
            this.txtInUsername.Size = new System.Drawing.Size(230, 26);
            this.txtInUsername.TabIndex = 9;
            this.txtInUsername.TextChanged += new System.EventHandler(this.txtInUsername_TextChanged);
            this.txtInUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInUsername_KeyPress);
            // 
            // lblLoginClick
            // 
            this.lblLoginClick.AutoSize = true;
            this.lblLoginClick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLoginClick.Location = new System.Drawing.Point(252, 379);
            this.lblLoginClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginClick.Name = "lblLoginClick";
            this.lblLoginClick.Size = new System.Drawing.Size(61, 20);
            this.lblLoginClick.TabIndex = 16;
            this.lblLoginClick.Text = "Sign in!";
            this.lblLoginClick.Click += new System.EventHandler(this.lblLoginClick_Click);
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(52, 64);
            this.lblRealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(80, 20);
            this.lblRealName.TabIndex = 18;
            this.lblRealName.Text = "Full Name";
            // 
            // txtInFullName
            // 
            this.txtInFullName.Location = new System.Drawing.Point(52, 89);
            this.txtInFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInFullName.Name = "txtInFullName";
            this.txtInFullName.Size = new System.Drawing.Size(230, 26);
            this.txtInFullName.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(52, 289);
            this.txtConPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.Size = new System.Drawing.Size(230, 26);
            this.txtConPassword.TabIndex = 21;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 446);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.Text = "Library Reservation";
            this.Load += new System.EventHandler(this.frmRegister_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConPassword;
    }
}