namespace Ticket_App
{
    partial class MyTicket
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
            this.grbx = new System.Windows.Forms.GroupBox();
            this.txbx_detail = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txbx_short = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.grbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx
            // 
            this.grbx.Controls.Add(this.btn_edit);
            this.grbx.Controls.Add(this.txbx_detail);
            this.grbx.Controls.Add(this.btn_send);
            this.grbx.Controls.Add(this.txbx_short);
            this.grbx.Location = new System.Drawing.Point(6, 4);
            this.grbx.Name = "grbx";
            this.grbx.Size = new System.Drawing.Size(280, 240);
            this.grbx.TabIndex = 3;
            this.grbx.TabStop = false;
            this.grbx.Enter += new System.EventHandler(this.grbx_Enter);
            // 
            // txbx_detail
            // 
            this.txbx_detail.Location = new System.Drawing.Point(29, 110);
            this.txbx_detail.Multiline = true;
            this.txbx_detail.Name = "txbx_detail";
            this.txbx_detail.Size = new System.Drawing.Size(202, 95);
            this.txbx_detail.TabIndex = 10;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(91, 211);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txbx_short
            // 
            this.txbx_short.Location = new System.Drawing.Point(29, 41);
            this.txbx_short.Name = "txbx_short";
            this.txbx_short.Size = new System.Drawing.Size(202, 20);
            this.txbx_short.TabIndex = 7;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(91, 211);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // MyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.grbx);
            this.Name = "MyTicket";
            this.Text = "Form1";
            this.grbx.ResumeLayout(false);
            this.grbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx;
        private System.Windows.Forms.TextBox txbx_short;
        private System.Windows.Forms.TextBox txbx_detail;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_send;
    }
}