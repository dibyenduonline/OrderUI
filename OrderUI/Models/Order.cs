using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderUI.Models
{
    public class Order
    {
        public string OrderInfo1 { get; set; }
        public string OrderInfo2 { get; set; }
        public string OrderInfo3 { get; set; }
        public string OrderInfo4 { get; set; }
        public string OrderInfo5 { get; set; }

        public List<HistoryDetails> OrderHistory { get; set; }
        public ShippingInfo OrderShippingDetails { get; set; }
    }

    public class HistoryDetails
    {
        public string HisoryStatus { get; set; }
        public string HistoryDate { get; set; }
        public string HistoryInfo { get; set; }
    }

    public class ShippingInfo
    {
        public string ShippingInfo1 { get; set; }
        public string ShippingInfo2 { get; set; }
        public string ShippingInfo3 { get; set; }
        public string ShippingInfo4 { get; set; }
        public string ShippingInfo5 { get; set; }
        public List<ShippingHistory> ShippingDetails { get; set; }
    }

    public class ShippingHistory
    {
        public string ShippingHisoryStatus { get; set; }
        public string ShippingHistoryDate { get; set; }
        public string ShippingHistoryInfo { get; set; }

    }
}