using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketstackWebApi.Helpers.HelperModels
{
    public class Intraday
    {
        public class Pagination
        {
            public int limit { get; set; }
            public int offset { get; set; }
            public int count { get; set; }
            public int total { get; set; }
        }

        public class Data
        {
            public Nullable<double> open { get; set; }
            public Nullable<double> high { get; set; }
            public Nullable<double> low { get; set; }
            public Nullable<double> last { get; set; }
            public Nullable<double> close { get; set; }
            public Nullable<double> volume { get; set; }
            public DateTime date { get; set; }
            public string symbol { get; set; }
            public string exchange { get; set; }

        }
        public class Root
        {
            public Pagination pagination { get; set; }
            public List<Data> data { get; set; }
        }
    }
}