using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_ly_cua_hang.Utils
{
    class DBHelper
    {
        public static DataSet getDataSet(string query)
        {
          
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connnectionString))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet);
                connection.Close();
            }
            return dataSet;
        }
        public static void Execute(string query)
        {
       
            SqlConnection connection = new SqlConnection(ConnectionString.connnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Thất bại"+e.Message);
            }
        }
    }
}
