using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_ly_cua_hang;
using Quan_ly_cua_hang.BLL;
using Quan_ly_cua_hang.Model;
using Quan_ly_cua_hang.Utils;

namespace Quan_ly_cua_hang.GUI
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL bll = new KhachHangBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = tb_makh.Text,
                TenKH = tb_ten.Text,
                SDT = tb_sdt.Text
            };

            bll.add(kh);
            loadDuLieu();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        public void loadDuLieu()
        {


            dgv_dskh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dskh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dskh.DataSource = bll.getAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = tb_makh.Text,
                TenKH = tb_ten.Text,
                SDT = tb_sdt.Text
            };

            bll.update(kh);
            loadDuLieu();
        }
        string makh;
        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dskh.SelectedRows)
            {
                makh = row.Cells[0].Value.ToString();
                tb_makh.Text = makh;
                tb_ten.Text = row.Cells[1].Value.ToString();
                tb_sdt.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bll.delete(makh);
            loadDuLieu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_dskh.DataSource = bll.timKiem(tb_timkiem.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_MainMenu mainMenu = new frm_MainMenu();
            mainMenu.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
