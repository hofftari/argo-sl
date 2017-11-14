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
            //GetRealTimeInfo();
        }
        private void GetRealTimeInfo()
        {
            //string siteId = "9509";
            string siteId = this.textBox1.Text;

            AHttpClient apiClient = new AHttpClient();
            ASLClient client = new ASLClient(apiClient);
            
            RealTimeInfo info = client.GetRealTimeInfoForStation(siteId);
            PopulateLabels(info);

            string station = client.SearchForStation("solna");
        }
        private void PopulateLabels(RealTimeInfo info)
        {
            ShowRealtimeLabels();
            for (int i = 0; i <= 2; i++)
            {
                Bus bus = info.ResponseData.Buses[i];
                Controls[0].Controls[0].Controls["line" + (i + 1)].Text = bus.LineNumber;
                Controls[0].Controls[0].Controls["destination" + (i + 1)].Text = bus.Destination;
                TimeSpan span = (DateTime)bus.ExpectedDateTime - DateTime.Now;
                Controls[0].Controls[0].Controls["time" + (i + 1)].Text = (int)span.TotalMinutes + " min";
            }
        }
        private void ShowRealtimeLabels()
        {
            Controls[0].Controls[0].Controls["line1"].Visible = true;
            Controls[0].Controls[0].Controls["line2"].Visible = true;
            Controls[0].Controls[0].Controls["line3"].Visible = true;
            Controls[0].Controls[0].Controls["destination1"].Visible = true;
            Controls[0].Controls[0].Controls["destination2"].Visible = true;
            Controls[0].Controls[0].Controls["destination3"].Visible = true;
            Controls[0].Controls[0].Controls["time1"].Visible = true;
            Controls[0].Controls[0].Controls["time2"].Visible = true;
            Controls[0].Controls[0].Controls["time3"].Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.GetRealTimeInfo();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.GetRealTimeInfo();
            }
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.StationSearch();
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.StationSearch();
        }
        private void StationSearch()
        {
            string searchString = textBox2.Text;
            AHttpClient apiClient = new AHttpClient();
            ASLClient client = new ASLClient(apiClient);

            StationInfo info = client.GetSearchResultsForStation(searchString);
            listBox1.Items.Clear();

            foreach (Responsedata station in info.ResponseData.ToList())
            {
                this.listBox1.Items.Add(station.Name + " - " + station.SiteId + "\r\n");
            }
        }
    }
}
