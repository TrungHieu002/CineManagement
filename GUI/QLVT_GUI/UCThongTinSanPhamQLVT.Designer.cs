﻿namespace GUI.QLVT_GUI
{
    partial class UCThongTinSanPhamQLVT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnListThucAn = new System.Windows.Forms.Panel();
            this.lblTitleListVatTu = new System.Windows.Forms.Label();
            this.dgvListVatTu = new System.Windows.Forms.DataGridView();
            this.cboSapXepVatTu = new System.Windows.Forms.ComboBox();
            this.btnSapXepVatTu = new System.Windows.Forms.Button();
            this.txtTimKiemVatTu = new System.Windows.Forms.TextBox();
            this.btnTimKiemVatTu = new System.Windows.Forms.Button();
            this.btnSapXepThucAn = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTitleListThucAn = new System.Windows.Forms.Label();
            this.dgvListThucAn = new System.Windows.Forms.DataGridView();
            this.pnListThucAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThucAn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListThucAn
            // 
            this.pnListThucAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListThucAn.Controls.Add(this.lblTitleListVatTu);
            this.pnListThucAn.Controls.Add(this.dgvListVatTu);
            this.pnListThucAn.Controls.Add(this.cboSapXepVatTu);
            this.pnListThucAn.Controls.Add(this.btnSapXepVatTu);
            this.pnListThucAn.Controls.Add(this.txtTimKiemVatTu);
            this.pnListThucAn.Controls.Add(this.btnTimKiemVatTu);
            this.pnListThucAn.Controls.Add(this.btnSapXepThucAn);
            this.pnListThucAn.Controls.Add(this.cboSapXep);
            this.pnListThucAn.Controls.Add(this.btnTimKiem);
            this.pnListThucAn.Controls.Add(this.txtTimKiem);
            this.pnListThucAn.Controls.Add(this.lblTitleListThucAn);
            this.pnListThucAn.Controls.Add(this.dgvListThucAn);
            this.pnListThucAn.Location = new System.Drawing.Point(16, 15);
            this.pnListThucAn.Name = "pnListThucAn";
            this.pnListThucAn.Size = new System.Drawing.Size(1314, 734);
            this.pnListThucAn.TabIndex = 10;
            // 
            // lblTitleListVatTu
            // 
            this.lblTitleListVatTu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListVatTu.Image = global::GUI.Properties.Resources.ToolDeXuat;
            this.lblTitleListVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListVatTu.Location = new System.Drawing.Point(518, 407);
            this.lblTitleListVatTu.Name = "lblTitleListVatTu";
            this.lblTitleListVatTu.Size = new System.Drawing.Size(240, 25);
            this.lblTitleListVatTu.TabIndex = 54;
            this.lblTitleListVatTu.Text = "DANH SÁCH VẬT TƯ";
            this.lblTitleListVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListVatTu
            // 
            this.dgvListVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListVatTu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListVatTu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVatTu.Location = new System.Drawing.Point(22, 452);
            this.dgvListVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListVatTu.Name = "dgvListVatTu";
            this.dgvListVatTu.RowHeadersWidth = 62;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListVatTu.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListVatTu.RowTemplate.Height = 28;
            this.dgvListVatTu.Size = new System.Drawing.Size(1263, 256);
            this.dgvListVatTu.TabIndex = 53;
            // 
            // cboSapXepVatTu
            // 
            this.cboSapXepVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXepVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXepVatTu.FormattingEnabled = true;
            this.cboSapXepVatTu.Items.AddRange(new object[] {
            "Tên Vật Tư",
            "Tên Kho",
            "Đơn Vị Tính",
            "Số Lượng",
            "Giá Tiền"});
            this.cboSapXepVatTu.Location = new System.Drawing.Point(985, 403);
            this.cboSapXepVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXepVatTu.Name = "cboSapXepVatTu";
            this.cboSapXepVatTu.Size = new System.Drawing.Size(288, 27);
            this.cboSapXepVatTu.TabIndex = 52;
            // 
            // btnSapXepVatTu
            // 
            this.btnSapXepVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXepVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXepVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXepVatTu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepVatTu.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXepVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepVatTu.Location = new System.Drawing.Point(822, 397);
            this.btnSapXepVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXepVatTu.Name = "btnSapXepVatTu";
            this.btnSapXepVatTu.Size = new System.Drawing.Size(123, 38);
            this.btnSapXepVatTu.TabIndex = 51;
            this.btnSapXepVatTu.Text = "    SẮP XẾP";
            this.btnSapXepVatTu.UseVisualStyleBackColor = false;
            this.btnSapXepVatTu.Click += new System.EventHandler(this.btnSapXepVatTu_Click);
            // 
            // txtTimKiemVatTu
            // 
            this.txtTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemVatTu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiemVatTu.Location = new System.Drawing.Point(181, 406);
            this.txtTimKiemVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemVatTu.Name = "txtTimKiemVatTu";
            this.txtTimKiemVatTu.Size = new System.Drawing.Size(263, 28);
            this.txtTimKiemVatTu.TabIndex = 50;
            this.txtTimKiemVatTu.Text = "Nhập Tên Vật Tư ";
            this.txtTimKiemVatTu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiemVatTu_MouseClick);
            // 
            // btnTimKiemVatTu
            // 
            this.btnTimKiemVatTu.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiemVatTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemVatTu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemVatTu.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiemVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemVatTu.Location = new System.Drawing.Point(35, 399);
            this.btnTimKiemVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemVatTu.Name = "btnTimKiemVatTu";
            this.btnTimKiemVatTu.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiemVatTu.TabIndex = 49;
            this.btnTimKiemVatTu.Text = "TÌM KIẾM";
            this.btnTimKiemVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemVatTu.UseVisualStyleBackColor = false;
            this.btnTimKiemVatTu.Click += new System.EventHandler(this.btnTimKiemVatTu_Click);
            // 
            // btnSapXepThucAn
            // 
            this.btnSapXepThucAn.BackColor = System.Drawing.Color.Cyan;
            this.btnSapXepThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXepThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXepThucAn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepThucAn.Image = global::GUI.Properties.Resources.Sort;
            this.btnSapXepThucAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepThucAn.Location = new System.Drawing.Point(822, 48);
            this.btnSapXepThucAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXepThucAn.Name = "btnSapXepThucAn";
            this.btnSapXepThucAn.Size = new System.Drawing.Size(123, 38);
            this.btnSapXepThucAn.TabIndex = 47;
            this.btnSapXepThucAn.Text = "    SẮP XẾP";
            this.btnSapXepThucAn.UseVisualStyleBackColor = false;
            this.btnSapXepThucAn.Click += new System.EventHandler(this.btnSapXepThucAn_Click);
            // 
            // cboSapXep
            // 
            this.cboSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSapXep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "Tên Thức Ăn",
            "Tên Kho",
            "Đơn Vị Tính",
            "Số Lượng",
            "Giá Tiền"});
            this.cboSapXep.Location = new System.Drawing.Point(973, 55);
            this.cboSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(300, 27);
            this.cboSapXep.TabIndex = 46;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.SearchIcon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(35, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 36);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiem.Location = new System.Drawing.Point(181, 54);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 28);
            this.txtTimKiem.TabIndex = 44;
            this.txtTimKiem.Text = "Nhập Tên Thức Ăn";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            // 
            // lblTitleListThucAn
            // 
            this.lblTitleListThucAn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleListThucAn.Image = global::GUI.Properties.Resources.FoodTitleDeXuat;
            this.lblTitleListThucAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleListThucAn.Location = new System.Drawing.Point(465, 52);
            this.lblTitleListThucAn.Name = "lblTitleListThucAn";
            this.lblTitleListThucAn.Size = new System.Drawing.Size(338, 25);
            this.lblTitleListThucAn.TabIndex = 43;
            this.lblTitleListThucAn.Text = "DANH SÁCH THỨC ĂN NHANH";
            this.lblTitleListThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListThucAn
            // 
            this.dgvListThucAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListThucAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvListThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListThucAn.Location = new System.Drawing.Point(22, 102);
            this.dgvListThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListThucAn.Name = "dgvListThucAn";
            this.dgvListThucAn.RowHeadersWidth = 62;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListThucAn.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvListThucAn.RowTemplate.Height = 28;
            this.dgvListThucAn.Size = new System.Drawing.Size(1263, 266);
            this.dgvListThucAn.TabIndex = 40;
            // 
            // UCThongTinSanPhamQLVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnListThucAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCThongTinSanPhamQLVT";
            this.Size = new System.Drawing.Size(1352, 766);
            this.pnListThucAn.ResumeLayout(false);
            this.pnListThucAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThucAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListThucAn;
        private System.Windows.Forms.Button btnSapXepThucAn;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTitleListThucAn;
        private System.Windows.Forms.DataGridView dgvListThucAn;
        private System.Windows.Forms.Button btnTimKiemVatTu;
        private System.Windows.Forms.TextBox txtTimKiemVatTu;
        private System.Windows.Forms.Button btnSapXepVatTu;
        private System.Windows.Forms.ComboBox cboSapXepVatTu;
        private System.Windows.Forms.DataGridView dgvListVatTu;
        private System.Windows.Forms.Label lblTitleListVatTu;
    }
}
