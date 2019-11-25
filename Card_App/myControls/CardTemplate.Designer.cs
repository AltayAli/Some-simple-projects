namespace Card_App.myControls
{
    partial class CardTemplate
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
            this.crdTemplate = new System.Windows.Forms.GroupBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.crdTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crdTemplate
            // 
            this.crdTemplate.Controls.Add(this.lbl_Price);
            this.crdTemplate.Controls.Add(this.lbl_Name);
            this.crdTemplate.Controls.Add(this.pictureBox1);
            this.crdTemplate.Controls.Add(this.btn_add);
            this.crdTemplate.Location = new System.Drawing.Point(14, 20);
            this.crdTemplate.Name = "crdTemplate";
            this.crdTemplate.Size = new System.Drawing.Size(158, 217);
            this.crdTemplate.TabIndex = 0;
            this.crdTemplate.TabStop = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(50, 146);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(46, 18);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "label2";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(50, 119);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 18);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "Card_App.Properties.Resources._013_ph13_big.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(23, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(25, 182);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // CardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crdTemplate);
            this.Name = "CardTemplate";
            this.Size = new System.Drawing.Size(190, 260);
            this.crdTemplate.ResumeLayout(false);
            this.crdTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox crdTemplate;
        public System.Windows.Forms.Label lbl_Price;
        public System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_add;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
