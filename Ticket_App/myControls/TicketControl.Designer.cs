namespace Ticket_App.myControls
{
    partial class TicketControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lbl_short = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx
            // 
            this.grbx.Controls.Add(this.btn_edit);
            this.grbx.Controls.Add(this.lblStatus);
            this.grbx.Controls.Add(this.lbl_name);
            this.grbx.Controls.Add(this.lblDetail);
            this.grbx.Controls.Add(this.lbl_short);
            this.grbx.Location = new System.Drawing.Point(8, 8);
            this.grbx.Name = "grbx";
            this.grbx.Size = new System.Drawing.Size(674, 40);
            this.grbx.TabIndex = 0;
            this.grbx.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(593, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(519, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label4";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(11, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 18);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "label1";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(253, 16);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(46, 18);
            this.lblDetail.TabIndex = 7;
            this.lblDetail.Text = "label3";
            // 
            // lbl_short
            // 
            this.lbl_short.AutoSize = true;
            this.lbl_short.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_short.Location = new System.Drawing.Point(125, 16);
            this.lbl_short.Name = "lbl_short";
            this.lbl_short.Size = new System.Drawing.Size(46, 18);
            this.lbl_short.TabIndex = 6;
            this.lbl_short.Text = "label2";
            // 
            // TicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbx);
            this.Name = "TicketControl";
            this.Size = new System.Drawing.Size(697, 68);
            this.grbx.ResumeLayout(false);
            this.grbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.Label lbl_short;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
