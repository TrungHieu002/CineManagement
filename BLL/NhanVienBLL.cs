﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<NhanVienDTO> GetAllNhanVien(string txt = "")
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            foreach (NhanVienDTO i in NhanVienDAL.Instance.GetAllNhanVien())
            {
                if (i.TenNhanVien.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public NhanVienViewDTO GetNhanVienViewByNhanVienDTO(NhanVienDTO nhanVien)
        {
            string tenChucVu = "";
            foreach (ChucVuDTO i in ChucVuDAL.Instance.GetAllChucVu())
            {
                if (i.MaChucVu == nhanVien.MaChucVu)
                {
                    tenChucVu = i.TenChucVu;
                }
            }
            return new NhanVienViewDTO
            {
                MaNhanVien = nhanVien.MaNhanVien,
                TenNhanVien = nhanVien.TenNhanVien,
                NgaySinh = nhanVien.NgaySinh.ToString(),
                GioiTinh = nhanVien.GioiTinh,
                SoDienThoai = nhanVien.SoDienThoai,
                MaChinhSach = nhanVien.MaChinhSach,
                TenChucVu = tenChucVu
            };
        }
        public List<NhanVienViewDTO> GetAllNhanVienView()
        {
            List<NhanVienViewDTO> data = new List<NhanVienViewDTO>();
            foreach (NhanVienDTO i in GetAllNhanVien())
            {
                data.Add(GetNhanVienViewByNhanVienDTO(i));
            }
            return data;
        }
        public NhanVienDTO GetNhanVienByMaNhanVien(string maNhanVien)
        {
            List<NhanVienDTO> data = GetAllNhanVien();
            foreach(NhanVienDTO i in data)
            {
                if (i.MaNhanVien == maNhanVien)
                {
                    return i;
                }
            }
            return null;
        }
        public List<NhanVienDTO> GetNhanVienDGV(List<string> maNhanVien)
        {
            List<NhanVienDTO> data = new List<NhanVienDTO>();
            foreach (string i in maNhanVien)
            {
                data.Add(GetNhanVienByMaNhanVien(i));
            }
            return data;
        }
        public List<NhanVienViewDTO> GetNhanVienViewDGV(List<string> maNhanVien)
        {
            List<NhanVienViewDTO> data = new List<NhanVienViewDTO>();
            foreach (NhanVienDTO i in GetNhanVienDGV(maNhanVien))
            {
                data.Add(GetNhanVienViewByNhanVienDTO(i));
            }
            return data;
        }
        public bool CheckAddUpdateNhanVien(NhanVienDTO nhanVien)
        {
            bool add = true;
            foreach (NhanVienDTO i in NhanVienDAL.Instance.GetAllNhanVien())
            {
                if (i.MaNhanVien == nhanVien.MaNhanVien)
                {
                    add = false;
                    break;
                }
            }
            return add;
        }
        public void AddUpdateNhaCungCap(NhanVienDTO nhanVien)
        {
            if (CheckAddUpdateNhanVien(nhanVien))
            {
                NhanVienDAL.Instance.ThemNhanVien(nhanVien);
            }
            else
            {
                NhanVienDAL.Instance.CapNhatNhanVien(nhanVien);
            }
        }
        //public delegate bool CompareObj(object o1, object o2);
        //public List<NhanVienViewDTO> SortNhanVien(List<NhanVienViewDTO> now, string dkSort)
        //{
        //    if (dkSort == "Tên A->Z")
        //        return Sort(now, CompareTenNhanVienTang);
        //    if (dkSort == "Tên Z->A")
        //        return Sort(now, CompareTenNhanVienGiam);
        //    return null;
        //}
        //public static bool CompareTenNhanVienTang(object o1, object o2)
        //{
        //    return String.Compare(((NhanVienViewDTO)o1).TenNhanVien, ((NhanVienViewDTO)o2).TenNhanVien) > 0;
        //}
        //public static bool CompareTenNhanVienGiam(object o1, object o2)
        //{
        //    return String.Compare(((NhanVienViewDTO)o2).TenNhanVien, ((NhanVienViewDTO)o1).TenNhanVien) > 0;
        //}


        //public List<NhanVienViewDTO> Sort(List<NhanVienViewDTO> now, CompareObj cmp)
        //{
        //    List<NhanVienViewDTO> data = now;
        //    for (int i = 0; i < data.Count - 1; i++)
        //        for (int j = i + 1; j < data.Count; j++)
        //        {
        //            if (cmp(data[i], data[j]))
        //            {
        //                NhanVienViewDTO temp = data[i];
        //                data[i] = data[j];
        //                data[j] = temp;
        //            }
        //        }
        //    return data;
        //}

        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            return NhanVienDAL.Instance.KiemTraDangNhap(tenTaiKhoan, MD5(matKhau));
        }
        public string MD5(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
    }
}
