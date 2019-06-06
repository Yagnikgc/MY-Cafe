namespace MY_C_fe
{
    partial class WelCome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelCome));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Opera = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.safari = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Mozila = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shp_explorer = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lbl_tm = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Opera,
            this.safari,
            this.Mozila,
            this.shp_explorer,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1121, 579);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // Opera
            // 
            this.Opera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Opera.BorderColor = System.Drawing.Color.Transparent;
            this.Opera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Opera.Location = new System.Drawing.Point(522, 359);
            this.Opera.Name = "Opera";
            this.Opera.SelectionColor = System.Drawing.Color.Transparent;
            this.Opera.Size = new System.Drawing.Size(65, 134);
            this.Opera.Click += new System.EventHandler(this.opera_Click);
            // 
            // safari
            // 
            this.safari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.safari.BorderColor = System.Drawing.Color.Transparent;
            this.safari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.safari.Location = new System.Drawing.Point(-38, 364);
            this.safari.Name = "safari";
            this.safari.SelectionColor = System.Drawing.Color.Transparent;
            this.safari.Size = new System.Drawing.Size(65, 134);
            this.safari.Click += new System.EventHandler(this.safari_Click);
            // 
            // Mozila
            // 
            this.Mozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mozila.BorderColor = System.Drawing.Color.Transparent;
            this.Mozila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mozila.Location = new System.Drawing.Point(40, 345);
            this.Mozila.Name = "Mozila";
            this.Mozila.SelectionColor = System.Drawing.Color.Transparent;
            this.Mozila.Size = new System.Drawing.Size(108, 162);
            this.Mozila.Click += new System.EventHandler(this.mozila_Click);
            // 
            // shp_explorer
            // 
            this.shp_explorer.BorderColor = System.Drawing.Color.Transparent;
            this.shp_explorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shp_explorer.Location = new System.Drawing.Point(531, 390);
            this.shp_explorer.Name = "shp_explorer";
            this.shp_explorer.SelectionColor = System.Drawing.Color.Transparent;
            this.shp_explorer.Size = new System.Drawing.Size(116, 231);
            this.shp_explorer.Click += new System.EventHandler(this.shp_explorer_Click);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.Transparent;
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalShape1.Location = new System.Drawing.Point(262, 352);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Size = new System.Drawing.Size(268, 259);
            this.ovalShape1.Click += new System.EventHandler(this.ovalShape1_Click_2);
            // 
            // lbl_tm
            // 
            this.lbl_tm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tm.AutoSize = true;
            this.lbl_tm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tm.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tm.Location = new System.Drawing.Point(73, 186);
            this.lbl_tm.Name = "lbl_tm";
            this.lbl_tm.Size = new System.Drawing.Size(93, 63);
            this.lbl_tm.TabIndex = 1;
            this.lbl_tm.Text = "00";
            // 
            // lbl_sec
            // 
            this.lbl_sec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sec.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sec.Location = new System.Drawing.Point(172, 218);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(68, 47);
            this.lbl_sec.TabIndex = 2;
            this.lbl_sec.Text = "00";
            this.lbl_sec.Click += new System.EventHandler(this.lbl_sec_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1093, 129);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "LogOut";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lbl_hours
            // 
            this.lbl_hours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hours.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Bold);
            this.lbl_hours.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hours.Location = new System.Drawing.Point(-54, 129);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(138, 95);
            this.lbl_hours.TabIndex = 5;
            this.lbl_hours.Text = "00";
            // 
            // WelCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 579);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_tm);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelCome";
            this.Text = "WelCome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WelCome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shp_explorer;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Mozila;
        private Microsoft.VisualBasic.PowerPacks.OvalShape safari;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Opera;
        private System.Windows.Forms.Label lbl_tm;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hours;




    }
}