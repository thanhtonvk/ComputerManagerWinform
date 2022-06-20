using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.Model
{
    internal class CTHDB
    {
        private string mahdb, maps;
        private int soluong;

        public CTHDB(string mahdb, string maps, int soluong)
        {
            this.mahdb = mahdb;
            this.maps = maps;
            this.soluong = soluong;
        }

        public string Mahdb { get => mahdb; set => mahdb = value; }
        public string Maps { get => maps; set => maps = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
