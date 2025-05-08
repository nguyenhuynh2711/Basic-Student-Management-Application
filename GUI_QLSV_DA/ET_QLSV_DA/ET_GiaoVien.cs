using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSV_DA
{
    public class ET_GiaoVien
    {
        private string _MaGV;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _MaKhoa;

        public ET_GiaoVien(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh, string maKhoa)
        {
            MaGV = maGV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
       
            MaKhoa = maKhoa;
        }

        public string MaGV { get => _MaGV; set => _MaGV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
    }
}
