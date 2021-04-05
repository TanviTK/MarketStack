using MarketstackWebApi.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStackLibrary
{
    public class MarksetStackManager
    {
        public DataTable ReadEndOfTheDayData(string tickers, int offset = 0)
        {
            DataTable dtEndofDayData = new DataTable();
            var eodRoot = MarketStackApi.CallExternalAPIForEndOfDayData(tickers, offset);
            dtEndofDayData = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(eodRoot.data), (typeof(DataTable)));

            offset = offset + eodRoot.pagination.limit;
            if (eodRoot.pagination.total > eodRoot.pagination.limit)
            {
                for (int i = offset; i <= eodRoot.pagination.total;)
                {
                    DataTable dt = new DataTable();
                    eodRoot = MarketStackApi.CallExternalAPIForEndOfDayData(tickers, i);
                    dt = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(eodRoot.data), (typeof(DataTable)));
                    dtEndofDayData.Merge(dt, true, MissingSchemaAction.Ignore);
                    i += eodRoot.pagination.limit;
                }
            }
           
            return dtEndofDayData;
        }

        public DataTable ReadHistoricData(string tickers, DateTime fromDate, DateTime toDate, int offset = 0)
        {
            DataTable dtHistoricData = new DataTable();
            var hdRoot = MarketStackApi.CallExternalAPIForHistoricData(tickers, fromDate, toDate,offset);
            dtHistoricData = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(hdRoot.data), (typeof(DataTable)));

            offset = offset + hdRoot.pagination.limit;
            if (hdRoot.pagination.total > hdRoot.pagination.limit)
            {
                for (int i = offset; i <= hdRoot.pagination.total;)
                {
                    DataTable dt = new DataTable();
                    hdRoot = MarketStackApi.CallExternalAPIForHistoricData(tickers, fromDate,toDate, i);
                    dt = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(hdRoot.data), (typeof(DataTable)));
                    dtHistoricData.Merge(dt, true, MissingSchemaAction.Ignore);
                    i += hdRoot.pagination.limit;
                }
            }

            return dtHistoricData;
        }


        public DataTable ReadIntraData(string tickers, int offset = 0)
        {
            DataTable dtIntraDayData = new DataTable();
            var iDayRoot = MarketStackApi.CallIntradayData(tickers, offset);
            dtIntraDayData = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(iDayRoot.data), (typeof(DataTable)));

            offset = offset + iDayRoot.pagination.limit;
            if (iDayRoot.pagination.total > iDayRoot.pagination.limit)
            {
                for (int i = offset; i <= iDayRoot.pagination.total;)
                {
                    DataTable dt = new DataTable();
                    iDayRoot = MarketStackApi.CallIntradayData(tickers, i);
                    dt = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(iDayRoot.data), (typeof(DataTable)));
                    dtIntraDayData.Merge(dt, true, MissingSchemaAction.Ignore);
                    i += iDayRoot.pagination.limit;
                }
            }

            return dtIntraDayData;
        }
    }
}
