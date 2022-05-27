﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLVT_GUI
{
   
    public partial class FrmCapNhatPhongChieuQLVT : Form
    {
        public delegate void Mydel(string maPhongChieu);
        public Mydel d{ get; set; }
        private List<ChiTietKhoVatTuView> dsVatTuTrongKho;
        private List<ChiTietPhongChieuView> dsVatTuCoSan;
        private List<ChiTietPhongChieuView> dsVatTuDaChon;
        private string maPhongChieu;
        private string maKho;
        public FrmCapNhatPhongChieuQLVT(string maPhongChieu)
        {
            this.maPhongChieu = maPhongChieu;
            dsVatTuTrongKho = ChiTietKhoVatTuBLL.Instance.GetAllChiTietKhoVatTuView();
            dsVatTuCoSan = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);
            dsVatTuDaChon = new List<ChiTietPhongChieuView>();
            InitializeComponent();
            setGUI(this.maPhongChieu);
        }
        private void setGUI(string maPhongChieu)
        {
            cbLoaiPhongChieu.Items.AddRange(LoaiPhongChieuBLL.Instance.GetCBBLoaiPhongChieu().ToArray());
            cbTinhTrang.Items.AddRange(TinhTrangPhongChieuBLL.Instance.GetCBBTinhTrangPhongChieu().ToArray());
            cbDonViTinh.Items.AddRange(ChiTietKhoVatTuBLL.Instance.GetAllDonViTinh().ToArray());
            if(maPhongChieu != "")
            {
                txtMaPhongChieu.Text = maPhongChieu;
                txtTenPhongChieu.Text = PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenPhong;
                foreach (CBBItem i in cbLoaiPhongChieu.Items)
                {
                    if (i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenLoaiPhongChieu)
                        cbLoaiPhongChieu.SelectedItem = i;
                }
                foreach (CBBItem i in cbTinhTrang.Items)
                {
                    if (i.Text == PhongChieuBLL.Instance.GetPhongChieuViewByMaPhongChieu(maPhongChieu).TenTinhTrang)
                        cbTinhTrang.SelectedItem = i;
                }
            }
            LoadDGVListVatTuKho();
            LoadDGVVatTuCoSan();
            this.maKho = dgvListVatTuKho.Rows[0].Cells["MaKho"].Value.ToString();

        }
        private void LoadDGVListVatTuKho()
        {
            dgvListVatTuKho.DataSource = null;
            dgvListVatTuKho.DataSource = dsVatTuTrongKho;
            dgvListVatTuKho.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvListVatTuKho.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvListVatTuKho.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvListVatTuKho.Columns["SoLuongSP"].HeaderText = "Số lượng";
            dgvListVatTuKho.Columns["MaKho"].Visible = false; 
        }
        private void LoadDGVVatTuCoSan()
        {
            dgvVatTuCoSan.DataSource = null;
            dgvVatTuCoSan.DataSource = dsVatTuCoSan;
            dgvVatTuCoSan.Columns["MaPhongChieu"].Visible = false;
            dgvVatTuCoSan.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvVatTuCoSan.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvVatTuCoSan.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvVatTuCoSan.Columns["SoLuong"].HeaderText = "Số lượng";
        }
        private void LoadDGVVatTuDaThem()
        {
            dgvVatTuDaChon.DataSource = null;
            dgvVatTuDaChon.DataSource = dsVatTuDaChon;
            dgvVatTuDaChon.Columns["MaPhongChieu"].Visible = false;
            dgvVatTuDaChon.Columns["MaVatTu"].HeaderText = "Mã vật tư";
            dgvVatTuDaChon.Columns["TenVatTu"].HeaderText = "Tên vật tư";
            dgvVatTuDaChon.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvVatTuDaChon.Columns["SoLuong"].HeaderText = "Số lượng";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát!, Dữ liệu chưa được lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
        }

        private void dgvListVatTuKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListVatTuKho.SelectedRows.Count == 1)
            {
                txtMaVatTu.Text = dgvListVatTuKho.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                txtTenVatTu.Text = dgvListVatTuKho.SelectedRows[0].Cells["TenVatTu"].Value.ToString();
                cbDonViTinh.SelectedItem = dgvListVatTuKho.SelectedRows[0].Cells["DonViTinh"].Value.ToString();
                numUpDowSoLuong.Value = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVatTu.Text == "")
                lbVatTu.Text = "Vật tư còn trống!";
            if (cbDonViTinh.SelectedItem == null)
                lbDonViTinh.Text = "Đơn vị tính còn trống!";
            if (numUpDowSoLuong.Value == 0)
                lbSoLuong.Text = "Số lượng còn trống!";
            if (txtMaVatTu.Text == "")
                lbVatTu.Text = "Vật tư còn trống!";
            else
            {
                {
                    int soLuongVTCanThem = 0;
                    var item = dsVatTuTrongKho.Find(x => x.MaVatTu == txtMaVatTu.Text && x.MaKho == maKho);
                    var soLuongMax = ChiTietKhoVatTuBLL.Instance.GetAllChiTietKhoVatTuView().Find(x => x.MaVatTu == txtMaVatTu.Text && x.MaKho == maKho);
                    var VTCanThemVaoPC = dsVatTuDaChon.Find(x => x.MaVatTu == txtMaVatTu.Text);
                    if (VTCanThemVaoPC != null)
                    {
                        soLuongVTCanThem = Convert.ToInt32(numUpDowSoLuong.Value) + VTCanThemVaoPC.SoLuong;
                    }
                    else
                        soLuongVTCanThem = Convert.ToInt32(numUpDowSoLuong.Value);
                    if (soLuongVTCanThem > soLuongMax.SoLuongSP)
                        lbSoLuong.Text = $"Số lượng vượt quá trong kho! Chọn tối đa {- soLuongVTCanThem + soLuongMax.SoLuongSP + Convert.ToInt32(numUpDowSoLuong.Value)} {soLuongMax.DonViTinh}";
                    if (txtMaVatTu.Text != "" &&
                        cbDonViTinh.SelectedItem != null &&
                        numUpDowSoLuong.Value != 0 && soLuongVTCanThem <= soLuongMax.SoLuongSP)
                    {
                        ChiTietPhongChieuDTO pc = new ChiTietPhongChieuDTO
                        {
                            MaVatTu = txtMaVatTu.Text,
                            DonViTinh = cbDonViTinh.SelectedItem.ToString(),
                            SoLuongSP = Convert.ToInt32(numUpDowSoLuong.Value),
                            MaPhongChieu = maPhongChieu
                        };
                        ChiTietPhongChieuBLL.Instance.ThemChiTietPhongChieuToDSVatTuCoSan(pc, ref dsVatTuDaChon);
                        int index = dsVatTuTrongKho.FindIndex(x => x == item);
                        dsVatTuTrongKho.Remove(item);
                        item.SoLuongSP -= pc.SoLuongSP;
                        if (item.SoLuongSP > 0)
                            dsVatTuTrongKho.Insert(index, item);
                        else
                        {
                            txtMaVatTu.Text = "";
                            txtTenVatTu.Text = "";
                            cbDonViTinh.SelectedItem = "";
                            numUpDowSoLuong.Value = 0;
                        }
                        LoadDGVListVatTuKho();
                        LoadDGVVatTuDaThem();
                    }
                }
            }
        }

        private void dgvVatTuDaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVatTuDaChon.SelectedRows.Count == 1)
            {
                string maVatTu = dgvVatTuDaChon.SelectedRows[0].Cells["MaVatTu"].Value.ToString();
                /////////////
                var item = dsVatTuDaChon.Find(x => x.MaVatTu == maVatTu);
                if(item!= null)
                {
                    dsVatTuDaChon.Remove(item);
                    var itemKho = dsVatTuTrongKho.Find(x => x.MaVatTu == maVatTu && x.MaKho == maKho);
                    int soluong = 0;
                    int index = -1;
                    if (itemKho != null)
                    {
                        soluong = itemKho.SoLuongSP + item.SoLuong;
                        index = dsVatTuTrongKho.FindIndex( x => x == itemKho);
                        dsVatTuTrongKho.Remove(itemKho);
                    }
                        
                    else
                        soluong = item.SoLuong;
                    ChiTietKhoVatTuView khoVT = new ChiTietKhoVatTuView()
                    {
                        TenVatTu = item.TenVatTu,
                        MaVatTu = item.MaVatTu,
                        DonViTinh = item.DonViTinh,
                        SoLuongSP = soluong,
                        MaKho = maKho,
                    };
                    if(index >= 0)
                        dsVatTuTrongKho.Insert(index, khoVT);
                    else
                        dsVatTuTrongKho.Add(khoVT);   
                }
                LoadDGVListVatTuKho();
                LoadDGVVatTuDaThem();
            }
        }

        private void txtMaVatTu_TextChanged(object sender, EventArgs e)
        {
            lbVatTu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dsVatTuDaChon.Count > 0 )
            {
                DialogResult result =  MessageBox.Show("Bạn muốn lưu?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    //foreach(var i in dsVatTuDaChon)
                    //{
                    //    var item = dsVatTuCoSan.Find(x => x.MaVatTu == i.MaVatTu);
                    //    if(item != null)
                    //    {

                    //    }    
                    //}    
                    dsVatTuDaChon.ForEach(x => ChiTietPhongChieuBLL.Instance.AddUpdateChiTietPhongChieu(x));
                  
                    ChiTietKhoVatTuBLL.Instance.AddUpDateChiTietKhoVatTu(dsVatTuTrongKho);
                    ChiTietKhoVatTuBLL.Instance.XoaChiTietKhoVatTu(dsVatTuTrongKho);
                    d(txtMaPhongChieu.Text);
                    this.Close();
                }
                    
            }
        }

     

     
        //private bool KiemTraThayDoiChiTietVatTuPhongChieu(List<ChiTietPhongChieuView> ds)
        //{
        //    List<ChiTietPhongChieuView> dsAllPC = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);
        //    if (ds.Count != dsAllPC.Count )
        //        return true;
        //    foreach(ChiTietPhongChieuView i in ds)
        //    {
        //       foreach(ChiTietPhongChieuView j in dsAllPC)
        //        {
        //            if(i.MaVatTu == j.MaVatTu && i.SoLuong != j.SoLuong)
        //                return true;
        //        }    
        //    }    
        //    return false;
                
        //}
        //public void Huy(List<ChiTietPhongChieuView> ds, ref List<ChiTietKhoVatTuView> dsKhoVT)
        //{
        //    List<ChiTietPhongChieuView> dsAllPC = ChiTietPhongChieuBLL.Instance.GetAllCTPhongChieuViewByMaPhongChieu(maPhongChieu);
        //    var dsKhongThayDoi = new List<ChiTietPhongChieuView>();
        //    foreach (var i in dsAllPC)
        //    {
        //        dsKhongThayDoi.Add(ds.Find(x => x.MaVatTu == i.MaVatTu && x.SoLuong == i.SoLuong && x.MaPhongChieu == i.MaPhongChieu));
        //    }
        //    foreach (var i in dsKhongThayDoi)
        //    {
        //        dsAllPC.Remove(i);
        //    }
        //    foreach (var i in dsAllPC)   // ds co thay doi ban dau
        //    {
        //        int soLuong = 0;
        //        var item = ds.Find(x => x.MaVatTu == i.MaVatTu && x.MaPhongChieu == i.MaPhongChieu);
        //        if (item != null)
        //        {
        //            soLuong = i.SoLuong - item.SoLuong;  // so luong bi giam 
        //        }
        //        else
        //            soLuong = i.SoLuong;
        //        var item1 = dsKhoVT.Find(x => x.MaVatTu == i.MaVatTu);
        //        if (item1 != null)
        //        {
        //            int index = dsKhoVT.FindIndex(x => x == item1);
        //            dsKhoVT.Remove(item1);
        //            item1.SoLuongSP -= soLuong;
        //            if (item1.SoLuongSP >= 0)
        //                dsKhoVT.Insert(index, item1);
        //        }
        //    }
        //}

        private void numUpDowSoLuong_ValueChanged(object sender, EventArgs e)
        {
            lbSoLuong.Text = "";
        }

        private void cbDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDonViTinh.Text = "";
        }

        private void numericUpDownSoLuongXoa_ValueChanged(object sender, EventArgs e)
        {
            lbSoLuongXoa.Text = "";
        }
    }
}
