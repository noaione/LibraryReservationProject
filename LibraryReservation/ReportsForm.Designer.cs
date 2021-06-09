
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
            this.label1 = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.lblDTotal = new System.Windows.Forms.Label();
            this.lblDAvgTime = new System.Windows.Forms.Label();
            this.lblMonthlyTitle = new System.Windows.Forms.Label();
            this.lblMUsed = new System.Windows.Forms.Label();
            this.lblLUsed = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblMAvgHours = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Reports";
            // 
            // listRoom
            // 
            this.listRoom.FormattingEnabled = true;
            this.listRoom.Items.AddRange(new object[] {
            "Amber 1",
            "Amber 2"});
            this.listRoom.Location = new System.Drawing.Point(24, 64);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(120, 95);
            this.listRoom.TabIndex = 1;
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Location = new System.Drawing.Point(24, 48);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(77, 13);
            this.lblSelectRoom.TabIndex = 2;
            this.lblSelectRoom.Text = "Select a Room";
            // 
            // lblDTotal
            // 
            this.lblDTotal.AutoSize = true;
            this.lblDTotal.Location = new System.Drawing.Point(24, 168);
            this.lblDTotal.Name = "lblDTotal";
            this.lblDTotal.Size = new System.Drawing.Size(98, 13);
            this.lblDTotal.TabIndex = 3;
            this.lblDTotal.Text = "Total reservation: 2";
            // 
            // lblDAvgTime
            // 
            this.lblDAvgTime.AutoSize = true;
            this.lblDAvgTime.Location = new System.Drawing.Point(24, 184);
            this.lblDAvgTime.Name = "lblDAvgTime";
            this.lblDAvgTime.Size = new System.Drawing.Size(172, 13);
            this.lblDAvgTime.TabIndex = 4;
            this.lblDAvgTime.Text = "Average Reserved Time: 3.5 hours";
            // 
            // lblMonthlyTitle
            // 
            this.lblMonthlyTitle.AutoSize = true;
            this.lblMonthlyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTitle.Location = new System.Drawing.Point(272, 24);
            this.lblMonthlyTitle.Name = "lblMonthlyTitle";
            this.lblMonthlyTitle.Size = new System.Drawing.Size(120, 16);
            this.lblMonthlyTitle.TabIndex = 5;
            this.lblMonthlyTitle.Text = "Monthly Reports";
            // 
            // lblMUsed
            // 
            this.lblMUsed.AutoSize = true;
            this.lblMUsed.Location = new System.Drawing.Point(272, 48);
            this.lblMUsed.Name = "lblMUsed";
            this.lblMUsed.Size = new System.Drawing.Size(134, 13);
            this.lblMUsed.TabIndex = 6;
            this.lblMUsed.Text = "Most Used Room: Amber 2";
            // 
            // lblLUsed
            // 
            this.lblLUsed.AutoSize = true;
            this.lblLUsed.Location = new System.Drawing.Point(272, 72);
            this.lblLUsed.Name = "lblLUsed";
            this.lblLUsed.Size = new System.Drawing.Size(137, 13);
            this.lblLUsed.TabIndex = 7;
            this.lblLUsed.Text = "Least Used Room: Amber 1";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(272, 96);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(164, 13);
            this.lblTotalHours.TabIndex = 8;
            this.lblTotalHours.Text = "Total Hours Reserved: 200 hours";
            // 
            // lblMAvgHours
            // 
            this.lblMAvgHours.AutoSize = true;
            this.lblMAvgHours.Location = new System.Drawing.Point(272, 120);
            this.lblMAvgHours.Name = "lblMAvgHours";
            this.lblMAvgHours.Size = new System.Drawing.Size(163, 13);
            this.lblMAvgHours.TabIndex = 9;
            this.lblMAvgHours.Text = "Average Reserved Time: 2 hours";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(416, 192);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 228);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMAvgHours);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblLUsed);
            this.Controls.Add(this.lblMUsed);
            this.Controls.Add(this.lblMonthlyTitle);
            this.Controls.Add(this.lblDAvgTime);
            this.Controls.Add(this.lblDTotal);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.label1);
            this.Name = "frmReports";
            this.Text = "Library Reservation - Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Label lblDTotal;
        private System.Windows.Forms.Label lblDAvgTime;
        private System.Windows.Forms.Label lblMonthlyTitle;
        private System.Windows.Forms.Label lblMUsed;
        private System.Windows.Forms.Label lblLUsed;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblMAvgHours;
        private System.Windows.Forms.Button btnBack;
    }
}