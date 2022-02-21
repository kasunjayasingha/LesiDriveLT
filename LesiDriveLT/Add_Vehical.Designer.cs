namespace LesiDriveLT
{
    partial class Add_Vehical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Vehical));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Veh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboVe_pur = new System.Windows.Forms.ComboBox();
            this.comboVe_Type = new System.Windows.Forms.ComboBox();
            this.butclear = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.comboregno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 567);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 98);
            this.label1.TabIndex = 47;
            this.label1.Text = "Add Vehicel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.dataGridView_Veh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(297, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 254);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView_Veh
            // 
            this.dataGridView_Veh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Veh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Veh.Location = new System.Drawing.Point(0, 44);
            this.dataGridView_Veh.Name = "dataGridView_Veh";
            this.dataGridView_Veh.Size = new System.Drawing.Size(431, 210);
            this.dataGridView_Veh.TabIndex = 1;
            this.dataGridView_Veh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Veh_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicel Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(278, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Vehicle Purpose";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(278, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 39;
            this.label5.Text = "Vehicle Type:";
            // 
            // comboVe_pur
            // 
            this.comboVe_pur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboVe_pur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.comboVe_pur.FormattingEnabled = true;
            this.comboVe_pur.Items.AddRange(new object[] {
            "Rent",
            "Hire"});
            this.comboVe_pur.Location = new System.Drawing.Point(453, 37);
            this.comboVe_pur.Name = "comboVe_pur";
            this.comboVe_pur.Size = new System.Drawing.Size(152, 23);
            this.comboVe_pur.TabIndex = 40;
            // 
            // comboVe_Type
            // 
            this.comboVe_Type.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboVe_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.comboVe_Type.FormattingEnabled = true;
            this.comboVe_Type.Items.AddRange(new object[] {
            "SmallCar",
            "SedenCar",
            "SUV",
            "Jeep",
            "MiniVan",
            "CommuterVan"});
            this.comboVe_Type.Location = new System.Drawing.Point(453, 91);
            this.comboVe_Type.Name = "comboVe_Type";
            this.comboVe_Type.Size = new System.Drawing.Size(152, 23);
            this.comboVe_Type.TabIndex = 41;
            this.comboVe_Type.SelectedIndexChanged += new System.EventHandler(this.comboVe_Type_SelectedIndexChanged);
            // 
            // butclear
            // 
            this.butclear.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.butclear.Location = new System.Drawing.Point(624, 206);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(75, 23);
            this.butclear.TabIndex = 49;
            this.butclear.Text = "Clear";
            this.butclear.UseVisualStyleBackColor = true;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // butdelete
            // 
            this.butdelete.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.butdelete.Location = new System.Drawing.Point(520, 206);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(75, 23);
            this.butdelete.TabIndex = 48;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.butupdate.Location = new System.Drawing.Point(416, 206);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(75, 23);
            this.butupdate.TabIndex = 46;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = true;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butadd
            // 
            this.butadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.butadd.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.butadd.Location = new System.Drawing.Point(314, 206);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(75, 23);
            this.butadd.TabIndex = 45;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // comboregno
            // 
            this.comboregno.BackColor = System.Drawing.Color.White;
            this.comboregno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboregno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.comboregno.FormattingEnabled = true;
            this.comboregno.Items.AddRange(new object[] {
            "SP",
            "WP",
            "CP"});
            this.comboregno.Location = new System.Drawing.Point(453, 145);
            this.comboregno.Name = "comboregno";
            this.comboregno.Size = new System.Drawing.Size(52, 23);
            this.comboregno.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(278, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 145;
            this.label6.Text = "Vehicle Reg No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(713, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 150;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(743, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 149;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtregno
            // 
            this.txtregno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtregno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.txtregno.Location = new System.Drawing.Point(512, 145);
            this.txtregno.Multiline = true;
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(93, 23);
            this.txtregno.TabIndex = 151;
            // 
            // Add_Vehical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(772, 567);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboregno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butclear);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.comboVe_Type);
            this.Controls.Add(this.comboVe_pur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Vehical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Vehical";
            this.Load += new System.EventHandler(this.Add_Vehical_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Veh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Veh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboVe_pur;
        private System.Windows.Forms.ComboBox comboVe_Type;
        private System.Windows.Forms.Button butclear;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.ComboBox comboregno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtregno;
    }
}