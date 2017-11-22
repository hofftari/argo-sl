using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArgoSL.Core
{
    public class JsonStringToObjectConverter
    {
        public static RealTimeInfo ConvertRealTimeStringToObject(string realTimeInfo)
        {
            return JsonConvert.DeserializeObject<RealTimeInfo>(realTimeInfo);
        }
    }
}
