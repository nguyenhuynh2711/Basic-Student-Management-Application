using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV_DA
{
    public class ET_MonHoc
    {
        private string _MaMon;
        private string _TenMon;
        private int _SoTinChi;
        private string _MaKhoa;

        public string MaMon { get => _MaMon; set => _MaMon = value; }
        public string TenMon { get => _TenMon; set => _TenMon = value; }
        public int SoTinChi { get => _SoTinChi; set => _SoTinChi = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }

        public ET_MonHoc(string maMon, string tenMon, int soTinChi, string maKhoa)
        {
            MaMon = maMon;
            TenMon = tenMon;
            SoTinChi = soTinChi;
            MaKhoa = maKhoa;
           
        }
    }
}
