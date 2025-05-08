using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV_DA
{
   public class ET_KetQua
    {
        private string _MaSV;
        private string _MaMon;
        private decimal _Diem;
        private string _HocKy;
        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public string MaMon { get => _MaMon; set => _MaMon = value; }
        public decimal Diem { get => _Diem; set => _Diem = value; }
        public string HocKy { get => _HocKy; set => _HocKy = value; }

        public ET_KetQua(string maSV, string maMon, decimal diem, string hocKy)
        {
            MaSV = maSV;
            MaMon = maMon;
            Diem = diem;
            HocKy = hocKy;
        }
    }
}
