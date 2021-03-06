
namespace LibraryReservation
{
    partial class frmReports
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
            this.lblDailyTitle = new System.Windows.Forms.Label();
            this.lstRoom = new System.Windows.Forms.ListBox();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.lblDTotal = new System.Windows.Forms.Label();
            this.lblDAvgTime = new System.Windows.Forms.Label();
            this.lblMonthlyTitle = new System.Windows.Forms.Label();
            this.lblMUsed = new System.Windows.Forms.Label();
            this.lblLUsed = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblMAvgHours = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDTotalHours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDailyTitle
            // 
            this.lblDailyTitle.AutoSize = true;
            this.lblDailyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyTitle.Location = new System.Drawing.Point(24, 14);
            this.lblDailyTitle.Name = "lblDailyTitle";
            this.lblDailyTitle.Size = new System.Drawing.Size(95, 16);
            this.lblDailyTitle.TabIndex = 0;
            this.lblDailyTitle.Text = "Daily Report";
            // 
            // lstRoom
            // 
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.Location = new System.Drawing.Point(27, 54);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(120, 95);
            this.lstRoom.TabIndex = 1;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Location = new System.Drawing.Point(24, 38);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(77, 13);
            this.lblSelectRoom.TabIndex = 2;
            this.lblSelectRoom.Text = "Select a Room";
            // 
            // lblDTotal
            // 
            this.lblDTotal.AutoSize = true;
            this.lblDTotal.Location = new System.Drawing.Point(24, 158);
            this.lblDTotal.Name = "lblDTotal";
            this.lblDTotal.Size = new System.Drawing.Size(138, 13);
            this.lblDTotal.TabIndex = 3;
            this.lblDTotal.Text = "Total reservation: Unknown";
            // 
            // lblDAvgTime
            // 
            this.lblDAvgTime.AutoSize = true;
            this.lblDAvgTime.Location = new System.Drawing.Point(24, 194);
            this.lblDAvgTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAvgTime.Name = "lblDAvgTime";
            this.lblDAvgTime.Size = new System.Drawing.Size(172, 13);
            this.lblDAvgTime.TabIndex = 4;
            this.lblDAvgTime.Text = "Average Reserved Time: 3.5 hours";
            // 
            // lblMonthlyTitle
            // 
            this.lblMonthlyTitle.AutoSize = true;
            this.lblMonthlyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTitle.Location = new System.Drawing.Point(272, 16);
            this.lblMonthlyTitle.Name = "lblMonthlyTitle";
            this.lblMonthlyTitle.Size = new System.Drawing.Size(112, 16);
            this.lblMonthlyTitle.TabIndex = 5;
            this.lblMonthlyTitle.Text = "Monthly Report";
            // 
            // lblMUsed
            // 
            this.lblMUsed.AutoSize = true;
            this.lblMUsed.Location = new System.Drawing.Point(272, 40);
            this.lblMUsed.Name = "lblMUsed";
            this.lblMUsed.Size = new System.Drawing.Size(134, 13);
            this.lblMUsed.TabIndex = 6;
            this.lblMUsed.Text = "Most Used Room: Amber 2";
            // 
            // lblLUsed
            // 
            this.lblLUsed.AutoSize = true;
            this.lblLUsed.Location = new System.Drawing.Point(272, 64);
            this.lblLUsed.Name = "lblLUsed";
            this.lblLUsed.Size = new System.Drawing.Size(137, 13);
            this.lblLUsed.TabIndex = 7;
            this.lblLUsed.Text = "Least Used Room: Amber 1";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(272, 88);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(164, 13);
            this.lblTotalHours.TabIndex = 8;
            this.lblTotalHours.Text = "Total Hours Reserved: 200 hours";
            // 
            // lblMAvgHours
            // 
            this.lblMAvgHours.AutoSize = true;
            this.lblMAvgHours.Location = new System.Drawing.Point(272, 112);
            this.lblMAvgHours.Name = "lblMAvgHours";
            this.lblMAvgHours.Size = new System.Drawing.Size(163, 13);
            this.lblMAvgHours.TabIndex = 9;
            this.lblMAvgHours.Text = "Average Reserved Time: 2 hours";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(392, 184);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDTotalHours
            // 
            this.lblDTotalHours.AutoSize = true;
            this.lblDTotalHours.Location = new System.Drawing.Point(24, 176);
            this.lblDTotalHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTotalHours.Name = "lblDTotalHours";
            this.lblDTotalHours.Size = new System.Drawing.Size(153, 13);
            this.lblDTotalHours.TabIndex = 11;
            this.lblDTotalHours.Text = "Total Reserved Time: 20 hours";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 223);
            this.Controls.Add(this.lblDTotalHours);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMAvgHours);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblLUsed);
            this.Controls.Add(this.lblMUsed);
            this.Controls.Add(this.lblMonthlyTitle);
            this.Controls.Add(this.lblDAvgTime);
            this.Controls.Add(this.lblDTotal);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.lblDailyTitle);
            this.Name = "frmReports";
            this.Text = "Library Reservation - Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.ListBox lstRoom;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Label lblDTotal;
        private System.Windows.Forms.Label lblDAvgTime;
        private System.Windows.Forms.Label lblMonthlyTitle;
        private System.Windows.Forms.Label lblMUsed;
        private System.Windows.Forms.Label lblLUsed;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblMAvgHours;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDTotalHours;
    }
}