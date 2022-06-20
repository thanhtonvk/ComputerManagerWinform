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
    internal class KhachHangDAL
    {
        public void addKhachHang(KhachHang kh)
        {
            string query = string.Format("USP_THEMKHACHHANG '{0}','{1}','{2}'", kh.MaKH, kh.TenKH, kh.SDT);
            DBHelper.Execute(query);
        }
        public void updateKhachHang(KhachHang kh)
        {
            string query = string.Format("USP_SUAKHACHHANG '{0}','{1}','{2}'", kh.MaKH, kh.TenKH, kh.SDT);
            DBHelper.Execute(query);
        }
        public void deleteKhachHang(string makh)
        {
            string query = string.Format("USP_XOAKHACHHANG '{0}'", makh.Trim());
            DBHelper.Execute(query);
        }
        public DataTable getAllKH()
        {
            string query = "SELECT * FROM VIEW_DSKHACHHANG";
            return DBHelper.getDataSet(query).Tables[0];
        }
        public DataTable timKiem(string tuKhoa)
        {
            string query = string.Format("USP_TIMKIEMKHACHHANG '{0}'", tuKhoa);
           return DBHelper.getDataSet(query).Tables[0];
        }
    }
}
