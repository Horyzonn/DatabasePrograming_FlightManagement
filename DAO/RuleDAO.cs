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
            try
            {
                Connect();

                string checkSql = "SELECT COUNT(*) FROM Rules";
                int count = (int)ExeScalar(checkSql, CommandType.Text);

                string sql;
                SqlParameter[] parameters;

                if (count == 0)
                {
                    // INSERT nếu chưa có dòng nào
                    sql = @"INSERT INTO Rules (MinTimeFlight, TimeBookTicket, TimeBuyTicket, AuthorID)
                    VALUES (@MinTimeFlight, @TimeBookTicket, @TimeBuyTicket, @AuthorID)";
                    parameters = new SqlParameter[]
                    {
                new SqlParameter("@MinTimeFlight", rule.MinTimeFlight),
                new SqlParameter("@TimeBookTicket", rule.TimeBookTicket),
                new SqlParameter("@TimeBuyTicket", rule.TimeBuyTicket),
                new SqlParameter("@AuthorID", rule.AuthorId)
                    };
                }
                else
                {
                    // UPDATE nếu đã có dòng — giới hạn 1 dòng, ví dụ Id = 1 (cần xác định rõ logic)
                    sql = @"UPDATE Rules SET
                        MinTimeFlight = @MinTimeFlight,
                        TimeBookTicket = @TimeBookTicket,
                        TimeBuyTicket = @TimeBuyTicket,
                        AuthorID = @AuthorID
                    WHERE Id = 1"; // Giả sử chỉ có 1 dòng với Id = 1
                    parameters = new SqlParameter[]
                    {
                new SqlParameter("@MinTimeFlight", rule.MinTimeFlight),
                new SqlParameter("@TimeBookTicket", rule.TimeBookTicket),
                new SqlParameter("@TimeBuyTicket", rule.TimeBuyTicket),
                new SqlParameter("@AuthorID", rule.AuthorId)
                    };
                }

                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL khi cập nhật/insert quy định: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

