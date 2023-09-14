using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKinhDoanhNhaSach.Database
{
    public class DatabaseConection
    {
        SqlConnection conn = new SqlConnection();
        // Ket noi den co so du lieu
        public void Connection()
        {
            string sql = @"Data Source=LAPTOP-8NPMKL8D;Initial Catalog=QLKDNHATHUOC;Integrated Security=True";
            conn.ConnectionString = sql;
            conn.Open();
        }
      
        // Fill du lieu
        public void FillDulieu(string sql)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            sqlDataAdapter.Fill(dataSet);
            sqlDataAdapter.Dispose();
        }

        public void SaveData(string sql)
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
    
        public SqlDataReader DataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dataReader = sqlDataReader;
            return dataReader;
        }

        
    }
}
