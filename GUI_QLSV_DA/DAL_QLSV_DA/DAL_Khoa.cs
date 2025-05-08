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
    public class DAL_Khoa
    {
        // Connection
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;;Integrated Security=True");

        // Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True;Trust Server Certificate=True
        // Data Source=MAY121\SQLEXPRESS;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True

        // Method
        public DataTable LayDSKhoa()
        {
            DataTable dtKhoa = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdKhoa = new SqlCommand("sp_Khoa", conn);
                cmdKhoa.CommandText = "sp_Khoa";
                cmdKhoa.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dsKhoa = new SqlDataAdapter(cmdKhoa);
                dsKhoa.Fill(dtKhoa);
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
            return dtKhoa;
        }

        // Thêm Khoa mới
        public bool ThemKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdThemKhoa = new SqlCommand("sp_themKhoa", conn);
                cmdThemKhoa.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdThemKhoa.Parameters.Add(parMaKhoa);

                SqlParameter parTenKhoa = new SqlParameter("@tenKhoa", et.TenKhoa);
                cmdThemKhoa.Parameters.Add(parTenKhoa);

                SqlParameter parDiaChiKhoa = new SqlParameter("@diaChi", et.DiaChi);
                cmdThemKhoa.Parameters.Add(parDiaChiKhoa);

                SqlParameter parSoDienThoaiKhoa = new SqlParameter("@dienThoai", et.DienThoai);
                cmdThemKhoa.Parameters.Add(parSoDienThoaiKhoa);

                // Thực thi
                if (cmdThemKhoa.ExecuteNonQuery() > 0)
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

        // Xóa Khoa bạn muốn
        public bool XoaKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdXoaKhoa = new SqlCommand("sp_xoaKhoa", conn);
                cmdXoaKhoa.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdXoaKhoa.Parameters.Add(parMaKhoa);

                // Thực thi
                if (cmdXoaKhoa.ExecuteNonQuery() > 0)
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

        // Lấy Khoa Ẩn
        public DataTable LayKhoaAn()
        {
            DataTable dtKhoaAn = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdLayKhoaAn = new SqlCommand("sp_layKhoaAn", conn);
                cmdLayKhoaAn.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter daKhoaAn = new SqlDataAdapter(cmdLayKhoaAn);
                daKhoaAn.Fill(dtKhoaAn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtKhoaAn;
        }

        // Ẩn Khoa
        public bool AnKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdAnKhoa = new SqlCommand("sp_anKhoa", conn);
                cmdAnKhoa.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdAnKhoa.Parameters.Add(parMaKhoa);

                if (cmdAnKhoa.ExecuteNonQuery() > 0)
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

        // Khôi Phục Khoa
        public bool KhoiPhucKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdKhoiPhucKhoa = new SqlCommand("sp_khoiPhucKhoa", conn);
                cmdKhoiPhucKhoa.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdKhoiPhucKhoa.Parameters.Add(parMaKhoa);

                if (cmdKhoiPhucKhoa.ExecuteNonQuery() > 0)
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

        // Sửa Thông Tin Khoa
        public bool SuaKhoa(ET_Khoa et)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SqlCommand
                SqlCommand cmdSuaKhoa = new SqlCommand("sp_suaKhoa", conn);
                cmdSuaKhoa.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", et.MaKhoa);
                cmdSuaKhoa.Parameters.Add(parMaKhoa);

                SqlParameter parTenKhoa = new SqlParameter("@tenKhoa", et.TenKhoa);
                cmdSuaKhoa.Parameters.Add(parTenKhoa);

                SqlParameter parDiaChiKhoa = new SqlParameter("@diaChi", et.DiaChi);
                cmdSuaKhoa.Parameters.Add(parDiaChiKhoa);

                SqlParameter parSoDienThoaiKhoa = new SqlParameter("@dienThoai", et.DienThoai);
                cmdSuaKhoa.Parameters.Add(parSoDienThoaiKhoa);

                // Thực thi
                if (cmdSuaKhoa.ExecuteNonQuery() > 0)
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

        // Tìm Kiếm Khoa theo Mã hoặc Tên
        public DataTable TimKiemKhoa(string keyword)
        {
            DataTable dtKhoa = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdTimKhoa = new SqlCommand("sp_timKiemKhoa", conn);
                cmdTimKhoa.CommandType = CommandType.StoredProcedure;

                cmdTimKhoa.Parameters.AddWithValue("@keyword", keyword);

                SqlDataAdapter dsKhoa = new SqlDataAdapter(cmdTimKhoa);
                dsKhoa.Fill(dtKhoa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtKhoa;
        }


    }
}
