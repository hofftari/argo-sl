using ArgoSL.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgoSL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetRealTimeInfo();
        }
        private void GetRealTimeInfo()
        {
            string apiRoot = "http://api.sl.se/api2/";
            string format = "json";
            string key = "277124c377f64fb49754856186782460";
            string siteId = "9509";
            string timeWindow = "20";
            

            XHttpClient apiClient = new XHttpClient(apiRoot);
            SLClient client = new SLClient(apiClient);

            string result = client.GetRealTimeInfoForStation(key, siteId, timeWindow);
            RealTimeInfo info = JsonConvert.DeserializeObject<RealTimeInfo>(result);
        }
    }
}
