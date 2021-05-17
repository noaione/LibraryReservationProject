
namespace LibraryReservation
{
    partial class User_Home
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRsrvRoom = new System.Windows.Forms.Button();
            this.btnChgRsrvRoom = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(57, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnRsrvRoom
            // 
            this.btnRsrvRoom.Location = new System.Drawing.Point(64, 150);
            this.btnRsrvRoom.Name = "btnRsrvRoom";
            this.btnRsrvRoom.Size = new System.Drawing.Size(128, 37);
            this.btnRsrvRoom.TabIndex = 1;
            this.btnRsrvRoom.Text = "Reserve Room";
            this.btnRsrvRoom.UseVisualStyleBackColor = true;
            // 
            // btnChgRsrvRoom
            // 
            this.btnChgRsrvRoom.Location = new System.Drawing.Point(64, 213);
            this.btnChgRsrvRoom.Name = "btnChgRsrvRoom";
            this.btnChgRsrvRoom.Size = new System.Drawing.Size(187, 37);
            this.btnChgRsrvRoom.TabIndex = 2;
            this.btnChgRsrvRoom.Text = "Change Reserved Room";
            this.btnChgRsrvRoom.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(64, 284);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(89, 32);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // User_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 416);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChgRsrvRoom);
            this.Controls.Add(this.btnRsrvRoom);
            this.Controls.Add(this.lblTitle);
            this.Name = "User_Home";
            this.Text = "User_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRsrvRoom;
        private System.Windows.Forms.Button btnChgRsrvRoom;
        private System.Windows.Forms.Button btnLogOut;
    }
}