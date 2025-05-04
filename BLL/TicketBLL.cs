using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace BLL
{
    public class TicketBLL
    {
        private TicketDAO ticketDAO;
        public TicketBLL()
        {
            ticketDAO = new TicketDAO();
        }

        public decimal GetIncome()
        {
            try
            {
                return ticketDAO.GetIncome();
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculating income: " + ex.Message, ex);
            }
        }

        public Dictionary<string, int> GetTicketCountByMonth()
        {
            try
            {
                return ticketDAO.GetTicketCountByMonth();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving ticket count by month: " + ex.Message, ex);
            }
        }

        public bool AddTicket(Tickets ticket)
        {
            try
            {
                return ticketDAO.AddTicket(ticket);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding ticket: " + ex.Message, ex);
            }
        }

        public DataTable GetTicketByCCCD(string cccd)
        {
            try
            {
                return ticketDAO.GetTicketByCCCD(cccd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving ticket by CCCD: " + ex.Message, ex);
            }
        }

        
    }
}
