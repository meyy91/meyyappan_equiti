using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Interfaces
{
    public interface IFinanceDataAccess
    {
        FinancialData GetFinancialDataById(string id);
        void SaveFinancialData(List<FinancialData> financialData);
    }
}
