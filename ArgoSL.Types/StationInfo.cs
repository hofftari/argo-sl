﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Types
{
        public class StationInfo
        {
            public int StatusCode { get; set; }
            public object Message { get; set; }
            public int ExecutionTime { get; set; }
            public Responsedata[] ResponseData { get; set; }
        }

        public class Responsedata
        {
            public string Name { get; set; }
            public string SiteId { get; set; }
            public string Type { get; set; }
            public string X { get; set; }
            public string Y { get; set; }
        }
    
}
