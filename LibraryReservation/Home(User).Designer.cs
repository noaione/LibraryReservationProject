
namespace LibraryReservation
{
    partial class frmUserHome
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
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(158, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnRsrvRoom
            // 
            this.btnRsrvRoom.Location = new System.Drawing.Point(114, 228);
            this.btnRsrvRoom.Name = "btnRsrvRoom";
            this.btnRsrvRoom.Size = new System.Drawing.Size(144, 46);
            this.btnRsrvRoom.TabIndex = 1;
            this.btnRsrvRoom.Text = "Reserve Room";
            this.btnRsrvRoom.UseVisualStyleBackColor = true;
            this.btnRsrvRoom.Click += new System.EventHandler(this.btnRsrvRoom_Click);
            // 
            // btnChgRsrvRoom
            // 
            this.btnChgRsrvRoom.Location = new System.Drawing.Point(114, 306);
            this.btnChgRsrvRoom.Name = "btnChgRsrvRoom";
            this.btnChgRsrvRoom.Size = new System.Drawing.Size(210, 46);
            this.btnChgRsrvRoom.TabIndex = 2;
            this.btnChgRsrvRoom.Text = "Change Reserved Room";
            this.btnChgRsrvRoom.UseVisualStyleBackColor = true;
            this.btnChgRsrvRoom.Click += new System.EventHandler(this.btnChgRsrvRoom_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(114, 395);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(2, 27);
            this.lblName.TabIndex = 4;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // frmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 520);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChgRsrvRoom);
            this.Controls.Add(this.btnRsrvRoom);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmUserHome";
            this.Text = "Library Reservation";
            this.Load += new System.EventHandler(this.frmUserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRsrvRoom;
        private System.Windows.Forms.Button btnChgRsrvRoom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblName;
    }
}