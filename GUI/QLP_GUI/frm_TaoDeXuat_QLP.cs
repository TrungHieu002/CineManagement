﻿using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.QLP_GUI
{
    public partial class frm_TaoDeXuat_QLP : Form
    {
        DataTable dtDeXuatPhim = new DataTable();
        DataTable dtDanhSachPhim = new DataTable();
        NhanVienDTO nhanvien = new NhanVienDTO();
        public frm_TaoDeXuat_QLP(NhanVienDTO nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            SetDataTable();
            Reload();
            btnChinhSua.Visible = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
        }
        public void Reload(string TenPhim = "", string LoaiTimKiem = "Tên Phim")
        {
            dtDanhSachPhim.Rows.Clear();
            foreach (PhimViewDTO i in PhimBLL.Instance.GetPhimViews(TenPhim, LoaiTimKiem))
            {
                dtDanhSachPhim.Rows.Add(i.MaPhim, i.TenPhim, i.ThoiLuong, i.QuocGia, i.NamSanXuat.ToShortDateString(), i.TenHangSanXuatPhim, i.DoTuoiXem, i.TheLoai);
            }
            dGVDanhSachPhim.DataSource = dtDanhSachPhim;
        }

        public void SetDataTable()
        {
            dtDanhSachPhim.Columns.Add("Mã Phim");
            dtDanhSachPhim.Columns.Add("Tên Phim");
            dtDanhSachPhim.Columns.Add("Thời Lượng");
            dtDanhSachPhim.Columns.Add("Quốc Gia");
            dtDanhSachPhim.Columns.Add("Năm Sản Xuất");
            dtDanhSachPhim.Columns.Add("Tên Hãng Sản Xuất Phim");
            dtDanhSachPhim.Columns.Add("Độ Tuổi Xem");
            dtDanhSachPhim.Columns.Add("Thể Loại");
            dtDeXuatPhim.Columns.Add("Mã Phim");
            dtDeXuatPhim.Columns.Add("Tên Phim");
            dtDeXuatPhim.Columns.Add("Số Lượng");
            dtDeXuatPhim.Columns.Add("Đơn Vị Tính");
            dtDeXuatPhim.Columns.Add("Nội Dung");
        }

        public bool KiemTraTonTaiPhim(string MaPhim)
        {
            for (int i = 0; i < dGVDeXuatPhim.Rows.Count; i++)
            {
                if (dGVDeXuatPhim.Rows[i].Cells["Mã Phim"].Value.ToString() == MaPhim)
                {
                    MessageBox.Show("Phim này đã được đề xuất");
                    return true;
                }
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa lưu, xác nhận thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }

        public bool KiemTraTinhDungDang()
        {
            bool kt = true;
            if (txtMaPhim.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phim");
                kt = false;
            }
            if (nUDSoLuong.Text == "0")
            {
                lbSoLuong.Text = "Vui lòng nhập số lượng";
                kt = false;
            }
            else
            {
                lbSoLuong.Text = "";
            }
            if (txtNoiDung.Text == "")
            {
                lbNoiDung.Text = "Vui lòng nhập nội dung đề xuất";
                kt = false;
            }
            else
            {
                lbNoiDung.Text = "";
            }
            if (cBDonViTinh.SelectedIndex < 0)
            {
                lbDonViTinh.Text = "Vui lòng chọn đơn vị tính";
                kt = false;
            }
            else
            {
                lbDonViTinh.Text = "";
            }
            return kt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTinhDungDang() == true)
            {
                if (KiemTraTonTaiPhim(txtMaPhim.Text) == false)
                {
                    foreach (DataGridViewRow i in dGVDanhSachPhim.SelectedRows)
                    {
                        dtDeXuatPhim.Rows.Add(txtMaPhim.Text, PhimBLL.Instance.GetPhimByMaPhim(txtMaPhim.Text).TenPhim, nUDSoLuong.Text, cBDonViTinh.SelectedItem.ToString(), txtNoiDung.Text);
                    }
                    dGVDeXuatPhim.DataSource = dtDeXuatPhim;
                }
                txtNoiDung.Text = "";
                nUDSoLuong.Text = "0";
                cBDonViTinh.Text = "";
                txtMaPhim.Text = "";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTinhDungDang() == true)
            {
                lbDonViTinh.Text = "";
                dGVDeXuatPhim.CurrentRow.Cells["Số Lượng"].Value = nUDSoLuong.Text;
                dGVDeXuatPhim.CurrentRow.Cells["Nội Dung"].Value = txtNoiDung.Text;
                dGVDeXuatPhim.CurrentRow.Cells["Đơn Vị Tính"].Value = cBDonViTinh.SelectedItem.ToString();
            }
            txtNoiDung.Text = "";
            nUDSoLuong.Text = "0";
            cBDonViTinh.Text = "";
            btnThem.Visible = true;
            btnChinhSua.Visible = false;
            dGVDeXuatPhim.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void dGVDeXuatPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVDeXuatPhim.SelectedRows.Count > 1)
            {
                MessageBox.Show("Số dòng chỉnh sửa không vượt quá 1");
            }
            else
            {
                txtMaPhim.Text = dGVDeXuatPhim.CurrentRow.Cells["Mã Phim"].Value.ToString();
                txtMaPhim.Enabled = false;
                nUDSoLuong.Text = dGVDeXuatPhim.CurrentRow.Cells["Số Lượng"].Value.ToString();
                txtNoiDung.Text = dGVDeXuatPhim.CurrentRow.Cells["Nội Dung"].Value.ToString();
                cBDonViTinh.Text = dGVDeXuatPhim.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
            }
            btnThem.Visible = false;
            btnChinhSua.Visible = true;
            dGVDeXuatPhim.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dGVDeXuatPhim.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Mời chọn dòng để xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác Nhận Xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.OK)
                    foreach (DataGridViewRow i in dGVDeXuatPhim.SelectedRows)
                    {
                        dGVDeXuatPhim.Rows.RemoveAt(i.Index);
                    }
            }
            if (dGVDeXuatPhim.Rows.Count == 0)
            {
                btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                DeXuatBLL.Instance.LuuDeXuat(nhanvien.MaNhanVien, DateTime.Now, "LDX01");
                string MaDeXuat = DeXuatBLL.Instance.GetMaDeXuatAddNew();
                string MaPhim = "";
                string NoiDung = "";
                string DonViTinh = "";
                int SoLuong;
                for (int i = 0; i < dGVDeXuatPhim.Rows.Count; i++)
                {
                    MaPhim = dGVDeXuatPhim.Rows[i].Cells["Mã Phim"].Value.ToString();
                    NoiDung = dGVDeXuatPhim.Rows[i].Cells["Nội Dung"].Value.ToString();
                    DonViTinh = dGVDeXuatPhim.Rows[i].Cells["Đơn Vị Tính"].Value.ToString();
                    SoLuong = Convert.ToInt32(dGVDeXuatPhim.Rows[i].Cells["Số Lượng"].Value.ToString());
                    ChiTietDeXuatPhimBLL.Instance.LuuChiTietDeXuatPhim(MaDeXuat, MaPhim, NoiDung, DonViTinh, SoLuong, "1");
                }
                this.Close();
            }
        }

        private void dGVDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Visible == true)
            {
                if (dGVDanhSachPhim.SelectedRows.Count == 1)
                {
                    txtMaPhim.Text = dGVDanhSachPhim.SelectedRows[0].Cells["Mã Phim"].Value.ToString();
                    btnThem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Chỉ chọn được duy nhất 1 dòng");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Reload(txtTimKiem.Text);
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            frm_DeXuatPhim frmDXP = new frm_DeXuatPhim();
            frmDXP.ShowDialog();
            Reload();
        }
    }
}
