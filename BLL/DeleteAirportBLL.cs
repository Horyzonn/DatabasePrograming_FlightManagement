using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeleteAirportBLL
    {
        private DeleteAirportDAO deleteDAO;

        public DeleteAirportBLL()
        {
            deleteDAO = new DeleteAirportDAO();
        }

        public bool DeleteAirport(string code)
        {
            try
            {
                return deleteDAO.DeleteAirport(code);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sân bay trong BLL: " + ex.Message, ex);
            }
        }
    }
}
