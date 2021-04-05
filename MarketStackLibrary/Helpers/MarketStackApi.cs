using MarketstackWebApi.Helpers.HelperModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MarketstackWebApi.Helpers
{
    public class MarketStackApi
    {
        public static EndOfDay.Root CallExternalAPIForEndOfDayData(string tickers, int oSet)
        {
            using (WebClient wc = new WebClient())
            {
                string connUrl = $"http://api.marketstack.com/v1/eod?access_key=6ce3f8d573972b4de1b384c4ae5d3f33&limit=1000&symbols={tickers}&offset={oSet}";
                var eodJson = wc.DownloadString(connUrl);
                var eodRoot = JsonConvert.DeserializeObject<EndOfDay.Root>(eodJson);
                return eodRoot;
            }
        }

        public static Historic.Root CallExternalAPIForHistoricData(string tickers, DateTime fDate, DateTime tDate, int oSet)
        {
            using (WebClient wc = new WebClient())
            {
                string fromDate = fDate.ToString("yyyy-MM-dd");
                string toDate = tDate.ToString("yyyy-MM-dd");
                string connUrl = $"http://api.marketstack.com/v1/eod?access_key=6ce3f8d573972b4de1b384c4ae5d3f33&limit=1000&symbols={tickers}&date_from={fromDate}&date_to={toDate}&offset={oSet}";
                var hJson = wc.DownloadString(connUrl);
                var hRoot = JsonConvert.DeserializeObject<Historic.Root>(hJson);
                return hRoot;
            }
        }

        public static Intraday.Root CallIntradayData(string tickers, int oSet)
        {
            using (WebClient wc = new WebClient())
            {
                string connUrl = $"http://api.marketstack.com/v1/intraday?access_key=6ce3f8d573972b4de1b384c4ae5d3f33&limit=1000&symbols={tickers}&offset={oSet}";
                var iDayJson = wc.DownloadString(connUrl);
                var iDayRoot = JsonConvert.DeserializeObject<Intraday.Root>(iDayJson);
                return iDayRoot;
            }
        }
    }
}