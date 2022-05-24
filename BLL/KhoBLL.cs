﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoBLL
    {
        private static KhoBLL instance;
        public static KhoBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoBLL();
                }
                return instance;
            }
            private set { }
        }
        public List<KhoDTO> GetAllKho()
        {
            return KhoDAL.Instance.GetAllKho();
        }
        public KhoDTO GetKhoByMaKho(string MaKho)
        {
            foreach (KhoDTO i in KhoDAL.Instance.GetAllKho())
            {
                if (i.MaKho == MaKho)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
