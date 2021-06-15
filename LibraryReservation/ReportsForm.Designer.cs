
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Reports";
            // 
            // lstRoom
            // 
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.ItemHeight = 20;
            this.lstRoom.Items.AddRange(new object[] {
            "Amber 1",
            "Amber 2"});
            this.lstRoom.Location = new System.Drawing.Point(40, 99);
            this.lstRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(178, 144);
            this.lstRoom.TabIndex = 1;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Location = new System.Drawing.Point(36, 74);
            this.lblSelectRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(114, 20);
            this.lblSelectRoom.TabIndex = 2;
            this.lblSelectRoom.Text = "Select a Room";
            // 
            // lblDTotal
            // 
            this.lblDTotal.AutoSize = true;
            this.lblDTotal.Location = new System.Drawing.Point(37, 263);
            this.lblDTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTotal.Name = "lblDTotal";
            this.lblDTotal.Size = new System.Drawing.Size(143, 20);
            this.lblDTotal.TabIndex = 3;
            this.lblDTotal.Text = "Total reservation: 2";
            // 
            // lblDAvgTime
            // 
            this.lblDAvgTime.AutoSize = true;
            this.lblDAvgTime.Location = new System.Drawing.Point(36, 295);
            this.lblDAvgTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAvgTime.Name = "lblDAvgTime";
            this.lblDAvgTime.Size = new System.Drawing.Size(252, 20);
            this.lblDAvgTime.TabIndex = 4;
            this.lblDAvgTime.Text = "Average Reserved Time: 3.5 hours";
            // 
            // lblMonthlyTitle
            // 
            this.lblMonthlyTitle.AutoSize = true;
            this.lblMonthlyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTitle.Location = new System.Drawing.Point(408, 37);
            this.lblMonthlyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyTitle.Name = "lblMonthlyTitle";
            this.lblMonthlyTitle.Size = new System.Drawing.Size(168, 25);
            this.lblMonthlyTitle.TabIndex = 5;
            this.lblMonthlyTitle.Text = "Monthly Reports";
            // 
            // lblMUsed
            // 
            this.lblMUsed.AutoSize = true;
            this.lblMUsed.Location = new System.Drawing.Point(408, 74);
            this.lblMUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMUsed.Name = "lblMUsed";
            this.lblMUsed.Size = new System.Drawing.Size(201, 20);
            this.lblMUsed.TabIndex = 6;
            this.lblMUsed.Text = "Most Used Room: Amber 2";
            // 
            // lblLUsed
            // 
            this.lblLUsed.AutoSize = true;
            this.lblLUsed.Location = new System.Drawing.Point(408, 111);
            this.lblLUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLUsed.Name = "lblLUsed";
            this.lblLUsed.Size = new System.Drawing.Size(206, 20);
            this.lblLUsed.TabIndex = 7;
            this.lblLUsed.Text = "Least Used Room: Amber 1";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(408, 148);
            this.lblTotalHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(242, 20);
            this.lblTotalHours.TabIndex = 8;
            this.lblTotalHours.Text = "Total Hours Reserved: 200 hours";
            // 
            // lblMAvgHours
            // 
            this.lblMAvgHours.AutoSize = true;
            this.lblMAvgHours.Location = new System.Drawing.Point(408, 185);
            this.lblMAvgHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMAvgHours.Name = "lblMAvgHours";
            this.lblMAvgHours.Size = new System.Drawing.Size(239, 20);
            this.lblMAvgHours.TabIndex = 9;
            this.lblMAvgHours.Text = "Average Reserved Time: 2 hours";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(624, 295);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 351);
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
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReports";
            this.Text = "Library Reservation - Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}