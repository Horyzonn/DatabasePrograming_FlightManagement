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
        private SqlConnection cn;
        public DataProvider() {
            string cnStr = @"Data Source=LAPTOP-AUNQK92F\THIENPHU;Initial Catalog=FlightManagement;Integrated Security=True;";
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

        //Read data and return single value
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
