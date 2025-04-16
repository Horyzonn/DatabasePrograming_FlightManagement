using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RuleDAO : DataProvider
    {
        public DataTable GetRules()
        {
            string sql = "SELECT * FROM Rules";
            return ExeQuery(sql, CommandType.Text);
        }

        public bool UpdateRules(Rules rule)
        {
            string sql = @"UPDATE Rules SET
                            MinTimeFlight = @MinTimeFlight,
                            TimeBookTicket = @TimeBookTicket,
                            TimeBuyTicket = @TimeBuyTicket
                            WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", rule.Id),
                new SqlParameter("@MinTimeFlight", rule.MinTimeFlight),
                new SqlParameter("@TimeBookTicket", rule.TimeBookTicket),
                new SqlParameter("@TimeBuyTicket", rule.TimeBuyTicket),
                //new SqlParameter("@AuthorId", rule.AuthorId)
            };

            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                // Log lỗi SQL vào file log hoặc database để dễ dàng theo dõi và xử lý
                throw new Exception("Lỗi khi cập nhật quy định: " + ex.Message);
               
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác (không phải lỗi SQL)
                throw new Exception("Đã xảy ra lỗi: " + ex.Message);
                
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

