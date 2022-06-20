using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.Model
{
    internal class SanPham
    {

        private string maSP;
        private string tenSP;
        private string cauHinh;
        private string mau;
        private string giaBan;

        public SanPham(string maSP, string tenSP, string cauHinh, string mau, string giaBan)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.CauHinh = cauHinh;
            this.Mau = mau;
            this.GiaBan = giaBan;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string CauHinh { get => cauHinh; set => cauHinh = value; }
        public string Mau { get => mau; set => mau = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
    }
}
