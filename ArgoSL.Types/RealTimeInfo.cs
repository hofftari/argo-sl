using System;

namespace ArgoSL.Types
{
    public class RealTimeInfo
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int ExecutionTime { get; set; }
        public ResponseData ResponseData { get; set; }
    }
    public class ResponseData
    {
        public DateTime? LatestUpdate { get; set; }
        public int DataAge { get; set; }
        public Metro[] Metros { get; set; }
        public Bus[] Buses { get; set; }
        public Train[] Trains { get; set; }
        public Tram[] Trams { get; set; }
        public Ship[] Ships { get; set; }
        public StopPointDeviation[] StopPointDeviations { get; set; }
    }
    public class Transport
    {
        public string TransportMode { get; set; }
        public string LineNumber { get; set; }
        public string Destination { get; set; }
        public int JourneyDirection { get; set; }
        public string GroupOfLine { get; set; }
        public string StopAreaName { get; set; }
        public int StopAreaNumber { get; set; }
        public int StopPointNumber { get; set; }
        public string StopPointDesignation { get; set; }
        public DateTime? TimeTabledDateTime { get; set; }
        public DateTime? ExpectedDateTime { get; set; }
        public string DisplayTime { get; set; }
        public int JourneyNumber { get; set; }
        public Deviation[] Deviations { get; set; }
    }
    public class Metro : Transport
    {

    }
    public class Bus : Transport
    {

    }
    public class Train : Transport
    {
        public string SecondaryDestinationName { get; set; }
    }
    public class Tram : Transport
    {

    }
    public class Ship : Transport
    {

    }
    public class StopPointDeviation
    {
        public StopInfo StopInfo { get; set; }
        public Deviation Deviation { get; set; }
    }
    public class StopInfo
    {
        public string GroupOfLine { get; set; }
        public string StopAreaName { get; set; }
        public int StopAreaNumber { get; set; }
        public string TransportMode { get; set; }
    }
    public class Deviation
    {
        public string Consequence { get; set; }
        public int ImportanceLevel { get; set; }
        public string Text { get; set; }
    }

}
