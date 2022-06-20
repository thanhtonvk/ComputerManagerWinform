using Quan_ly_cua_hang.Model;
using Quan_ly_cua_hang.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.DAL
{
    internal class SanPhamDAL
    {
        public void add(SanPham sp)
        {
            string query = string.Format("USP_THEMSP '{0}',N'{1}',N'{2}',N'{3}',{4}", sp.MaSP, sp.TenSP, sp.CauHinh, sp.Mau, sp.GiaBan);
            DBHelper.Execute(query);
        }
        public void update(SanPham sp)
        {
            string query = string.Format("USP_SUASP '{0}',N'{1}',N'{2}',N'{3}',{4}", sp.MaSP, sp.TenSP, sp.CauHinh, sp.Mau, sp.GiaBan);
            DBHelper.Execute(query);
        }
        public void delete(string masv)
        {
            string query = string.Format("USP_XOASP '{0}'", masv);
            DBHelper.Execute(query);
        }
        public DataTable getAll()
        {
            string query = "select * from sanpham";

            return DBHelper.getDataSet(query).Tables[0];
        }
        public DataTable timKiem(string tuKhoa)
        {
            string query = string.Format("USP_TIMKIEMSP '{0}'", tuKhoa);
            return DBHelper.getDataSet(query).Tables[0];
        }
    }
}
