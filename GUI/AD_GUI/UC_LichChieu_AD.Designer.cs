﻿namespace GUI.AD_GUI
{
    partial class UC_LichChieu_AD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTimKiemDK = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemCT = new System.Windows.Forms.ComboBox();
            this.txtTimKiemCT = new System.Windows.Forms.TextBox();
            this.btnTimKiemCT = new System.Windows.Forms.Button();
            this.btnKhongDongY = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLichChieuCT = new System.Windows.Forms.DataGridView();
            this.txtTimKiemDK = new System.Windows.Forms.TextBox();
            this.btnTimKiemDK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichChieuDK = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbTimKiemCT);
            this.panel1.Controls.Add(this.txtTimKiemCT);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnTimKiemCT);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 461);
            this.panel1.TabIndex = 0;
            // 
            // cbbTimKiemDK
            // 
            this.cbbTimKiemDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiemDK.FormattingEnabled = true;
            this.cbbTimKiemDK.Items.AddRange(new object[] {
            "Tên Phim",
            "Tên Phòng Chiếu",
            "Ngày Chiếu"});
            this.cbbTimKiemDK.Location = new System.Drawing.Point(549, 24);
            this.cbbTimKiemDK.Name = "cbbTimKiemDK";
            this.cbbTimKiemDK.Size = new System.Drawing.Size(120, 23);
            this.cbbTimKiemDK.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKhongDongY);
            this.groupBox3.Controls.Add(this.cbbTimKiemDK);
            this.groupBox3.Controls.Add(this.btnDongY);
            this.groupBox3.Controls.Add(this.btnTimKiemDK);
            this.groupBox3.Controls.Add(this.txtTimKiemDK);
            this.groupBox3.Location = new System.Drawing.Point(15, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 60);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // cbbTimKiemCT
            // 
            this.cbbTimKiemCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimKiemCT.FormattingEnabled = true;
            this.cbbTimKiemCT.Items.AddRange(new object[] {
            "Tên Phim",
            "Tên Phòng Chiếu",
            "Ngày Chiếu"});
            this.cbbTimKiemCT.Location = new System.Drawing.Point(564, 409);
            this.cbbTimKiemCT.Name = "cbbTimKiemCT";
            this.cbbTimKiemCT.Size = new System.Drawing.Size(120, 23);
            this.cbbTimKiemCT.TabIndex = 26;
            // 
            // txtTimKiemCT
            // 
            this.txtTimKiemCT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemCT.Location = new System.Drawing.Point(397, 409);
            this.txtTimKiemCT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemCT.Name = "txtTimKiemCT";
            this.txtTimKiemCT.Size = new System.Drawing.Size(157, 24);
            this.txtTimKiemCT.TabIndex = 25;
            // 
            // btnTimKiemCT
            // 
            this.btnTimKiemCT.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemCT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemCT.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemCT.Location = new System.Drawing.Point(300, 407);
            this.btnTimKiemCT.Name = "btnTimKiemCT";
            this.btnTimKiemCT.Size = new System.Drawing.Size(92, 26);
            this.btnTimKiemCT.TabIndex = 24;
            this.btnTimKiemCT.Text = "TÌM KIẾM";
            this.btnTimKiemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemCT.UseVisualStyleBackColor = false;
            this.btnTimKiemCT.Click += new System.EventHandler(this.btnTimKiemCT_Click);
            // 
            // btnKhongDongY
            // 
            this.btnKhongDongY.BackColor = System.Drawing.Color.LightCoral;
            this.btnKhongDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongDongY.Image = global::GUI.Properties.Resources.Close;
            this.btnKhongDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhongDongY.Location = new System.Drawing.Point(130, 24);
            this.btnKhongDongY.Name = "btnKhongDongY";
            this.btnKhongDongY.Size = new System.Drawing.Size(138, 29);
            this.btnKhongDongY.TabIndex = 22;
            this.btnKhongDongY.Text = "KHÔNG ĐỒNG Ý";
            this.btnKhongDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhongDongY.UseVisualStyleBackColor = false;
            this.btnKhongDongY.Click += new System.EventHandler(this.btnKhongDongY_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.LightGreen;
            this.btnDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Image = global::GUI.Properties.Resources.Accept;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(26, 24);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(84, 29);
            this.btnDongY.TabIndex = 21;
            this.btnDongY.Text = "ĐỒNG Ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLichChieuCT);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(700, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LỊCH CHIẾU CHÍNH THỨC";
            // 
            // dgvLichChieuCT
            // 
            this.dgvLichChieuCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieuCT.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvLichChieuCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieuCT.Location = new System.Drawing.Point(4, 21);
            this.dgvLichChieuCT.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLichChieuCT.Name = "dgvLichChieuCT";
            this.dgvLichChieuCT.RowHeadersWidth = 51;
            this.dgvLichChieuCT.RowTemplate.Height = 24;
            this.dgvLichChieuCT.Size = new System.Drawing.Size(670, 138);
            this.dgvLichChieuCT.TabIndex = 0;
            // 
            // txtTimKiemDK
            // 
            this.txtTimKiemDK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDK.Location = new System.Drawing.Point(382, 24);
            this.txtTimKiemDK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemDK.Name = "txtTimKiemDK";
            this.txtTimKiemDK.Size = new System.Drawing.Size(157, 24);
            this.txtTimKiemDK.TabIndex = 5;
            // 
            // btnTimKiemDK
            // 
            this.btnTimKiemDK.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDK.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemDK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDK.Location = new System.Drawing.Point(285, 25);
            this.btnTimKiemDK.Name = "btnTimKiemDK";
            this.btnTimKiemDK.Size = new System.Drawing.Size(92, 26);
            this.btnTimKiemDK.TabIndex = 23;
            this.btnTimKiemDK.Text = "TÌM KIẾM";
            this.btnTimKiemDK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemDK.UseVisualStyleBackColor = false;
            this.btnTimKiemDK.Click += new System.EventHandler(this.btnTimKiemDK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLichChieuDK);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(700, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỊCH CHIẾU DỰ KIẾN";
            // 
            // dgvLichChieuDK
            // 
            this.dgvLichChieuDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieuDK.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvLichChieuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieuDK.Location = new System.Drawing.Point(4, 21);
            this.dgvLichChieuDK.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLichChieuDK.Name = "dgvLichChieuDK";
            this.dgvLichChieuDK.RowHeadersWidth = 51;
            this.dgvLichChieuDK.RowTemplate.Height = 24;
            this.dgvLichChieuDK.Size = new System.Drawing.Size(670, 138);
            this.dgvLichChieuDK.TabIndex = 1;
            // 
            // UC_LichChieu_AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LichChieu_AD";
            this.Size = new System.Drawing.Size(745, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieuDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKhongDongY;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLichChieuDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLichChieuCT;
        private System.Windows.Forms.ComboBox cbbTimKiemCT;
        private System.Windows.Forms.TextBox txtTimKiemCT;
        private System.Windows.Forms.Button btnTimKiemCT;
        private System.Windows.Forms.ComboBox cbbTimKiemDK;
        private System.Windows.Forms.TextBox txtTimKiemDK;
        private System.Windows.Forms.Button btnTimKiemDK;
    }
}
