using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Objects
{
    public class Document
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public IReadOnlyList<Sheet> Sheets { get; private set; }

        public Document(Guid id, string name, string type, IReadOnlyList<Sheet> sheets)
        {
            Id = id;
            Name = name;
            Type = type;
            Sheets = sheets;
        }
    }
}
