﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class UC_DanhSachLichChieuDuKien_QLP : UserControl
    {
        public delegate void MyDel(Control c);
        public MyDel d;
        DataTable dtDanhSachLichChieuDuKien = new DataTable();
        public UC_DanhSachLichChieuDuKien_QLP()
        {
            InitializeComponent();
            SetDaTaTable();
            Reload();
        }
        UC_TaoLichChieu_QLP ucTLC = new UC_TaoLichChieu_QLP();
        public void SetDaTaTable()
        {
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phim");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Tên Phòng Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Mã Khung Giờ Chiếu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Bắt Đầu");
            dtDanhSachLichChieuDuKien.Columns.Add("Giờ Kết Thúc"); 
            dtDanhSachLichChieuDuKien.Columns.Add("Ngày Chiếu");
        }
        public void Reload(string TimKiem = "", string LoaiTimKiem = "")
        {
            dtDanhSachLichChieuDuKien.Rows.Clear();
            foreach (LichChieuViewDTO i in LichChieuViewBLL.Instance.GetLichChieuViewByTrangThai("1",TimKiem,LoaiTimKiem))
            {
                dtDanhSachLichChieuDuKien.Rows.Add(i.MaPhim,i.TenPhim,i.MaPhongChieu,i.TenPhongChieu,i.MaKhungGioChieu,i.GioBatDau.ToShortTimeString(),i.GioKetThuc.ToShortTimeString(),i.NgayChieu.ToShortDateString());
            }
            dGVDanhSachLichChieuDuKien.DataSource = dtDanhSachLichChieuDuKien;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phim"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Phòng Chiếu"].Visible = false;
            dGVDanhSachLichChieuDuKien.Columns["Mã Khung Giờ Chiếu"].Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Reload(txtTimKiem.Text, cBTimKiem.SelectedItem.ToString());
        }
    }
}
