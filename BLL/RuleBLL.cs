using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RuleBLL
    {
        private RuleDAO ruleDAO;

        public RuleBLL()
        {
            ruleDAO = new RuleDAO();
        }

        public DataTable GetRules()
        {
            return ruleDAO.GetRules();
        }

        public bool UpdateRules(Rules rule)
        {
            return ruleDAO.UpdateRules(rule);
        }
    }
}
