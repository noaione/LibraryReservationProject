
namespace LibraryReservation
{
    partial class frmSeeRequest
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
            this.lstRequest = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtReasonBox = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNewInfoText = new System.Windows.Forms.Label();
            this.lblOldInfoText = new System.Windows.Forms.Label();
            this.lblOldInfo = new System.Windows.Forms.Label();
            this.lblRequester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Page";
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.Location = new System.Drawing.Point(32, 64);
            this.lstRequest.Margin = new System.Windows.Forms.Padding(2);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(248, 212);
            this.lstRequest.TabIndex = 1;
            this.lstRequest.SelectedIndexChanged += new System.EventHandler(this.lstRequest_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(32, 288);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 39);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Approve";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(160, 288);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(111, 39);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(584, 296);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(88, 32);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtReasonBox
            // 
            this.txtReasonBox.Location = new System.Drawing.Point(288, 192);
            this.txtReasonBox.Multiline = true;
            this.txtReasonBox.Name = "txtReasonBox";
            this.txtReasonBox.ReadOnly = true;
            this.txtReasonBox.Size = new System.Drawing.Size(384, 80);
            this.txtReasonBox.TabIndex = 5;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(288, 176);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 6;
            this.lblReason.Text = "Reason";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(464, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(63, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "New Data";
            // 
            // lblNewInfoText
            // 
            this.lblNewInfoText.AutoSize = true;
            this.lblNewInfoText.Location = new System.Drawing.Point(464, 104);
            this.lblNewInfoText.Name = "lblNewInfoText";
            this.lblNewInfoText.Size = new System.Drawing.Size(0, 13);
            this.lblNewInfoText.TabIndex = 8;
            // 
            // lblOldInfoText
            // 
            this.lblOldInfoText.AutoSize = true;
            this.lblOldInfoText.Location = new System.Drawing.Point(290, 104);
            this.lblOldInfoText.Name = "lblOldInfoText";
            this.lblOldInfoText.Size = new System.Drawing.Size(0, 13);
            this.lblOldInfoText.TabIndex = 10;
            // 
            // lblOldInfo
            // 
            this.lblOldInfo.AutoSize = true;
            this.lblOldInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo.Location = new System.Drawing.Point(290, 86);
            this.lblOldInfo.Name = "lblOldInfo";
            this.lblOldInfo.Size = new System.Drawing.Size(57, 13);
            this.lblOldInfo.TabIndex = 9;
            this.lblOldInfo.Text = "Old Data";
            // 
            // lblRequester
            // 
            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(288, 64);
            this.lblRequester.Name = "lblRequester";
            this.lblRequester.Size = new System.Drawing.Size(59, 13);
            this.lblRequester.TabIndex = 11;
            this.lblRequester.Text = "Requester:";
            // 
            // frmSeeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 361);
            this.Controls.Add(this.lblRequester);
            this.Controls.Add(this.lblOldInfoText);
            this.Controls.Add(this.lblOldInfo);
            this.Controls.Add(this.lblNewInfoText);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReasonBox);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lstRequest);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSeeRequest";
            this.Text = "Library Reservation - User Request";
            this.Load += new System.EventHandler(this.frmSeeRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRequest;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtReasonBox;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNewInfoText;
        private System.Windows.Forms.Label lblOldInfoText;
        private System.Windows.Forms.Label lblOldInfo;
        private System.Windows.Forms.Label lblRequester;
    }
}