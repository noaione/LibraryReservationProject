
namespace LibraryReservation
{
    partial class frmReserveRoom
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
            this.lstPlace = new System.Windows.Forms.ListBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lstDuration = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // lstPlace
            // 
            this.lstPlace.FormattingEnabled = true;
            this.lstPlace.ItemHeight = 20;
            this.lstPlace.Location = new System.Drawing.Point(44, 177);
            this.lstPlace.Name = "lstPlace";
            this.lstPlace.Size = new System.Drawing.Size(206, 84);
            this.lstPlace.TabIndex = 1;
            this.lstPlace.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(98, 118);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(92, 32);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Place";
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(293, 300);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(303, 62);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(645, 102);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(131, 32);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(284, 215);
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
            // lstDuration
            // 
            this.lstDuration.FormattingEnabled = true;
            this.lstDuration.ItemHeight = 20;
            this.lstDuration.Items.AddRange(new object[] {
            "60 Minutes",
            "120 Minutes",
            "180 Minutes",
            "240 Minutes",
            "300 Minutes",
            "360 Minutes",
            "420 Minutes",
            "480 Minutes"});
            this.lstDuration.Location = new System.Drawing.Point(638, 148);
            this.lstDuration.Name = "lstDuration";
            this.lstDuration.Size = new System.Drawing.Size(138, 124);
            this.lstDuration.TabIndex = 8;
            this.lstDuration.SelectedIndexChanged += new System.EventHandler(this.lstDuration_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(504, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back To Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDuration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lstPlace);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmReserveRoom";
            this.Text = "Reserve_Room";
            this.Load += new System.EventHandler(this.Reserve_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox lstDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}