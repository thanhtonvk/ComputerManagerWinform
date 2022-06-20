using Quan_ly_cua_hang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.BLL
{
    internal class NhanVienBLL
    {
        NhanVienDAO dal = new NhanVienDAO();
        public static NhanVien nv;
        public  List<NhanVien> getAllNhanVien()
        {
            return NhanVienDAO.getAllNhanVien();
        }
        public static bool DangNhap(string manv, string matkhau)
        {
           return NhanVienDAO.DangNhap(manv, matkhau);
        }
    }
}
