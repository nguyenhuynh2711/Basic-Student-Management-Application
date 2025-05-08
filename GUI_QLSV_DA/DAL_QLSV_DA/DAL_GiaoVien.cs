using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;

using ET_QLSV_DA;

namespace DAL_QLSV_DA
{
    public class DAL_GiaoVien
    {
        // Connection
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True");

        // Data Source=MAY121\SQLEXPRESS;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True
        // Method
        public DataTable layDSGiaoVien()
        {
            DataTable dtGiaoVien = new DataTable();
            try
            {
                // Mở kết nối 
                conn.Open();

                // Khởi tạo SQLcommand
                SqlCommand cmdGiaoVien = new SqlCommand("sp_layGiaoVien", conn);
                cmdGiaoVien.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dsSinhVien = new SqlDataAdapter(cmdGiaoVien);
                dsSinhVien.Fill(dtGiaoVien);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtGiaoVien;
        }

       
        public bool ThemGiaoVien(ET_GiaoVien et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdThemGV = new SqlCommand("sp_themGiaoVien", conn);
                cmdThemGV.CommandType = CommandType.StoredProcedure;

                // Tham Số
                SqlParameter parMaGV = new SqlParameter("@maGV", et.MaGV);
                cmdThemGV.Parameters.Add(parMaGV);

                SqlParameter parHoTenSV = new SqlParameter("@hoTen", et.HoTen);
                cmdThemGV.Parameters.Add(parHoTenSV);

                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", et.NgaySinh);
                cmdThemGV.Parameters.Add(parNgaySinh);

                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", et.GioiTinh);
                cmdThemGV.Parameters.Add(parGioiTinh);
           
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdThemGV.Parameters.Add(parMaKhoa);

                if (cmdThemGV.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return flag;
        }

       
        public bool XoaGiaoVien(ET_GiaoVien et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdXoaGV = new SqlCommand("sp_xoaGiaoVien", conn);
                cmdXoaGV.CommandType = CommandType.StoredProcedure;

                // Tham Số
                SqlParameter parMaGV = new SqlParameter("@maGV", et.MaGV);
                cmdXoaGV.Parameters.Add(parMaGV);

                if (cmdXoaGV.ExecuteNonQuery() > 0)
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
                // Đóng kết nối
                conn.Close();
            }
            return flag;
        }

        public DataTable LayGiaoVienAn()
        {
            DataTable dtGiaoVienAn = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdLayGiaoVienAn = new SqlCommand("sp_layGiaoVienAn", conn);
                cmdLayGiaoVienAn.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter daGiaoVienAn = new SqlDataAdapter(cmdLayGiaoVienAn);
                daGiaoVienAn.Fill(dtGiaoVienAn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtGiaoVienAn;
        }

        // Ẩn Giáo Viên
        public bool AnGiaoVien(ET_GiaoVien etgv)
        {
            bool flag = false;

            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdAnGiaoVien = new SqlCommand("sp_anGiaoVien", conn);
                cmdAnGiaoVien.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaGV = new SqlParameter("@maGV", etgv.MaGV);
                cmdAnGiaoVien.Parameters.Add(parMaGV);

                if (cmdAnGiaoVien.ExecuteNonQuery() > 0)
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

        // Khôi Phục Giáo Viên
        public bool KhoiPhucGiaoVien(ET_GiaoVien etgv)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdKhoiPhucGiaoVien = new SqlCommand("sp_khoiPhucGiaoVien", conn);
                cmdKhoiPhucGiaoVien.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaGV = new SqlParameter("@MaGV", etgv.MaGV);
                cmdKhoiPhucGiaoVien.Parameters.Add(parMaGV);

                if (cmdKhoiPhucGiaoVien.ExecuteNonQuery() > 0)
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

        public bool SuaGiaoVien(ET_GiaoVien et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdSuaGV = new SqlCommand("sp_suaGiaoVien", conn);
                cmdSuaGV.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaGV = new SqlParameter("@maGV", et.MaGV);
                cmdSuaGV.Parameters.Add(parMaGV);

                SqlParameter parHoTen = new SqlParameter("@hoTen", et.HoTen);
                cmdSuaGV.Parameters.Add(parHoTen);

                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", et.NgaySinh);
                cmdSuaGV.Parameters.Add(parNgaySinh);

                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", et.GioiTinh);
                cmdSuaGV.Parameters.Add(parGioiTinh);
             
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdSuaGV.Parameters.Add(parMaKhoa);

                if (cmdSuaGV.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemGiaoVien(string keyword)
        {
            DataTable dtGiaoVien = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdTimGiaoVien = new SqlCommand("sp_timGiaoVien", conn);
                cmdTimGiaoVien.CommandType = CommandType.StoredProcedure;
                cmdTimGiaoVien.Parameters.AddWithValue("@keyword", keyword);

                SqlDataAdapter dsGiaoVien = new SqlDataAdapter(cmdTimGiaoVien);
                dsGiaoVien.Fill(dtGiaoVien);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtGiaoVien;
        }

    }
}
