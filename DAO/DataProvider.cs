 using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        private SqlConnection cn;
        public DataProvider() {
            string cnStr = @"Data Source=LAPTOP-JP71J78K\THIEN_NGAN;Initial Catalog=FlightManagement;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, ex);
            }
        }

        public void Disconnect() {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        //Trả về giá trị số duy nhất
        public object ExeScalar(string sql, CommandType type, params SqlParameter[] parameters)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                // Thêm parameters nếu có
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                Connect();
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi thực thi SQL: " + ex.Message, ex);
            }
            finally
            {
                // Giải phóng tài nguyên thủ công
                if (cmd != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
                Disconnect();
            }
        }

        // 2. ExecuteQuery: Trả về DataTable
        public DataTable ExeQuery(string sql, CommandType type, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;
            DataTable dt = new DataTable();

            try
            {
                Connect();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi ExecuteQuery: " + ex.Message, ex);
            }
            finally
            {
                cmd.Parameters.Clear();
                Disconnect();
            }
        }

        // 3. ExecuteNonQuery: Thực thi INSERT/UPDATE/DELETE
        public int ExeNonQuery(string sql, CommandType type, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            try
            {
                Connect();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi ExecuteNonQuery: " + ex.Message, ex);
            }
            finally
            {
                cmd.Parameters.Clear();
                Disconnect();
            }
        }

        // 4. ExecuteReader: Đọc dữ liệu tuần tự
        public SqlDataReader ExeReader(string sql, CommandType type, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            try
            {
                Connect();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                Disconnect();
                throw new Exception("Lỗi ExecuteReader: " + ex.Message, ex);
            }
        }

        // Hàm hủy (finalizer) để dọn dẹp khi đối tượng bị thu hồi
        ~DataProvider()
        {
            if (cn != null)
            {
                Disconnect();
                cn.Dispose();
            }
        }

    }




}
