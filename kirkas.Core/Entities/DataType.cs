using System;
using System.Collections.Generic;
using System.Text;

namespace kirkas.Core.Entities
{
    public class DataType : BaseEntity
    {
        string Name { get; set; }
        string Description { get; set; }

        public DataType(string name, String description)
        {
            Name = name;
            Description = description;
        }
    }
}
