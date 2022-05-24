﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChiTietPhieuPhimBLL
    {
        private static ChiTietPhieuPhimBLL instance;
        public static ChiTietPhieuPhimBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuPhimBLL();
                return instance;
            }
            private set { }
        }
        public List<ChiTietPhieuPhimDTO> GetAllChiTietPhieuPhim()
        {
            return ChiTietPhieuPhimDAL.Instance.GetAllChiTietPhieuPhim();
        }
        public List<ChiTietPhieuPhimDTO> GetListChiTietPhieuPhimByMaPhieu(string MaPhieu)
        {
            List<ChiTietPhieuPhimDTO> data = new List<ChiTietPhieuPhimDTO>();
            foreach(ChiTietPhieuPhimDTO i in GetAllChiTietPhieuPhim())
            {
                if(i.MaPhieu == MaPhieu)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<string> GetListMaPhieu(string MaLoaiPhieu = "")
        {
            List<string> data = new List<string>();
            foreach (ChiTietPhieuPhimDTO i in GetAllChiTietPhieuPhim())
            {
                if(PhieuBLL.Instance.GetPhieuByMaPhieu(i.MaPhieu).MaLoaiPhieu.Contains(MaLoaiPhieu))
                {
                    data.Add(i.MaPhieu);
                }
            }
            return data.Distinct().ToList();
        }
    }
}
