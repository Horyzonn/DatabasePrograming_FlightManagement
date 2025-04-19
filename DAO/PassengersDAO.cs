using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PassengersDAO: DataProvider
    {
        public DataTable GetAllPassengers()
        {
            string sql = "SELECT * FROM Passengers";
            return ExeQuery(sql, CommandType.Text);
        }
        public bool AddPassenger(Passengers passenger)
        {
            string sql = @"INSERT INTO Passengers 
                           (FullName, DayOfBirth, Gender, PassportNumber, Nationality, Email, PhoneNumber)
                           VALUES 
                           (@FullName, @DayOfBirth, @Gender, @PassportNumber, @Nationality, @Email, @PhoneNumber)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", passenger.FullName),
                new SqlParameter("@DayOfBirth", passenger.DayOfBirth),
                new SqlParameter("@Gender", passenger.Gender),
                new SqlParameter("@PassportNumber", (object)passenger.PassportNumber ?? DBNull.Value),
                new SqlParameter("@Nationality", passenger.Nationality),
                new SqlParameter("@Email", passenger.Email),
                new SqlParameter("@PhoneNumber", passenger.PhoneNumber)
            };
            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm hành khách: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool UpdatePassenger(Passengers passenger)
        {
            string sql = @"UPDATE Passengers SET
                           FullName = @FullName,
                           DayOfBirth = @DayOfBirth,
                           Gender = @Gender,
                           PassportNumber = @PassportNumber,
                           Nationality = @Nationality,
                           Email = @Email,
                           PhoneNumber = @PhoneNumber
                           WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", passenger.Id),
                new SqlParameter("@FullName", passenger.FullName),
                new SqlParameter("@DayOfBirth", passenger.DayOfBirth),
                new SqlParameter("@Gender", passenger.Gender),
                new SqlParameter("@PassportNumber", (object)passenger.PassportNumber ?? DBNull.Value),
                new SqlParameter("@Nationality", passenger.Nationality),
                new SqlParameter("@Email", passenger.Email),
                new SqlParameter("@PhoneNumber", passenger.PhoneNumber)
            };
            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật hành khách: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool DeletePassenger(int id)
        {
            string sql = "DELETE FROM Passengers WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id)
            };

            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa hành khách: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool IsPassengerExists(int id)
        {
            string sql = "SELECT COUNT(*) FROM Passengers WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id)
            };

            try
            {
                Connect();
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra hành khách: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

