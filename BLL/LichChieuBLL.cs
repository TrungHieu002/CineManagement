﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class LichChieuBLL
    {
        private static LichChieuBLL instance;
        public static LichChieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichChieuBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<LichChieuDTO> GetAllLichChieu()
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            foreach(LichChieuDTO i in LichChieuDAL.Instance.GetAllLichChieu())
            {
                data.Add(i);
            }
            return data;
        }
        public LichChieuViewDTO GetLichChieuViewByLichChieuDTO(LichChieuDTO lichChieu)
        {
            string tenPhong = "";
            string tenkhunggio = "";
            string TGBD = "";
            string TGKT = "";
            foreach (PhongChieuDTO i in PhongChieuDAL.Instance.GetAllPhongChieu())
            {
                if (i.MaPhongChieu == lichChieu.MaPhongChieu)
                {
                    tenPhong = i.TenPhong;
                }
            }
            foreach (KhungGioChieuDTO i in KhungGioChieuDAL.Instance.GetAllKhungGioChieu())
            {
                if (i.MaKhungGioChieu == lichChieu.MaKhungGioChieu)
                {
                    tenkhunggio = i.TenKhungGio;
                    TGBD = i.TGBatDau.ToString();
                    TGKT = i.TGKetThuc.ToString();
                }
            }
            return new LichChieuViewDTO
            {
                MaPhim = lichChieu.MaPhim,
                TenPhongChieu = tenPhong,
                TenKhungGio = tenkhunggio,
                //GioBatDau = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGBatDau,
               // GioKetThuc = KhungGioChieuBLL.Instance.GetKhungGioChieuByMaKGC(i.MaKhungGioChieu).TGKetThuc,
               // NgayChieu = i.NgayChieu
            };
        }
        public List<LichChieuViewDTO> GetAllLichChieuView()
        {
            List<LichChieuViewDTO> data = new List<LichChieuViewDTO>();
            foreach (LichChieuDTO i in GetAllLichChieu())
            {
                data.Add(GetLichChieuViewByLichChieuDTO(i));
            }
            return data;
        }
        public List<LichChieuDTO> GetListLichChieuByTrangThai(bool TrangThai)
        {
            List<LichChieuDTO> data = new List<LichChieuDTO>();
            foreach(LichChieuDTO i in GetAllLichChieu())
            {
                if(i.TrangThai == TrangThai)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<LichChieuViewDTO> TimTheoMaPhim(string maPhim)
        {
            List<LichChieuViewDTO> data = new List<LichChieuViewDTO>();
            foreach (LichChieuDTO i in LichChieuDAL.Instance.TimTheoMa(maPhim))
            {
                data.Add(GetLichChieuViewByLichChieuDTO(i));
            }
            return data;
        }
        public string KiemTraLichChieu(string MaPhim,string MaKhungGioChieu, string MaPhongChieu, DateTime NgayChieu)
        {
            foreach(LichChieuDTO i in GetAllLichChieu())
            {
                if (i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu && i.TrangThai == true)
                    return "Tồn tại một lịch chiếu dùng phòng chiếu cùng thời điểm";
                if (i.MaPhim == MaPhim && i.NgayChieu.Day == NgayChieu.Day && i.NgayChieu.Month == NgayChieu.Month && i.NgayChieu.Year == NgayChieu.Year && i.MaKhungGioChieu == MaKhungGioChieu && i.MaPhongChieu == MaPhongChieu)
                    return "Lịch chiếu đã được tạo";
            }
            return "";
        }
        public void LuuLichChieu(string MaPhim, string MaKhungGioChieu, string MaPhongChieu, bool TrangThai, DateTime NgayChieu)
        {
            LichChieuDAL.Instance.LuuLichChieu(MaPhim, MaKhungGioChieu, MaPhongChieu, TrangThai, NgayChieu);
        }
    }
}
