﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4Net_WCF.Logger.Extension
{
        public class ApiLogPatternMessage
        {
            public string CityCode { set; get; }
            public string AppName { get; set; }
            public string SysName { set; get; }
            public string FunName { set; get; }
            public DateTime RequestTime { set; get; }
            public DateTime ResponseTime { set; get; }
            public string ResponseCode { set; get; }
            public string XMLContent { set; get; }
        }
}