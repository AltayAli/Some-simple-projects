namespace Ticket_App
{
    partial class RegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regusterButton = new System.Windows.Forms.Button();
            this.login_link = new System.Windows.Forms.LinkLabel();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regusterButton);
            this.groupBox1.Controls.Add(this.login_link);
            this.groupBox1.Controls.Add(this.txbx_password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbx_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // regusterButton
            // 
            this.regusterButton.Location = new System.Drawing.Point(106, 274);
            this.regusterButton.Name = "regusterButton";
            this.regusterButton.Size = new System.Drawing.Size(75, 23);
            this.regusterButton.TabIndex = 9;
            this.regusterButton.Text = "Register";
            this.regusterButton.UseVisualStyleBackColor = true;
            this.regusterButton.Click += new System.EventHandler(this.regusterButton_Click);
            // 
            // login_link
            // 
            this.login_link.AutoSize = true;
            this.login_link.Location = new System.Drawing.Point(148, 238);
            this.login_link.Name = "login_link";
            this.login_link.Size = new System.Drawing.Size(101, 13);
            this.login_link.TabIndex = 8;
            this.login_link.TabStop = true;
            this.login_link.Text = "You have account?";
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(47, 204);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(202, 20);
            this.txbx_password.TabIndex = 7;
            this.txbx_password.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please enter your password";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(47, 152);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(202, 20);
            this.txbx_email.TabIndex = 5;
            this.txbx_email.Text = "altay@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please enter your email";
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(47, 103);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(202, 20);
            this.txbx_surname.TabIndex = 3;
            this.txbx_surname.Text = "Ali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter your surname";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(47, 50);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(202, 20);
            this.txbx_name.TabIndex = 1;
            this.txbx_name.Text = "Altay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button regusterButton;
        private System.Windows.Forms.LinkLabel login_link;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
    }
}

