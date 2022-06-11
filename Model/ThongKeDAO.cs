using Quan_ly_cua_hang.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cua_hang.Model
{
    internal class ThongKeDAO
    {
        public List<ThongKe> ThongKeList(string keyword)
        {
            List<ThongKe> thongKes = new List<ThongKe>();
            string query = "ThongKe";
            SqlConnection connection = new SqlConnection(ConnectionString.connnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ThongKe thongKe = new ThongKe()
                {
                    NgayBan = dataReader[0].ToString(),
                    TongTien = int.Parse(dataReader[1].ToString()),
                };
                thongKes.Add(thongKe);
            }
            connection.Close();
            return thongKes.Where(x=>x.NgayBan.Contains(keyword)).ToList();
        }
    }
}
