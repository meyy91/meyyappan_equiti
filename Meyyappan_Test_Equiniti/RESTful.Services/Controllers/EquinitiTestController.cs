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
        List<FinancialData> findataSession = null;

        public EquinitiTestController(IFinanceBusinessLogics iFinanceBusinessLogics)
        {
            _iFinanceBusinessLogics = iFinanceBusinessLogics;
        }

        public EquinitiTestController()
        {
            findataSession = new List<FinancialData>();
            //Session["financialData"] = findataSession;
            //(List<FinancialData>)Session["financialData"])

            _iFinanceBusinessLogics = new FinanceBusinessLogics(new FinanceDataAccess(findataSession));
        }

        [HttpGet]
        //[Route("getfinancialdatabyid/{id}")]
        public ActionResult Get(string id)
        {
            FinancialData financialData = _iFinanceBusinessLogics.GetFinancialDataById(id);

            if (Session["financialData"] != null)
            {
                List<FinancialData> financialDataFromSession = (List<FinancialData>)Session["financialData"];

                return View(financialDataFromSession.FirstOrDefault(x => x.Id == id));
            }
            else {
                return View(new FinancialData());
            }
        }

        [HttpPost]
        //[Route("savefinancialdata")]
        public ActionResult Post(List<FinancialData> financialData)
        {
            //_iFinanceBusinessLogics.SaveFinancialData(financialData);

            if (Session["financialData"] != null)
            {
                List<FinancialData> financialDataFromSession = (List<FinancialData>)Session["financialData"];

                financialDataFromSession.AddRange(financialData);

                Session["financialData"] = financialDataFromSession;
            }
            else {
                List<FinancialData> financialDataFromSession = new List<FinancialData>();
                financialDataFromSession.AddRange(financialData);

                Session["financialData"] = financialDataFromSession;
            }

            return RedirectToAction("Result");
        }

        [HttpPut]
        //[Route("updatefinancialdata")]
        public ActionResult Update(List<FinancialData> financialData)
        {
            _iFinanceBusinessLogics.SaveFinancialData(financialData);

            return RedirectToAction("Result");
        }

        [HttpDelete]
        //[Route("deletefinancialdatabyid/{id}")]
        public ActionResult Delete(string id)
        {
            _iFinanceBusinessLogics.DeleteFinancialDataById(id);

            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            if (Session["financialData"] != null)
            {
                return View((List<FinancialData>)Session["financialData"]);
            }
            else
            {
                return View(new List<FinancialData>());
            }
        }
    }
}