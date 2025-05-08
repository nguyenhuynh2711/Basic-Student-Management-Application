using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV_DA
{
    public class ET_SinhVien
    {
        private string _MaSV;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _MaKhoa;

        public ET_SinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string maKhoa)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaKhoa = maKhoa;
        }

        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
    }
}
