namespace Ticket_App
{
    partial class TicketForm
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
            this.btn_new = new System.Windows.Forms.Button();
            this.ticketViewer = new System.Windows.Forms.ListView();
            this.grbx_pagination = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(667, 32);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(69, 20);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // ticketViewer
            // 
            this.ticketViewer.Location = new System.Drawing.Point(-1, 58);
            this.ticketViewer.Name = "ticketViewer";
            this.ticketViewer.Size = new System.Drawing.Size(737, 314);
            this.ticketViewer.TabIndex = 1;
            this.ticketViewer.UseCompatibleStateImageBehavior = false;
            // 
            // grbx_pagination
            // 
            this.grbx_pagination.Location = new System.Drawing.Point(120, 398);
            this.grbx_pagination.Name = "grbx_pagination";
            this.grbx_pagination.Size = new System.Drawing.Size(520, 32);
            this.grbx_pagination.TabIndex = 3;
            this.grbx_pagination.TabStop = false;
            this.grbx_pagination.Text = "Pagination";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 446);
            this.Controls.Add(this.grbx_pagination);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.ticketViewer);
            this.Controls.Add(this.label1);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.ListView ticketViewer;
        public System.Windows.Forms.GroupBox grbx_pagination;
    }
}