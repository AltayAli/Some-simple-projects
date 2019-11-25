namespace clothMarket
{
    partial class Form1
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
            this.Clothes = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paginationGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Clothes
            // 
            this.Clothes.Location = new System.Drawing.Point(29, 19);
            this.Clothes.Name = "Clothes";
            this.Clothes.Size = new System.Drawing.Size(673, 283);
            this.Clothes.TabIndex = 0;
            this.Clothes.TabStop = false;
            this.Clothes.Text = "Clothes";
            // 
            // paginationGroupBox
            // 
            this.paginationGroupBox.Location = new System.Drawing.Point(29, 338);
            this.paginationGroupBox.Name = "paginationGroupBox";
            this.paginationGroupBox.Size = new System.Drawing.Size(672, 66);
            this.paginationGroupBox.TabIndex = 1;
            this.paginationGroupBox.TabStop = false;
            this.paginationGroupBox.Text = "Pagination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paginationGroupBox);
            this.Controls.Add(this.Clothes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Clothes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox paginationGroupBox;
    }
}

