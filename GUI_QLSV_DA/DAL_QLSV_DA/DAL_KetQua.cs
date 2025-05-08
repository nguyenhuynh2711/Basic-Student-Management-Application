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
    public class DAL_KetQua
    {
        // Connection
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True");

        // Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True;Trust Server Certificate=True
        // Data Source=MAY121\SQLEXPRESS;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True

        // Method
        public DataTable LayDSKetQua()
        {
            DataTable dtKetQua= new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdKetQua = new SqlCommand("sp_KetQua", conn);
                cmdKetQua.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dsKetQua = new SqlDataAdapter(cmdKetQua);
                dsKetQua.Fill(dtKetQua);
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
            return dtKetQua;
        }

        
        public bool ThemKetQua(ET_KetQua et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdThemKetQua= new SqlCommand("sp_themKetQua", conn);
                cmdThemKetQua.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV", et.MaSV);
                cmdThemKetQua.Parameters.Add(parMaSV);

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdThemKetQua.Parameters.Add(parMaMon);

                SqlParameter parDiem = new SqlParameter("@diem", et.Diem);
                cmdThemKetQua.Parameters.Add(parDiem);

                SqlParameter parHocKy = new SqlParameter("@hocKy", et.HocKy);
                cmdThemKetQua.Parameters.Add(parHocKy);

                // Thực thi
                if (cmdThemKetQua.ExecuteNonQuery() > 0)
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

        
        public bool XoaKetQua(ET_KetQua et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdXoaKetQua = new SqlCommand("sp_xoaKetQua", conn);
                cmdXoaKetQua.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV", et.MaSV);
                cmdXoaKetQua.Parameters.Add(parMaSV);

                SqlParameter parMaMH = new SqlParameter("@maMon", et.MaMon);
                cmdXoaKetQua.Parameters.Add(parMaMH);

                // Thực thi
                if (cmdXoaKetQua.ExecuteNonQuery() > 0)
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

        // lay Ket Qua an
        public DataTable LayKetQuaAn()
        {
            DataTable dtKetQuaAn = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdLayKetQuaAn = new SqlCommand("sp_layKetQuaAn", conn);
                cmdLayKetQuaAn.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter daKetQuaAn = new SqlDataAdapter(cmdLayKetQuaAn);
                daKetQuaAn.Fill(dtKetQuaAn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtKetQuaAn;
        }

        // Ẩn Ket Qua
        public bool AnKetQua(ET_KetQua et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdAnKetQua = new SqlCommand("sp_anKetQua", conn);
                cmdAnKetQua.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdAnKetQua.Parameters.Add(parMaMon);
                SqlParameter parMaSV = new SqlParameter("@maSV", et.MaSV);
                cmdAnKetQua.Parameters.Add(parMaSV);

                if (cmdAnKetQua.ExecuteNonQuery() > 0)
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

        // Khôi Phục Ket Qua
        public bool KhoiPhucKetQua(ET_KetQua et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdKhoiPhucKetQua = new SqlCommand("sp_khoiPhucKetQua", conn);
                cmdKhoiPhucKetQua.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdKhoiPhucKetQua.Parameters.Add(parMaMon);
                SqlParameter parMaSV = new SqlParameter("@maSV", et.MaSV);
                cmdKhoiPhucKetQua.Parameters.Add(parMaSV);

                if (cmdKhoiPhucKetQua.ExecuteNonQuery() > 0)
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

        public bool SuaKetQua(ET_KetQua et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdSuaKetQua = new SqlCommand("sp_suaKetQua", conn);
                cmdSuaKetQua.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV", et.MaSV);
                cmdSuaKetQua.Parameters.Add(parMaSV);

                SqlParameter parMaMon = new SqlParameter("@maMon", et.MaMon);
                cmdSuaKetQua.Parameters.Add(parMaMon);

                SqlParameter parDiem = new SqlParameter("@diem", et.Diem);
                cmdSuaKetQua.Parameters.Add(parDiem);

                SqlParameter parHocKy = new SqlParameter("@hocKy", et.HocKy);
                cmdSuaKetQua.Parameters.Add(parHocKy);

                // Thực thi
                if (cmdSuaKetQua.ExecuteNonQuery() > 0)
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

        
        public DataTable TimKiemKetQua(string keyword)
        {
            DataTable dtKetQua = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdTimKetQua = new SqlCommand("sp_timKetQua", conn);
                cmdTimKetQua.CommandType = CommandType.StoredProcedure;

                cmdTimKetQua.Parameters.AddWithValue("@keyword", keyword);

                SqlDataAdapter dsKetQua = new SqlDataAdapter(cmdTimKetQua);
                dsKetQua.Fill(dtKetQua);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtKetQua;
        }


    }
}
