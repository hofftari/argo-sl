using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Classes.Interfaces
{
    public interface ISLClient
    {
        string GetRealTimeInfoForStation(string station);
    }
}
