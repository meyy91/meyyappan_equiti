using RESTful.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        [HttpGet]
        [Route("getfinancialdatabyid")]
        public ActionResult Get(string id)
        {
            FinancialData financialData = _iFinanceBusinessLogics.GetFinancialDataById(id);
            return View(financialData);
        }

        [HttpPost]
        [Route("savefinancialdata")]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPut]
        [Route("updatefinancialdata")]
        public ActionResult Update()
        {
            return View();
        }

        [HttpDelete]
        [Route("deletefinancialdatabyid")]
        public ActionResult Delete()
        {
            return View();
        }
    }
}