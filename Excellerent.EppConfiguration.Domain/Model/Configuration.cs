﻿using Excellerent.SharedModules.Seed;

namespace Excellerent.EppConfiguration.Domain.Model
{
    public class Configuration : BaseAuditModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }

        public Configuration() : base()
        {
            Key = string.Empty;
            Value = string.Empty;
            DataType = string.Empty;
        }
        public Configuration(Configuration config) : base()
        {
            Key = config.Key;
            Value = config.Value;
            DataType = config.DataType;
        }
        public Configuration(string key, string value, string dataType) : base()
        {
            Key = key;
            Value = value;
            DataType = dataType;
        }
    }
}
