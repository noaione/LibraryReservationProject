
namespace LibraryReservation
{
    partial class frmLibrarianHome
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(74, 340);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 40);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(74, 260);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 37);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReq
            // 
            this.btnReq.Location = new System.Drawing.Point(74, 175);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(141, 37);
            this.btnReq.TabIndex = 6;
            this.btnReq.Text = "See Request";
            this.btnReq.UseVisualStyleBackColor = true;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // frmLibrarianHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 520);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmLibrarianHome";
            this.Text = "Library Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReq;
    }
}