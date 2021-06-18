
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
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Page";
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.ItemHeight = 20;
            this.lstRequest.Location = new System.Drawing.Point(48, 98);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(370, 324);
            this.lstRequest.TabIndex = 1;
            this.lstRequest.SelectedIndexChanged += new System.EventHandler(this.lstRequest_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(48, 443);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(166, 60);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Approve";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(240, 443);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(166, 60);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(876, 455);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(132, 49);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtReasonBox
            // 
            this.txtReasonBox.Location = new System.Drawing.Point(432, 295);
            this.txtReasonBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReasonBox.Multiline = true;
            this.txtReasonBox.Name = "txtReasonBox";
            this.txtReasonBox.ReadOnly = true;
            this.txtReasonBox.Size = new System.Drawing.Size(574, 121);
            this.txtReasonBox.TabIndex = 5;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(432, 271);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(65, 20);
            this.lblReason.TabIndex = 6;
            this.lblReason.Text = "Reason";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(696, 132);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(91, 20);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "New Data";
            // 
            // lblNewInfoText
            // 
            this.lblNewInfoText.AutoSize = true;
            this.lblNewInfoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewInfoText.Location = new System.Drawing.Point(696, 160);
            this.lblNewInfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewInfoText.Name = "lblNewInfoText";
            this.lblNewInfoText.Size = new System.Drawing.Size(2, 22);
            this.lblNewInfoText.TabIndex = 8;
            // 
            // lblOldInfoText
            // 
            this.lblOldInfoText.AutoSize = true;
            this.lblOldInfoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOldInfoText.Location = new System.Drawing.Point(435, 160);
            this.lblOldInfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldInfoText.Name = "lblOldInfoText";
            this.lblOldInfoText.Size = new System.Drawing.Size(2, 22);
            this.lblOldInfoText.TabIndex = 10;
            // 
            // lblOldInfo
            // 
            this.lblOldInfo.AutoSize = true;
            this.lblOldInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldInfo.Location = new System.Drawing.Point(435, 132);
            this.lblOldInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldInfo.Name = "lblOldInfo";
            this.lblOldInfo.Size = new System.Drawing.Size(84, 20);
            this.lblOldInfo.TabIndex = 9;
            this.lblOldInfo.Text = "Old Data";
            // 
            // lblRequester
            // 
            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(432, 98);
            this.lblRequester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequester.Name = "lblRequester";
            this.lblRequester.Size = new System.Drawing.Size(88, 20);
            this.lblRequester.TabIndex = 11;
            this.lblRequester.Text = "Requester:";
            // 
            // frmSeeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 555);
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