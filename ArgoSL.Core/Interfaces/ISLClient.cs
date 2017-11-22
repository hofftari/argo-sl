using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Core.Interfaces
{
    public interface ISLClient
    {
        RealTimeInfo GetRealTimeInfoForStation(string stationId);
        StationInfo SearchForStation(string searchString);
    }
}
