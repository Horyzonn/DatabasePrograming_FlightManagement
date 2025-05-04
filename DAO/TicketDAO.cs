using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Diagnostics;

namespace DAO
{
    public class TicketDAO : DataProvider
    {
        public DataTable GetTicketByCCCD(string cccd)
        {
            string sql = @"
        SELECT 
            t.ID AS TicketID,
            depAirport.Name AS DepartureAirport, 
            arrAirport.Name AS ArrivalAirport,
            fs.DepartureTime AS FlightDepartureTime,
            fs.ArrivalTime AS FlightArrivalTime,
            t.Type AS TicketType,
            t.CreatedDate AS TicketCreatedDate
        FROM 
            Tickets t
        JOIN 
            Passengers p ON t.PassengerID = p.ID
        JOIN 
            FlightSchedule fs ON t.FlightScheduleID = fs.ID
        JOIN 
            Routes r ON fs.RouteID = r.ID
        JOIN
            Airports depAirport ON r.DepartureAirport = depAirport.Code 
        JOIN
            Airports arrAirport ON r.ArrivalAirport = arrAirport.Code   
        WHERE 
            p.PassportNumber = @CCCD";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@CCCD", cccd)
            };

            return ExeQuery(sql, CommandType.Text, parameters);
        }

        public decimal GetIncome()
        {
            string sql = "SELECT SUM(Price) FROM Tickets";
            try
            {
                Connect();
                return (decimal)ExeScalar(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculating income: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public Dictionary<string, int> GetTicketCountByMonth()
        {
            string sql = @"
        SELECT 
            FORMAT(CreatedDate, 'yyyy-MM') AS Month,
            COUNT(*) AS TicketCount
        FROM Tickets
        GROUP BY FORMAT(CreatedDate, 'yyyy-MM')
        ORDER BY Month";

            Dictionary<string, int> ticketCounts = new Dictionary<string, int>();

            try
            {
                Connect();
                DataTable dt = ExeQuery(sql, CommandType.Text);

                foreach (DataRow row in dt.Rows)
                {
                    string month = row["Month"].ToString(); // e.g. "2024-07"
                    int count = Convert.ToInt32(row["TicketCount"]);

                    ticketCounts[month] = count;
                }

                return ticketCounts;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đếm vé theo tháng: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }


        public bool AddTicket(Tickets ticket)
        {
            string sql = @"
INSERT INTO Tickets (FlightScheduleID, PassengerID, Type, Price, CreatedDate, ExtraPackage) 
VALUES (@flightid, @passengerid, @type, @price, @createdDate, @extraPackage);

IF @type = 1
BEGIN
    UPDATE FlightSchedule 
    SET Ticket1BookedQuantity = Ticket1BookedQuantity + 1 
    WHERE ID = @flightid;
END
ELSE
BEGIN
    UPDATE FlightSchedule 
    SET Ticket2BookedQuantity = Ticket2BookedQuantity + 1 
    WHERE ID = @flightid;
END
";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@flightid", ticket.FlightScheduleId),
                new SqlParameter("@passengerid", ticket.PassengerId),
                new SqlParameter("@type", ticket.Type),
                new SqlParameter("@price", ticket.Price),
                new SqlParameter("@createdDate", ticket.CreatedDate),
                new SqlParameter("@extraPackage", ticket.ExtraPackage)
            };
            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding ticket: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        
    }
}
