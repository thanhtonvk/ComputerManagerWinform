using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_ly_cua_hang.BLL;
using Quan_ly_cua_hang.Model;
using Quan_ly_cua_hang.Utils;

namespace Quan_ly_cua_hang.GUI
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            loadDataSanPham();
            loadDuLieuKhachHang();

        }
        private void loadDataSanPham()
        {
            SanPhamBLL bll = new SanPhamBLL();
            dgv_dssp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dssp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dssp.DataSource = bll.getAll();
        }
        public void loadDuLieuKhachHang()
        {
            KhachHangBLL bll = new KhachHangBLL();
            dgv_dskh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dskh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dskh.DataSource = bll.getAll();
        }
        public void loadCTHoaDonBan()
        {
            HoaDonBanBLL bll = new HoaDonBanBLL();
            dgv_Chitiethdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Chitiethdb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Chitiethdb.DataSource = bll.getAllCTHDB(tb_mahdb.Text.Trim());
        }
        string makh;
        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dskh.SelectedRows)
            {
                makh = row.Cells[0].Value.ToString();
                lb_makh.Text = makh;
            }
        }
        string masp;
        private void dgv_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dssp.SelectedRows)
            {
                masp = row.Cells[0].Value.ToString();
            }
           
        }
        public static string mahdb;
        private void button1_Click(object sender, EventArgs e)
        {
            if (makh == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
            else
            {
                HoaDonBanBLL bll = new HoaDonBanBLL();
                HoaDonBan hdb = new HoaDonBan(tb_mahdb.Text, DateTime.Now.ToString("yyyy-MM-dd"), NhanVienDAO.nv.Manv, makh);
                bll.add(hdb);
                MessageBox.Show("Thêm hóa đơn thành công, chọn sản phẩm cần mua");
            }
            mahdb = tb_mahdb.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDonBanBLL bll = new HoaDonBanBLL();
           CTHDB cTHDB = new CTHDB( tb_mahdb.Text, masp, 1);
            bll.addCTHD(cTHDB);
            loadCTHoaDonBan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ThanhToanHDB thanhToanHDB = new frm_ThanhToanHDB();
            thanhToanHDB.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_MainMenu mainMenu = new frm_MainMenu();
            mainMenu.Show();
            Visible = false;
        }
    }
}
