namespace Card_App.myControls
{
    partial class BasketİtemTemplate
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
            this.gr_bx = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.gr_bx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_bx
            // 
            this.gr_bx.Controls.Add(this.lbl_total);
            this.gr_bx.Controls.Add(this.btn_plus);
            this.gr_bx.Controls.Add(this.btn_minus);
            this.gr_bx.Controls.Add(this.lbl_price);
            this.gr_bx.Controls.Add(this.lbl_name);
            this.gr_bx.Location = new System.Drawing.Point(3, 3);
            this.gr_bx.Name = "gr_bx";
            this.gr_bx.Size = new System.Drawing.Size(537, 50);
            this.gr_bx.TabIndex = 0;
            this.gr_bx.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(9, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(244, 16);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(52, 18);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "label2";
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(202, 13);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(33, 23);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(302, 15);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(32, 21);
            this.btn_plus.TabIndex = 3;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(435, 19);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(52, 18);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "label3";
            // 
            // Basketİtem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gr_bx);
            this.Name = "Basketİtem";
            this.Size = new System.Drawing.Size(548, 63);
            this.gr_bx.ResumeLayout(false);
            this.gr_bx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_bx;
        public System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.Button btn_plus;
        public System.Windows.Forms.Button btn_minus;
        public System.Windows.Forms.Label lbl_price;
        public System.Windows.Forms.Label lbl_name;
    }
}
