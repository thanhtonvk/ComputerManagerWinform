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
    internal class HoaDonBanBLL
    {
        HoaDonBanDAL dal = new HoaDonBanDAL();
        public void add(HoaDonBan hdb)
        {
           dal.add(hdb);
        }
        public void addCTHD(CTHDB hd)
        {
           dal.addCTHD(hd);
        }
        public DataTable getAllCTHDB(string mahdb)
        {
           return dal.getAllCTHDB(mahdb);
        }
    }
}
