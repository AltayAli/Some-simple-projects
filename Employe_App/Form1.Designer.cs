namespace Employe_App
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_workBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qeydiyyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_show_logs = new System.Windows.Forms.Button();
            this.btn_show_employe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(24, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(188, 20);
            this.txt_name.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(53, 396);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 28);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(24, 89);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(188, 20);
            this.txt_surname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Workbook";
            // 
            // txt_workBook
            // 
            this.txt_workBook.Location = new System.Drawing.Point(24, 148);
            this.txt_workBook.Name = "txt_workBook";
            this.txt_workBook.Size = new System.Drawing.Size(188, 20);
            this.txt_workBook.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Qeydiyyat yeri";
            // 
            // txt_qeydiyyat
            // 
            this.txt_qeydiyyat.Location = new System.Drawing.Point(24, 207);
            this.txt_qeydiyyat.Name = "txt_qeydiyyat";
            this.txt_qeydiyyat.Size = new System.Drawing.Size(188, 20);
            this.txt_qeydiyyat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "S/V";
            // 
            // txt_sv
            // 
            this.txt_sv.Location = new System.Drawing.Point(24, 259);
            this.txt_sv.Name = "txt_sv";
            this.txt_sv.Size = new System.Drawing.Size(188, 20);
            this.txt_sv.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dogum tarixi";
            // 
            // dt_birthday
            // 
            this.dt_birthday.Location = new System.Drawing.Point(24, 312);
            this.dt_birthday.Name = "dt_birthday";
            this.dt_birthday.Size = new System.Drawing.Size(187, 20);
            this.dt_birthday.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sirket";
            // 
            // cb_company
            // 
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Location = new System.Drawing.Point(24, 369);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(186, 21);
            this.cb_company.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(247, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 321);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(470, 69);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(189, 321);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            // 
            // btn_show_logs
            // 
            this.btn_show_logs.Location = new System.Drawing.Point(470, 29);
            this.btn_show_logs.Name = "btn_show_logs";
            this.btn_show_logs.Size = new System.Drawing.Size(189, 28);
            this.btn_show_logs.TabIndex = 24;
            this.btn_show_logs.Text = "Show logs";
            this.btn_show_logs.UseVisualStyleBackColor = true;
            this.btn_show_logs.Click += new System.EventHandler(this.btn_show_logs_Click);
            // 
            // btn_show_employe
            // 
            this.btn_show_employe.Location = new System.Drawing.Point(247, 29);
            this.btn_show_employe.Name = "btn_show_employe";
            this.btn_show_employe.Size = new System.Drawing.Size(189, 28);
            this.btn_show_employe.TabIndex = 25;
            this.btn_show_employe.Text = "Employee list";
            this.btn_show_employe.UseVisualStyleBackColor = true;
            this.btn_show_employe.Click += new System.EventHandler(this.btn_show_employe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 451);
            this.Controls.Add(this.btn_show_employe);
            this.Controls.Add(this.btn_show_logs);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cb_company);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qeydiyyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_workBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_workBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qeydiyyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_show_logs;
        private System.Windows.Forms.Button btn_show_employe;
    }
}

