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
    public class BUS_KetQua
    {

        DAL_KetQua dalKetQua = new DAL_KetQua();   

        public DataTable layDSKetQua()
        {
            return dalKetQua.LayDSKetQua();
        }

        public bool ThemKetQua(ET_KetQua etKetQua)
        {
            return dalKetQua.ThemKetQua(etKetQua);
        }

        public bool XoaKetQua(ET_KetQua etKetqua)
        {
            return dalKetQua.XoaKetQua(etKetqua);
        }

        public bool SuaKetQua(ET_KetQua etKetQua)
        {
            return dalKetQua.SuaKetQua(etKetQua);
        }

        public DataTable TimKiemKetQua(string keyword)
        {
            return dalKetQua.TimKiemKetQua(keyword);    
        }


        public bool KhoiPhucKetQua(ET_KetQua etKetQua)
        {
            return dalKetQua.KhoiPhucKetQua(etKetQua);
        }

       
        public bool AnKetQua(ET_KetQua etKetQua)
        {
            return dalKetQua.AnKetQua(etKetQua);
        }

       
        public DataTable LayKetQuaAn()
        {
            return dalKetQua.LayKetQuaAn();
        }

    }
}
