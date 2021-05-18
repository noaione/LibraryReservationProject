
namespace LibraryReservation
{
    partial class Reserve_Room
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
            this.listPlace = new System.Windows.Forms.ListBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.listDuration = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(276, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reserve Room";
            // 
            // listPlace
            // 
            this.listPlace.FormattingEnabled = true;
            this.listPlace.ItemHeight = 20;
            this.listPlace.Items.AddRange(new object[] {
            "Amber 1",
            "Amber 2"});
            this.listPlace.Location = new System.Drawing.Point(43, 177);
            this.listPlace.Name = "listPlace";
            this.listPlace.Size = new System.Drawing.Size(207, 64);
            this.listPlace.TabIndex = 1;
            this.listPlace.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(97, 118);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(92, 32);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Place";
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(283, 322);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(295, 43);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(645, 101);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(131, 32);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(283, 215);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(315, 160);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 32);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Select Your Day";
            // 
            // listDuration
            // 
            this.listDuration.FormattingEnabled = true;
            this.listDuration.ItemHeight = 20;
            this.listDuration.Items.AddRange(new object[] {
            "60 Minutes",
            "120 Minutes",
            "180 Minutes",
            "240 Minutes",
            "300 Minutes",
            "360 Minutes",
            "420 Minutes",
            "480 Minutes"});
            this.listDuration.Location = new System.Drawing.Point(637, 147);
            this.listDuration.Name = "listDuration";
            this.listDuration.Size = new System.Drawing.Size(138, 124);
            this.listDuration.TabIndex = 8;
            // 
            // Reserve_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDuration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.listPlace);
            this.Controls.Add(this.lblTitle);
            this.Name = "Reserve_Room";
            this.Text = "Reserve_Room";
            this.Load += new System.EventHandler(this.Reserve_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox listDuration;
    }
}