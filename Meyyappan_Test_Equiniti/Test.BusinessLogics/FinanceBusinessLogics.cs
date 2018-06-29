using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;
using Test.Models;

namespace Test.BusinessLogics
{
    public class FinanceBusinessLogics : IFinanceBusinessLogics
    {
        IFinanceDataAccess _iFinanceDataAccess = null;

        public FinanceBusinessLogics(IFinanceDataAccess iFinanceDataAccess)
        {
            _iFinanceDataAccess = iFinanceDataAccess;
        }

        public FinancialData GetFinancialDataById(string id)
        {
            return _iFinanceDataAccess.GetFinancialDataById(id);
        }
    }
}
