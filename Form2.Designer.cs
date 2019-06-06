namespace MY_C_fe
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_chng = new System.Windows.Forms.Button();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.txt_rpasswd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_rpwd = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(37, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password :";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(206, 50);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(119, 20);
            this.txt_user.TabIndex = 4;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_user.Location = new System.Drawing.Point(209, 70);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 15);
            this.lbl_user.TabIndex = 5;
            // 
            // btn_chng
            // 
            this.btn_chng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chng.BackgroundImage")));
            this.btn_chng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chng.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_chng.Location = new System.Drawing.Point(93, 224);
            this.btn_chng.Name = "btn_chng";
            this.btn_chng.Size = new System.Drawing.Size(77, 26);
            this.btn_chng.TabIndex = 6;
            this.btn_chng.Text = "Change";
            this.btn_chng.UseVisualStyleBackColor = true;
            this.btn_chng.Click += new System.EventHandler(this.btn_chng_Click_1);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(206, 87);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(119, 20);
            this.txt_mail.TabIndex = 7;
            // 
            // txt_passwd
            // 
            this.txt_passwd.Location = new System.Drawing.Point(206, 126);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.Size = new System.Drawing.Size(119, 20);
            this.txt_passwd.TabIndex = 8;
            // 
            // txt_rpasswd
            // 
            this.txt_rpasswd.Location = new System.Drawing.Point(206, 167);
            this.txt_rpasswd.Name = "txt_rpasswd";
            this.txt_rpasswd.Size = new System.Drawing.Size(119, 20);
            this.txt_rpasswd.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(186, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.ForeColor = System.Drawing.Color.Red;
            this.lbl_mail.Location = new System.Drawing.Point(209, 107);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(0, 13);
            this.lbl_mail.TabIndex = 11;
            // 
            // lbl_rpwd
            // 
            this.lbl_rpwd.AutoSize = true;
            this.lbl_rpwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rpwd.ForeColor = System.Drawing.Color.Red;
            this.lbl_rpwd.Location = new System.Drawing.Point(209, 187);
            this.lbl_rpwd.Name = "lbl_rpwd";
            this.lbl_rpwd.Size = new System.Drawing.Size(0, 13);
            this.lbl_rpwd.TabIndex = 12;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd.ForeColor = System.Drawing.Color.Red;
            this.lbl_pwd.Location = new System.Drawing.Point(209, 146);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(0, 13);
            this.lbl_pwd.TabIndex = 13;
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_rpwd);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_rpasswd);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.btn_chng);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_chng;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.TextBox txt_rpasswd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_rpwd;
        private System.Windows.Forms.Label lbl_pwd;
    }
}