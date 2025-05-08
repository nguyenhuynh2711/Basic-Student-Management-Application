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
    public class BUS_MonHoc
    {
        DAL_MonHoc dalMonHoc = new DAL_MonHoc();

        // Lấy danh sách
        public DataTable layDSMonHoc()
        {
            return dalMonHoc.LayDSMonHoc();
        }

        // Thêm Khoa
        public bool ThemMonHoc(ET_MonHoc etMonHoc)
        {
            return dalMonHoc.ThemMonHoc(etMonHoc);
        }

        // Xóa Khoa
        public bool XoaMonHoc(ET_MonHoc etMonHoc)
        {
            return dalMonHoc.XoaMonHoc(etMonHoc);
        }

        // Sửa Khoa
        public bool SuaMonHoc(ET_MonHoc etMonHoc)
        {
            return dalMonHoc.SuaMonhoc(etMonHoc);
        }

        // Tìm Khoa
        public DataTable TimKiemMonHoc(string keyword)
        {
            return dalMonHoc.TimKiemMonHoc(keyword);
        }

        // Khôi Phục Mon hoc
        public bool KhoiPhucMonHoc(ET_MonHoc etMonHoc)
        {
            return dalMonHoc.KhoiPhucMonHoc(etMonHoc);
        }

        // Ẩn Mon hoc
        public bool AnMonHoc(ET_MonHoc etMonHoc)
        {
            return dalMonHoc.AnMonHoc(etMonHoc);
        }

        // Lấy Mon hoc Ẩn
        public DataTable LayMonHocAn()
        {
            return dalMonHoc.LayMonHocAn();
        }
    }
}
