using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL_QLSV_DA;
using ET_QLSV_DA;

namespace BUS_QLSV_DA
{
    public class BUS_GiaoVien
    {
        DAL_GiaoVien dalGiaoVien = new DAL_GiaoVien();

        // Lấy Danh Sách
        public DataTable layDSGiaoVien()
        {
            return dalGiaoVien.layDSGiaoVien();
        }

        // Thêm Sinh Viên
        public bool ThemGiaoVien(ET_GiaoVien et)
        {
            return dalGiaoVien.ThemGiaoVien(et);
        }

        // Xóa Sinh Viên
        public bool XoaGiaoVien(ET_GiaoVien et)
        {
            return dalGiaoVien.XoaGiaoVien(et);
        }

        // Sửa Sinh Viên
        public bool SuaGiaoVien(ET_GiaoVien et)
        {
            return dalGiaoVien.SuaGiaoVien(et);
        }

        // Tìm kiếm Sinh Viên
        public DataTable TimKiemGiaoVien(string keyword)
        {
            return dalGiaoVien.TimKiemGiaoVien(keyword);
        }

        // Khôi Phục Giáo Viên
        public bool KhoiPhucGiaoVien(ET_GiaoVien etgv)
        {
            return dalGiaoVien.KhoiPhucGiaoVien(etgv);
        }

        // Ẩn Giáo Viên
        public bool AnGiaoVien(ET_GiaoVien etgv)
        {
            return dalGiaoVien.AnGiaoVien(etgv);
        }

        // Lấy Giáo Viên Ẩn
        public DataTable LayGiaoVienAn()
        {
            return dalGiaoVien.LayGiaoVienAn();
        }
    }
}
