using RESTful.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.BusinessLogics;
using Test.DataAccess;
using Test.Interfaces;
using Test.Models;

namespace RESTful.Services.Controllers
{
    public class EquinitiTestController : Controller
    {
        IFinanceBusinessLogics _iFinanceBusinessLogics = null;

        public EquinitiTestController(IFinanceBusinessLogics iFinanceBusinessLogics)
        {
            _iFinanceBusinessLogics = iFinanceBusinessLogics;
        }

        public EquinitiTestController() {
            _iFinanceBusinessLogics = new FinanceBusinessLogics(new FinanceDataAccess((IDictionary<string, FinancialData>)Session["financialData"]));
        }

        [HttpGet]
        [Route("getfinancialdatabyid{id}")]
        public ActionResult Get(string id)
        {
            FinancialData financialData = _iFinanceBusinessLogics.GetFinancialDataById(id);
            return View(financialData);
        }

        [HttpPost]
        [Route("savefinancialdata")]
        public ActionResult Post(List<FinancialData> financialData)
        {
            _iFinanceBusinessLogics.SaveFinancialData(financialData);

            return View();
        }

        [HttpPut]
        [Route("updatefinancialdata")]
        public ActionResult Update(List<FinancialData> financialData)
        {
            _iFinanceBusinessLogics.SaveFinancialData(financialData);

            return View();
        }

        [HttpDelete]
        [Route("deletefinancialdatabyid/{id}")]
        public ActionResult Delete(string id)
        {
            _iFinanceBusinessLogics.DeleteFinancialDataById(id);

            return View();
        }
    }
}