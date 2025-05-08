using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV_DA
{
    public class ET_Khoa
    {
        private string _MaKhoa;
        private string _TenKhoa;
        private string _DiaChi;
        private string _DienThoai;

        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public string TenKhoa { get => _TenKhoa; set => _TenKhoa = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string DienThoai { get => _DienThoai; set => _DienThoai = value; }

        public ET_Khoa(string maKhoa, string tenKhoa, string diaChi, string dienThoai)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }
    }
}
