namespace YonetimMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_urunler = new System.Windows.Forms.Button();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.btn_menuler = new System.Windows.Forms.Button();
            this.btn_hareketler = new System.Windows.Forms.Button();
            this.btn_kullanıcılar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_yonetim = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yonetim)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_urunler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ayarlar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_menuler, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_hareketler, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_kullanıcılar, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 324);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_urunler
            // 
            this.btn_urunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_urunler.FlatAppearance.BorderSize = 0;
            this.btn_urunler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_urunler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_urunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunler.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunler.ForeColor = System.Drawing.Color.White;
            this.btn_urunler.Location = new System.Drawing.Point(3, 38);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.Size = new System.Drawing.Size(165, 29);
            this.btn_urunler.TabIndex = 2;
            this.btn_urunler.Text = "Ürünler";
            this.btn_urunler.UseVisualStyleBackColor = false;
            this.btn_urunler.Click += new System.EventHandler(this.btn_urunler_Click);
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_ayarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ayarlar.FlatAppearance.BorderSize = 0;
            this.btn_ayarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ayarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayarlar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ayarlar.ForeColor = System.Drawing.Color.White;
            this.btn_ayarlar.Location = new System.Drawing.Point(3, 3);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(165, 29);
            this.btn_ayarlar.TabIndex = 2;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.UseVisualStyleBackColor = false;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // btn_menuler
            // 
            this.btn_menuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_menuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_menuler.FlatAppearance.BorderSize = 0;
            this.btn_menuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_menuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_menuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuler.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuler.ForeColor = System.Drawing.Color.White;
            this.btn_menuler.Location = new System.Drawing.Point(3, 73);
            this.btn_menuler.Name = "btn_menuler";
            this.btn_menuler.Size = new System.Drawing.Size(165, 29);
            this.btn_menuler.TabIndex = 2;
            this.btn_menuler.Text = "Menüler";
            this.btn_menuler.UseVisualStyleBackColor = false;
            this.btn_menuler.Click += new System.EventHandler(this.btn_menuler_Click);
            // 
            // btn_hareketler
            // 
            this.btn_hareketler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_hareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hareketler.FlatAppearance.BorderSize = 0;
            this.btn_hareketler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hareketler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hareketler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hareketler.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hareketler.ForeColor = System.Drawing.Color.White;
            this.btn_hareketler.Location = new System.Drawing.Point(3, 108);
            this.btn_hareketler.Name = "btn_hareketler";
            this.btn_hareketler.Size = new System.Drawing.Size(165, 29);
            this.btn_hareketler.TabIndex = 2;
            this.btn_hareketler.Text = "Hareketler";
            this.btn_hareketler.UseVisualStyleBackColor = false;
            this.btn_hareketler.Click += new System.EventHandler(this.btn_hareketler_Click);
            // 
            // btn_kullanıcılar
            // 
            this.btn_kullanıcılar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_kullanıcılar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kullanıcılar.FlatAppearance.BorderSize = 0;
            this.btn_kullanıcılar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kullanıcılar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kullanıcılar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanıcılar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanıcılar.ForeColor = System.Drawing.Color.White;
            this.btn_kullanıcılar.Location = new System.Drawing.Point(3, 143);
            this.btn_kullanıcılar.Name = "btn_kullanıcılar";
            this.btn_kullanıcılar.Size = new System.Drawing.Size(165, 32);
            this.btn_kullanıcılar.TabIndex = 2;
            this.btn_kullanıcılar.Text = "Kullanıcılar";
            this.btn_kullanıcılar.UseVisualStyleBackColor = false;
            this.btn_kullanıcılar.Click += new System.EventHandler(this.btn_kullanıcılar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_yonetim, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.76237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.23763F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(177, 505);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgv_yonetim
            // 
            this.dgv_yonetim.AllowUserToAddRows = false;
            this.dgv_yonetim.AllowUserToDeleteRows = false;
            this.dgv_yonetim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_yonetim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_yonetim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgv_yonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_yonetim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_yonetim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_yonetim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_yonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yonetim.ColumnHeadersVisible = false;
            this.dgv_yonetim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Pro Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_yonetim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_yonetim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_yonetim.EnableHeadersVisualStyles = false;
            this.dgv_yonetim.Location = new System.Drawing.Point(3, 3);
            this.dgv_yonetim.MultiSelect = false;
            this.dgv_yonetim.Name = "dgv_yonetim";
            this.dgv_yonetim.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_yonetim.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_yonetim.RowHeadersVisible = false;
            this.dgv_yonetim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_yonetim.Size = new System.Drawing.Size(171, 315);
            this.dgv_yonetim.TabIndex = 6;
            this.dgv_yonetim.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Button";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;          
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.59756F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.40244F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(984, 511);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel3_CellPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yonetim)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button btn_urunler;
        public System.Windows.Forms.Button btn_ayarlar;
        public System.Windows.Forms.Button btn_kullanıcılar;
        public System.Windows.Forms.DataGridView dgv_yonetim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btn_menuler;
        public System.Windows.Forms.Button btn_hareketler;
    }
}

