using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm
using DAL_QLSV_DA;
using ET_QLSV_DA;

namespace BUS_QLSV_DA
{
    public class BUS_Khoa
    {
        DAL_Khoa dalKhoa = new DAL_Khoa();

        // Lấy danh sách
        public DataTable layDSKhoa()
        {
            return dalKhoa.LayDSKhoa();
        }

        // Thêm Khoa
        public bool ThemKhoa(ET_Khoa etKhoa)
        {
            return dalKhoa.ThemKhoa(etKhoa);
        }

        // Xóa Khoa
        public bool XoaKhoa(ET_Khoa etKhoa)
        {
            return dalKhoa.XoaKhoa(etKhoa);
        }

        // Sửa Khoa
        public bool SuaKhoa(ET_Khoa etKhoa)
        {
            return dalKhoa.SuaKhoa(etKhoa);
        }

        // Tìm Khoa
        public DataTable TimKiemKhoa(string keyword)
        {
            return dalKhoa.TimKiemKhoa(keyword);
        }

        // Khôi Phục Khoa
        public bool KhoiPhucKhoa(ET_Khoa etKhoa)
        {
            return dalKhoa.KhoiPhucKhoa(etKhoa);
        }

        // Ẩn Khoa
        public bool AnKhoa (ET_Khoa etKhoa)
        {
            return dalKhoa.AnKhoa(etKhoa);
        }

        // Lấy Khoa Ẩn
        public DataTable LayKhoaAn()
        {
            return dalKhoa.LayKhoaAn();
        }
    }
}
