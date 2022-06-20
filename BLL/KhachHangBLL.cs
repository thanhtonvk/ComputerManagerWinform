using Quan_ly_cua_hang.DAL;
using Quan_ly_cua_hang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.BLL
{
    internal class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();
        public void add(KhachHang kh)
        {
            dal.addKhachHang(kh);
        }
        public void update(KhachHang kh)
        {
            dal.updateKhachHang(kh);
        }
        public void delete(string makh)
        {
            dal.deleteKhachHang(makh);
        }
        public DataTable getAll()
        {
            return dal.getAllKH();
        }
        public DataTable timKiem(string tuKhoa)
        {
            return dal.timKiem(tuKhoa);
        }
    }
}
