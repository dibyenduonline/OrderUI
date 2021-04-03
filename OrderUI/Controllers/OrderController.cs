using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OrderUI.Models;
using Newtonsoft.Json;

namespace OrderUI.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Details()
        {
            var tempOrder = new Order();
            List<HistoryDetails> orderHistory = new List<HistoryDetails>();
            orderHistory.Add(new HistoryDetails() {HisoryStatus = "Open", HistoryDate ="01/01/2020", HistoryInfo = "test" });
            orderHistory.Add(new HistoryDetails() { HisoryStatus = "Closed", HistoryDate = "01/01/2018", HistoryInfo = "test2" });
            orderHistory.Add(new HistoryDetails() { HisoryStatus = "ReOpen", HistoryDate = "01/01/2019", HistoryInfo = "test3" });
            tempOrder.OrderHistory = orderHistory;
            tempOrder.OrderInfo1 = "data1";
            tempOrder.OrderInfo2 = "data2";
            tempOrder.OrderInfo3 = "data3";
            tempOrder.OrderInfo4 = "data4";
            tempOrder.OrderInfo5 = "data5";
            return  Json(tempOrder);
        }
    }
}