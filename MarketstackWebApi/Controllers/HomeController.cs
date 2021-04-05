using MarketstackWebApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketstackWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public JsonResult ReadEndOfTheDayData(string tickers)
        {
            var eod_Root = MarketStackApi.CallExternalAPIForEndOfDayData(tickers);
            


            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReadHistoricData(string tickers, DateTime fromDate, DateTime toDate)
        {
            var hd_Root = MarketStackApi.CallExternalAPIForHistoricData(tickers, fromDate, toDate);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult ReadIntraData(string tickers)
        {
            var iDay_Root = MarketStackApi.CallIntradayData(tickers)
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
