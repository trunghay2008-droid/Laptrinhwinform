using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace BaiTH3
{
    internal class DataHelper
    {
        private string _connectionString = "";
        private SqlConnection _con;
        // Kết nối bằng quyền Windows
        public DataHelper(string serverName, string databaseName)
        {
            _connectionString =
                @"Server=" + serverName +
                ";Database=" + databaseName +
                ";Integrated Security=True;" +
                "TrustServerCertificate=True";
            _con = new SqlConnection(_connectionString);
        }

        // Kết nối bằng tài khoản SQL
        public DataHelper(string serverName, string databaseName,
                          string userName, string password)
        {
            _connectionString =
                @"Server=" + serverName +
                ";Database=" + databaseName +
                ";User Id=" + userName +
                ";Password=" + password +
                "TrustServerCertificate=True" + ";";
            _con = new SqlConnection(_connectionString);
        }

        // Mở kết nối
        public void Open()
        {
            if (_con.State == ConnectionState.Closed)
                _con.Open();
        }

        // Đóng kết nối
        public void Close()
        {
            if (_con.State == ConnectionState.Open)
                _con.Close();
        }

        // --- 1. Đọc file config.ini ---
        public static void ReadConfig(string fileName,
                                      out string quyen,
                                      out string serverName,
                                      out string databaseName,
                                      out string userName,
                                      out string password)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                quyen = !sr.EndOfStream ? sr.ReadLine() : "";
                serverName = !sr.EndOfStream ? sr.ReadLine() : "";
                databaseName = !sr.EndOfStream ? sr.ReadLine() : "";
                userName = !sr.EndOfStream ? sr.ReadLine() : "";
                password = !sr.EndOfStream ? sr.ReadLine() : "";
            }
        }

        // --- 2. Ghi file config.ini ---
        public static void WriteConfig(string fileName,
                                       string quyen,
                                       string serverName,
                                       string databaseName,
                                       string userName,
                                       string password)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(quyen);
                sw.WriteLine(serverName);
                sw.WriteLine(databaseName);
                sw.WriteLine(userName);
                sw.WriteLine(password);
            }
        }
        // --- 3. Thực thi SELECT ---
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _con);
            return cmd.ExecuteReader(); // nhớ Close() DataReader sau khi dùng
        }

        // --- 4. Thực thi INSERT/UPDATE/DELETE ---
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _con);
            return cmd.ExecuteNonQuery();
        }

        // Có thể thêm phương thức dùng Store Procedure nếu muốn:
        public int ExecuteNonQueryStore(string storeName, params SqlParameter[] pars)
        {
            SqlCommand cmd = new SqlCommand(storeName, _con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(pars);
            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteReaderStore(string storeName, params SqlParameter[] pars)
        {
            SqlCommand cmd = new SqlCommand(storeName, _con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(pars);
            return cmd.ExecuteReader();
        }

        public SqlConnection Connection
        {
            get { return _con; }
        }

    }
}

