using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm thư viện
using System.Data;
using System.Data.SqlClient;

using ET_QLSV_DA;

//Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True 

namespace DAL_QLSV_DA
{
    public class DAL_SinhVien
    {
        // Connection
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True");

        // Data Source=MAY121\\SQLEXPRESS;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True
        // Data Source=LAPTOP-C6N5JQBP;Initial Catalog=Huynh_Danh_QuanLySinhVien_LTUD;Integrated Security=True
        // Method
        public DataTable layDSSinhVien()
        {
            DataTable dtSinhVien = new DataTable();

            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmddsSinhVien = new SqlCommand("sp_laySinhVien", conn);
                cmddsSinhVien.CommandType = CommandType.StoredProcedure;

                // Khởi tạo SQLDataAdapter
                SqlDataAdapter dsSinhVien = new SqlDataAdapter(cmddsSinhVien);
                dsSinhVien.Fill(dtSinhVien);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                // đóng kết nối
                conn.Close();
            }
            return dtSinhVien;
        }

        // Thêm Sinh Viên
        public bool ThemSinhVien(ET_SinhVien etsv)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdThemSV = new SqlCommand("sp_themSinhVien", conn);
                cmdThemSV.CommandType = CommandType.StoredProcedure;

                // Tham Số
                SqlParameter parMaSV = new SqlParameter("@maSV",etsv.MaSV);
                cmdThemSV.Parameters.Add(parMaSV);

                SqlParameter parHoTenSV = new SqlParameter("@hoTen", etsv.HoTen);
                cmdThemSV.Parameters.Add(parHoTenSV);

                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", etsv.NgaySinh);
                cmdThemSV.Parameters.Add(parNgaySinh);

                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", etsv.GioiTinh);
                cmdThemSV.Parameters.Add(parGioiTinh);

                SqlParameter parDiaChi = new SqlParameter("@diaChi",etsv.DiaChi);
                cmdThemSV.Parameters.Add(parDiaChi);

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", etsv.MaKhoa);
                cmdThemSV.Parameters.Add(parMaKhoa);

                if(cmdThemSV.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch(Exception ex)
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

        // Xóa Sinh Viên
        public bool XoaSinhVien(ET_SinhVien etsv)
        {
            bool flag = false;

            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdThemSV = new SqlCommand("sp_themSinhVien",conn);
                cmdThemSV.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV",etsv.MaSV);
                cmdThemSV.Parameters.Add(parMaSV);

                if (cmdThemSV.ExecuteNonQuery() > 0)
                {
                    flag= true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close ();
            }
            return flag;
        }

        // Lấy Danh Sach Sinh Viên bị ẩn
        public DataTable LaySinhVienAn()
        {
            DataTable dtSinhVienAn = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdLaySinhVienAn = new SqlCommand("sp_laySinhVienAn", conn);
                cmdLaySinhVienAn.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter daSinhVienAn = new SqlDataAdapter(cmdLaySinhVienAn);
                daSinhVienAn.Fill(dtSinhVienAn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVienAn;
        }

        // Ẩn Sinh Viên
        public bool AnSinhVieen(ET_SinhVien etsv)
        {
            bool flag = false;

            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdAnSV = new SqlCommand("sp_anSinhVien", conn);
                cmdAnSV.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV", etsv.MaSV);
                cmdAnSV.Parameters.Add(parMaSV);

                if (cmdAnSV.ExecuteNonQuery() > 0)
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

        // Khôi Phục Sinh Viên
        public bool KhoiPhucSinhVien(ET_SinhVien etsv)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmdKhoiPhucSinhVien = new SqlCommand("sp_khoiPhucSinhVien", conn);
                cmdKhoiPhucSinhVien.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaSV = new SqlParameter("@maSV", etsv.MaSV);
                cmdKhoiPhucSinhVien.Parameters.Add(parMaSV);

                if (cmdKhoiPhucSinhVien.ExecuteNonQuery() > 0)
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

        // Sửa Sinh Viên
        public bool SuaSinhVien(ET_SinhVien etsv)
        {
            bool flag = false;
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdSuaSV = new SqlCommand("sp_suaSinhVien", conn);
                cmdSuaSV.CommandType = CommandType.StoredProcedure;

                // Tham số
                SqlParameter parMaSV = new SqlParameter("@maSV", etsv.MaSV);
                cmdSuaSV.Parameters.Add(parMaSV);

                SqlParameter parHoTen = new SqlParameter("@hoTen", etsv.HoTen);
                cmdSuaSV.Parameters.Add(parHoTen);

                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", etsv.NgaySinh);
                cmdSuaSV.Parameters.Add(parNgaySinh);

                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", etsv.GioiTinh);
                cmdSuaSV.Parameters.Add(parGioiTinh);

                SqlParameter parDiaChi = new SqlParameter("@diaChi", etsv.DiaChi);
                cmdSuaSV.Parameters.Add(parDiaChi);

                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", etsv.MaKhoa);
                cmdSuaSV.Parameters.Add(parMaKhoa);

                if (cmdSuaSV.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        // Tìm Kiếm Sinh Viên
        public DataTable TimKiemSinhVien(string keyword)
        {
            DataTable dtTimKiem = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo SQLCommand
                SqlCommand cmdTimKiemSV = new SqlCommand("sp_timKiemSinhVien", conn);
                cmdTimKiemSV.CommandType = CommandType.StoredProcedure;

                cmdTimKiemSV.Parameters.AddWithValue("@keyword", keyword);

                // Khởi tạo SQLDataAdapter
                SqlDataAdapter dsSinhVien = new SqlDataAdapter(cmdTimKiemSV);
                dsSinhVien.Fill(dtTimKiem);
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                // đóng kết nối
                conn.Close();
            }
            return dtTimKiem;
        }

    }
}
