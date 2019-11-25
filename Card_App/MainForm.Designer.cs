namespace Card_App
{
    partial class MainForm
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
            this.cards_panel = new System.Windows.Forms.Panel();
            this.pagiantion_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_basket = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.paginationGroupBox = new System.Windows.Forms.GroupBox();
            this.cards_panel.SuspendLayout();
            this.pagiantion_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cards_panel
            // 
            this.cards_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cards_panel.Controls.Add(this.grpBox);
            this.cards_panel.Location = new System.Drawing.Point(10, 8);
            this.cards_panel.Name = "cards_panel";
            this.cards_panel.Size = new System.Drawing.Size(825, 501);
            this.cards_panel.TabIndex = 0;
            // 
            // pagiantion_panel
            // 
            this.pagiantion_panel.BackColor = System.Drawing.Color.Red;
            this.pagiantion_panel.Controls.Add(this.paginationGroupBox);
            this.pagiantion_panel.Location = new System.Drawing.Point(171, 515);
            this.pagiantion_panel.Name = "pagiantion_panel";
            this.pagiantion_panel.Size = new System.Drawing.Size(493, 41);
            this.pagiantion_panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_basket);
            this.panel1.Location = new System.Drawing.Point(841, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 33);
            this.panel1.TabIndex = 2;
            // 
            // btn_basket
            // 
            this.btn_basket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_basket.Location = new System.Drawing.Point(0, 0);
            this.btn_basket.Name = "btn_basket";
            this.btn_basket.Size = new System.Drawing.Size(51, 33);
            this.btn_basket.TabIndex = 0;
            this.btn_basket.Text = "0";
            this.btn_basket.UseVisualStyleBackColor = true;
            this.btn_basket.Click += new System.EventHandler(this.btn_basket_Click);
            // 
            // grpBox
            // 
            this.grpBox.Location = new System.Drawing.Point(11, 8);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(801, 492);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "groupBox1";
            // 
            // paginationGroupBox
            // 
            this.paginationGroupBox.Location = new System.Drawing.Point(4, 0);
            this.paginationGroupBox.Name = "paginationGroupBox";
            this.paginationGroupBox.Size = new System.Drawing.Size(488, 38);
            this.paginationGroupBox.TabIndex = 0;
            this.paginationGroupBox.TabStop = false;
            this.paginationGroupBox.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pagiantion_panel);
            this.Controls.Add(this.cards_panel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cards_panel.ResumeLayout(false);
            this.pagiantion_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel cards_panel;
        public System.Windows.Forms.Panel pagiantion_panel;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.GroupBox paginationGroupBox;
        public System.Windows.Forms.Button btn_basket;
    }
}

