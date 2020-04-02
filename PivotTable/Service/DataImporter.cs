namespace PivotTable.Service
{
    public class DataImporter
    {
        public InfoData[] GetDatas() => new[]
        {
            new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RdwsStateManager",
                Position = 0,
                Value = 1,
                Partition = "1"
            },
                        new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RdwsStateManager",
                Position = 0,
                Value = 1,
                Partition = "2"
            },
                                                new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RdwsStateManager",
                Position = 0,
                Value = 1,
                Partition = "3"
            },
            new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RequestState",
                Position = 1,
                Value = 1,
                Partition = "1"
            },
                        new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RequestState",
                Position = 1,
                Value = 1,
                Partition = "2"
            },
                                                new InfoData
            {
                Application = "Geysir",
                MetricName = "globalState",
                ServiceName = "RequestState",
                Position = 1,
                Value = 1,
                Partition = "3"
            },
        };
    }



    public class InfoData
    {
        public int Position { get; set; }
        public int Value { get; set; }
        public string ServiceName { get; set; }
        public string MetricName { get; set; }
        public string Application { get; set; }
        public string Time { get; set; }

        public string Partition { get; set; }
    }
}