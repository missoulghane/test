using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Objects
{
    public class Sheet
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Sheet(Guid id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
