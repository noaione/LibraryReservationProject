
namespace LibraryReservation
{
    partial class frmEditRoomReservation
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
            this.lblReserveInfo = new System.Windows.Forms.Label();
            this.lblReserveInfoText = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lstDuration = new System.Windows.Forms.ListBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lstNewRoom = new System.Windows.Forms.ListBox();
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblNewRInfoText = new System.Windows.Forms.Label();
            this.lblNewRInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(272, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Room Reservation";
            // 
            // lblReserveInfo
            // 
            this.lblReserveInfo.AutoSize = true;
            this.lblReserveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveInfo.Location = new System.Drawing.Point(48, 80);
            this.lblReserveInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReserveInfo.Name = "lblReserveInfo";
            this.lblReserveInfo.Size = new System.Drawing.Size(142, 20);
            this.lblReserveInfo.TabIndex = 1;
            this.lblReserveInfo.Text = "Reservation Info";
            // 
            // lblReserveInfoText
            // 
            this.lblReserveInfoText.AutoSize = true;
            this.lblReserveInfoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReserveInfoText.Location = new System.Drawing.Point(51, 113);
            this.lblReserveInfoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReserveInfoText.Name = "lblReserveInfoText";
            this.lblReserveInfoText.Size = new System.Drawing.Size(2, 15);
            this.lblReserveInfoText.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(253, 211);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(163, 20);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Edit Date and Time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(256, 240);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(256, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Request Change";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancle.Location = new System.Drawing.Point(448, 280);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(199, 33);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "Go Back";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lstDuration
            // 
            this.lstDuration.FormattingEnabled = true;
            this.lstDuration.Items.AddRange(new object[] {
            "60 Minutes",
            "120 Minutes",
            "180 Minutes",
            "240 Minutes",
            "300 Minutes",
            "360 Minutes",
            "420 Minutes",
            "480 Minutes"});
            this.lstDuration.Location = new System.Drawing.Point(376, 104);
            this.lstDuration.Margin = new System.Windows.Forms.Padding(2);
            this.lstDuration.Name = "lstDuration";
            this.lstDuration.Size = new System.Drawing.Size(112, 82);
            this.lstDuration.TabIndex = 10;
            this.lstDuration.SelectedIndexChanged += new System.EventHandler(this.lstDuration_SelectedIndexChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(376, 80);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(115, 20);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "Edit Duration";
            // 
            // lstNewRoom
            // 
            this.lstNewRoom.FormattingEnabled = true;
            this.lstNewRoom.Location = new System.Drawing.Point(256, 104);
            this.lstNewRoom.Margin = new System.Windows.Forms.Padding(2);
            this.lstNewRoom.Name = "lstNewRoom";
            this.lstNewRoom.Size = new System.Drawing.Size(112, 82);
            this.lstNewRoom.TabIndex = 11;
            this.lstNewRoom.SelectedIndexChanged += new System.EventHandler(this.lstNewRoom_SelectedIndexChanged);
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRoom.Location = new System.Drawing.Point(256, 80);
            this.lblNewRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(93, 20);
            this.lblNewRoom.TabIndex = 12;
            this.lblNewRoom.Text = "Edit Room";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(496, 104);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(264, 80);
            this.txtReason.TabIndex = 13;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReason.Location = new System.Drawing.Point(496, 80);
            this.lblReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(138, 20);
            this.lblReason.TabIndex = 14;
            this.lblReason.Text = "Change Reason";
            // 
            // lblNewRInfoText
            // 
            this.lblNewRInfoText.AutoSize = true;
            this.lblNewRInfoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewRInfoText.Location = new System.Drawing.Point(51, 241);
            this.lblNewRInfoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewRInfoText.Name = "lblNewRInfoText";
            this.lblNewRInfoText.Size = new System.Drawing.Size(2, 15);
            this.lblNewRInfoText.TabIndex = 16;
            // 
            // lblNewRInfo
            // 
            this.lblNewRInfo.AutoSize = true;
            this.lblNewRInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRInfo.Location = new System.Drawing.Point(48, 210);
            this.lblNewRInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewRInfo.Name = "lblNewRInfo";
            this.lblNewRInfo.Size = new System.Drawing.Size(181, 20);
            this.lblNewRInfo.TabIndex = 15;
            this.lblNewRInfo.Text = "New Reservation Info";
            // 
            // frmEditRoomReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 367);
            this.Controls.Add(this.lblNewRInfoText);
            this.Controls.Add(this.lblNewRInfo);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblNewRoom);
            this.Controls.Add(this.lstNewRoom);
            this.Controls.Add(this.lstDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblReserveInfoText);
            this.Controls.Add(this.lblReserveInfo);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditRoomReservation";
            this.Text = "Library Reservation - Edit Room";
            this.Load += new System.EventHandler(this.EditRoomReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReserveInfo;
        private System.Windows.Forms.Label lblReserveInfoText;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ListBox lstDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ListBox lstNewRoom;
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblNewRInfoText;
        private System.Windows.Forms.Label lblNewRInfo;
    }
}