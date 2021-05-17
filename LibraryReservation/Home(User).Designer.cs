
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
<<<<<<< HEAD
            this.lblTitle.Location = new System.Drawing.Point(64, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 52);
=======
            this.lblTitle.Location = new System.Drawing.Point(43, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 36);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnRsrvRoom
            // 
<<<<<<< HEAD
            this.btnRsrvRoom.Location = new System.Drawing.Point(72, 188);
            this.btnRsrvRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRsrvRoom.Name = "btnRsrvRoom";
            this.btnRsrvRoom.Size = new System.Drawing.Size(144, 46);
=======
            this.btnRsrvRoom.Location = new System.Drawing.Point(48, 122);
            this.btnRsrvRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRsrvRoom.Name = "btnRsrvRoom";
            this.btnRsrvRoom.Size = new System.Drawing.Size(96, 30);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.btnRsrvRoom.TabIndex = 1;
            this.btnRsrvRoom.Text = "Reserve Room";
            this.btnRsrvRoom.UseVisualStyleBackColor = true;
            this.btnRsrvRoom.Click += new System.EventHandler(this.btnRsrvRoom_Click);
            // 
            // btnChgRsrvRoom
            // 
<<<<<<< HEAD
            this.btnChgRsrvRoom.Location = new System.Drawing.Point(72, 266);
            this.btnChgRsrvRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChgRsrvRoom.Name = "btnChgRsrvRoom";
            this.btnChgRsrvRoom.Size = new System.Drawing.Size(210, 46);
=======
            this.btnChgRsrvRoom.Location = new System.Drawing.Point(48, 173);
            this.btnChgRsrvRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChgRsrvRoom.Name = "btnChgRsrvRoom";
            this.btnChgRsrvRoom.Size = new System.Drawing.Size(140, 30);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.btnChgRsrvRoom.TabIndex = 2;
            this.btnChgRsrvRoom.Text = "Change Reserved Room";
            this.btnChgRsrvRoom.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
<<<<<<< HEAD
            this.btnLogOut.Location = new System.Drawing.Point(72, 355);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 40);
=======
            this.btnLogOut.Location = new System.Drawing.Point(48, 231);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(67, 26);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // User_Home
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 520);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 338);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChgRsrvRoom);
            this.Controls.Add(this.btnRsrvRoom);
            this.Controls.Add(this.lblTitle);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
            this.Name = "User_Home";
            this.Text = "Library Reservation";
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