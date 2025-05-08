using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm Thư Viện
using System.Data;
using System.Data.SqlClient;

using ET_QLSV_DA;

namespace DAL_QLSV_DA
{
    public class DAL_MonHoc
    {
        // Connection
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True");

        // Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True;Trust Server Certificate=True
        // Data Source=MAY121\SQLEXPRESS;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True
        // Method
        public DataTable LayDSMonHoc()
        {
            DataTable dtMonHoc = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdMonHoc = new SqlCommand("sp_MonHoc", conn);
                cmdMonHoc.CommandText = "sp_MonHoc";
                cmdMonHoc.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dsMonHoc = new SqlDataAdapter(cmdMonHoc);
                dsMonHoc.Fill(dtMonHoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            // Trả về bảng
            return dtMonHoc;
        }

        // Thêm MonHoc mới
        public bool ThemMonHoc(ET_MonHoc et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdThemMonHoc = new SqlCommand("sp_themMonHoc", conn);
                cmdThemMonHoc.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdThemMonHoc.Parameters.Add(parMaMon);

                SqlParameter parTenMon = new SqlParameter("@tenMon", et.TenMon);
                cmdThemMonHoc.Parameters.Add(parTenMon);

                SqlParameter parSoTinChi = new SqlParameter("@soTinChi", et.SoTinChi);
                cmdThemMonHoc.Parameters.Add(parSoTinChi);

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdThemMonHoc.Parameters.Add(parMaKhoa);

                // Thực thi
                if (cmdThemMonHoc.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        // Xóa 
        public bool XoaMonHoc(ET_MonHoc et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdXoaMonHoc = new SqlCommand("sp_xoaMonHoc", conn);
                cmdXoaMonHoc.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdXoaMonHoc.Parameters.Add(parMaMon);

                // Thực thi
                if (cmdXoaMonHoc.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        // lay Mon Hoc an
        public DataTable LayMonHocAn()
        {
            DataTable dtMonHocAn = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdLayMonHocAn = new SqlCommand("sp_layMonHocAn", conn);
                cmdLayMonHocAn.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter daMonHocAn = new SqlDataAdapter(cmdLayMonHocAn);
                daMonHocAn.Fill(dtMonHocAn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtMonHocAn;
        }

        // Ẩn Mon HOc
        public bool AnMonHoc(ET_MonHoc et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdAnMonHoc = new SqlCommand("sp_anMonHoc", conn);
                cmdAnMonHoc.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdAnMonHoc.Parameters.Add(parMaMon);

                if (cmdAnMonHoc.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        // Khôi Phục Mon Hoc
        public bool KhoiPhucMonHoc(ET_MonHoc et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdKhoiPhucMonHoc = new SqlCommand("sp_khoiPhucMonHoc", conn);
                cmdKhoiPhucMonHoc.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdKhoiPhucMonHoc.Parameters.Add(parMaMon);

                if (cmdKhoiPhucMonHoc.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        // Sửa 
        public bool SuaMonhoc(ET_MonHoc et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdSuaMonHoc= new SqlCommand("sp_suaMonHoc", conn);
                cmdSuaMonHoc.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdSuaMonHoc.Parameters.Add(parMaMon);

                SqlParameter parTenMon = new SqlParameter("@tenMon", et.TenMon);
                cmdSuaMonHoc.Parameters.Add(parTenMon);

                SqlParameter parSoTinChi = new SqlParameter("@soTinChi", et.SoTinChi);
                cmdSuaMonHoc.Parameters.Add(parSoTinChi);

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdSuaMonHoc.Parameters.Add(parMaKhoa);

                // Thực thi
                if (cmdSuaMonHoc.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        // Tìm Kiếm 
        public DataTable TimKiemMonHoc(string keyword)
        {
            DataTable dtMonHoc = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdTimMonHoc = new SqlCommand("sp_timMonHoc", conn);
                cmdTimMonHoc.CommandType = CommandType.StoredProcedure;

                cmdTimMonHoc.Parameters.AddWithValue("@keyword", keyword);

                SqlDataAdapter dsMonHoc = new SqlDataAdapter(cmdTimMonHoc);
                dsMonHoc.Fill(dtMonHoc);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtMonHoc;
        }


    }
}
