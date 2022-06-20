using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.Model
{
    internal class HoaDonBan
    {
        // string query = string.Format("USP_THEMHOADONBAN '{0}','{1}','{2}','{3}'", tb_mahdb.Text, DateTime.Now.ToString("yyyy-MM-dd"), NhanVienDAO.nv.Manv, makh);
        private string mahdb, ngayban, manv, makh;

        public HoaDonBan(string mahdb, string ngayban, string manv, string makh)
        {
            this.mahdb = mahdb;
            this.ngayban = ngayban;
            this.manv = manv;
            this.makh = makh;
        }

        public string Mahdb { get => mahdb; set => mahdb = value; }
        public string Ngayban { get => ngayban; set => ngayban = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Makh { get => makh; set => makh = value; }
    }
}
