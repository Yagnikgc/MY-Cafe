namespace MY_C_fe
{
    partial class Hostory
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
            this.btn_chrome = new System.Windows.Forms.Button();
            this.btn_Safari = new System.Windows.Forms.Button();
            this.btn_Mozila = new System.Windows.Forms.Button();
            this.btn_Opera = new System.Windows.Forms.Button();
            this.btn_Explorer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chrome
            // 
            this.btn_chrome.Location = new System.Drawing.Point(130, 73);
            this.btn_chrome.Name = "btn_chrome";
            this.btn_chrome.Size = new System.Drawing.Size(75, 23);
            this.btn_chrome.TabIndex = 0;
            this.btn_chrome.Text = "Chrome";
            this.btn_chrome.UseVisualStyleBackColor = true;
            this.btn_chrome.Click += new System.EventHandler(this.btn_chrome_Click);
            // 
            // btn_Safari
            // 
            this.btn_Safari.Location = new System.Drawing.Point(259, 73);
            this.btn_Safari.Name = "btn_Safari";
            this.btn_Safari.Size = new System.Drawing.Size(75, 23);
            this.btn_Safari.TabIndex = 0;
            this.btn_Safari.Text = "Safari";
            this.btn_Safari.UseVisualStyleBackColor = true;
            this.btn_Safari.Click += new System.EventHandler(this.btn_Safari_Click);
            // 
            // btn_Mozila
            // 
            this.btn_Mozila.Location = new System.Drawing.Point(386, 73);
            this.btn_Mozila.Name = "btn_Mozila";
            this.btn_Mozila.Size = new System.Drawing.Size(75, 23);
            this.btn_Mozila.TabIndex = 0;
            this.btn_Mozila.Text = "Mozila";
            this.btn_Mozila.UseVisualStyleBackColor = true;
            this.btn_Mozila.Click += new System.EventHandler(this.btn_Mozila_Click);
            // 
            // btn_Opera
            // 
            this.btn_Opera.Location = new System.Drawing.Point(519, 73);
            this.btn_Opera.Name = "btn_Opera";
            this.btn_Opera.Size = new System.Drawing.Size(75, 23);
            this.btn_Opera.TabIndex = 0;
            this.btn_Opera.Text = "Opera";
            this.btn_Opera.UseVisualStyleBackColor = true;
            this.btn_Opera.Click += new System.EventHandler(this.btn_Opera_Click);
            // 
            // btn_Explorer
            // 
            this.btn_Explorer.Location = new System.Drawing.Point(654, 73);
            this.btn_Explorer.Name = "btn_Explorer";
            this.btn_Explorer.Size = new System.Drawing.Size(75, 23);
            this.btn_Explorer.TabIndex = 0;
            this.btn_Explorer.Text = "Explorer";
            this.btn_Explorer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(599, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(783, 433);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Hostory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 468);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Explorer);
            this.Controls.Add(this.btn_Opera);
            this.Controls.Add(this.btn_Mozila);
            this.Controls.Add(this.btn_Safari);
            this.Controls.Add(this.btn_chrome);
            this.Name = "Hostory";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chrome;
        private System.Windows.Forms.Button btn_Safari;
        private System.Windows.Forms.Button btn_Mozila;
        private System.Windows.Forms.Button btn_Opera;
        private System.Windows.Forms.Button btn_Explorer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
    }
}