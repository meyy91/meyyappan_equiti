using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;
using Test.Models;

namespace Test.DataAccess
{
    public class FinanceDataAccess : IFinanceDataAccess
    {
        IDictionary<string, FinancialData> _sessionFinancialData = null;

        public FinanceDataAccess(IDictionary<string, FinancialData> financialData)
        {
            _sessionFinancialData = financialData;
        }

       
        public FinancialData GetFinancialDataById(string id)
        {
            if (id != null)
            {
                return _sessionFinancialData[id];
            }

            return null;
        }

        public void SaveFinancialData(List<FinancialData> financialData)
        {
            foreach (var data in financialData)
            {
                if (data != null && _sessionFinancialData != null)
                {
                    _sessionFinancialData[data.Id] = data;
                }
            }
        }

        public void DeleteFinancialDataById(string id)
        {
            if (_sessionFinancialData != null)
            {
                _sessionFinancialData[id] = null;
            }
        }
    }
}
