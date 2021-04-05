using MarketstackWebApi.Helpers.HelperModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace MarketstackWebApi.Helpers
{
    public class MarketStackApi
    {
        public static EndOfDay.Root CallExternalAPIForEndOfDayData(string tickers)
        {
            using (WebClient wc = new WebClient())
            {
                string connUrl = WebConfigurationManager.AppSettings["EndOfDayDataURL"] + tickers;
                var eod_json = wc.DownloadString(connUrl);
                var eod_Root = JsonConvert.DeserializeObject<EndOfDay.Root>(eod_json);
                return eod_Root;
            }
        }

        public static Historic.Root CallExternalAPIForHistoricData(string tickers, DateTime fromDate, DateTime toDate)
        {
            using (WebClient wc = new WebClient())
            {
                string from_Date = fromDate.ToString("yyyy-MM-dd");
                string to_Date = toDate.ToString("yyyy-MM-dd");
                string connUrl = WebConfigurationManager.AppSettings["HirstoricDataURL"];
                connUrl = connUrl + $"{tickers}&amp;date_from={from_Date}&amp;date_to={to_Date}";
                var h_json = wc.DownloadString(connUrl);
                var h_Root = JsonConvert.DeserializeObject<Historic.Root>(h_json);
                return h_Root;
            }
        }

        public static Intraday.Root CallIntradayData(string tickers)
        {
            using (WebClient wc = new WebClient())
            {
                string connUrl = WebConfigurationManager.AppSettings["IntradayDataURL"] + tickers;
                var iDay_json = wc.DownloadString(connUrl);
                var iDay_Root = JsonConvert.DeserializeObject<Intraday.Root>(iDay_json);
                return iDay_Root;
            }
        }
    }
}