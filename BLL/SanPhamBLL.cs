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
    internal class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();
        public void add(SanPham sp)
        {
            dal.add(sp);
        }
        public void update(SanPham sp)
        {
            dal.update(sp);
        }
        public void delete(string masv)
        {
            dal.delete(masv);
        }
        public DataTable getAll()
        {
            return dal.getAll();
        }
        public DataTable timKiem(string tuKhoa)
        {
            return dal.timKiem(tuKhoa);
        }
    }
}
