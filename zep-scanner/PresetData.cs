﻿namespace ZEP.Scanner
{
    public class PresetData
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public PresetData(Record record)
        {
            Name = record.Name;
            Value = record.Value;
        }
    }
}
