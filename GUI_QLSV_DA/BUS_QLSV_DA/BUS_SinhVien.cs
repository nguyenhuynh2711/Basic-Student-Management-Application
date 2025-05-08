using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

// Thêm
using DAL_QLSV_DA;
using ET_QLSV_DA;

namespace BUS_QLSV_DA
{
    public class BUS_SinhVien
    {
        DAL_SinhVien dalSinhVien = new DAL_SinhVien();   

        // Lấy Danh Sách
        public DataTable layDSSinhVien()
        {
            return dalSinhVien.layDSSinhVien();
        }

       // Thêm Sinh Viên
       public bool ThemSinhVien(ET_SinhVien etsv)
        {
            return dalSinhVien.ThemSinhVien(etsv);
        }

        // Xóa Sinh Viên
        public bool XoaSinhVIen(ET_SinhVien etsv)
        {
            return dalSinhVien.XoaSinhVien(etsv);
        }

        // Sửa Sinh Viên
        public bool SuaSinhVien(ET_SinhVien etsv)
        {
            return dalSinhVien.SuaSinhVien(etsv);
        }

        // Tìm kiếm Sinh Viên
        public DataTable TimKiemSinhVien(string keyword)
        {
            return dalSinhVien.TimKiemSinhVien(keyword);
        }

        // Khôi Phục Sinh Viên
        public bool KhoiPhucSinhVien(ET_SinhVien etsv)
        {
            return dalSinhVien.KhoiPhucSinhVien(etsv);
        }

        // Ẩn Sinh Viên
        public bool AnSinhVien(ET_SinhVien etsv)
        {
            return dalSinhVien.AnSinhVieen(etsv);
        }

        // Lấy Sinh Viên Ẩn
        public DataTable LaySinhVienAn()
        {
            return dalSinhVien.LaySinhVienAn();
        }
    }
}
