using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Types.Interfaces
{
    public interface ISLClient
    {
        RealTimeInfo GetRealTimeInfoForStation(string stationId);
        string SearchForStation(string searchString);
    }
}
