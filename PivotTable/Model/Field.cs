﻿namespace PivotTable.Model
{
    public class Field
    {
        public Zone Zone { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }

    public enum Zone
    {
        Row,
        Column,
        All
    }
}
