using Quan_ly_cua_hang.Model;
using Quan_ly_cua_hang.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang.GUI
{
    public partial class frm_ThongKe : Form
    {
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        public frm_ThongKe()
        {
            InitializeComponent();
            dgv_banchay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_banchay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_doanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doanhthu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_doanhthu.DataSource = thongKeDAO.ThongKeList("");
            dgv_banchay.DataSource =  DBHelper.getDataSet("ThongKeBanChay").Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_doanhthu.DataSource = thongKeDAO.ThongKeList(tb_tukhoa.Text);
        }
    }
}
