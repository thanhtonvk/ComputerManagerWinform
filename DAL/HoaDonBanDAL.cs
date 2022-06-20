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
    internal class HoaDonBanDAL
    {
        public void add(HoaDonBan hdb)
        {
            string query = string.Format("USP_THEMHOADONBAN '{0}','{1}','{2}','{3}'", hdb.Mahdb, hdb.Ngayban, hdb.Manv, hdb.Makh);
            DBHelper.Execute(query);
        }
        public void addCTHD(CTHDB hd)
        {
            string query = string.Format("USP_THEMCHITIETHDB '{0}','{1}',{2}", hd.Mahdb, hd.Maps, 1);
            DBHelper.Execute(query);
        }
        public DataTable getAllCTHDB(string mahdb)
        {
            string query = string.Format("USP_CHITIETHDB '{0}'", mahdb);
            return DBHelper.getDataSet(query).Tables[0];
        }
    }
}
