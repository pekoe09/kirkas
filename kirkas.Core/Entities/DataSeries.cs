using System;
using System.Collections.Generic;
using System.Text;

namespace kirkas.Core.Entities
{
    public class DataSeries : BaseEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        int TypeID { get; set; }
        DataType Type { get; set; }

        public DataSeries(string name, string description, DataType type)
        {
            Name = name;
            Description = description;
            TypeID = type.ID;
            Type = type;
        }
    }
}
