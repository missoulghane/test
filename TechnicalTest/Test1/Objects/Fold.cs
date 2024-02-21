using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Objects
{
    public class Fold
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyList<Document> Documents { get; private set; }
        public Fold(Guid id, string name, IReadOnlyList<Document> documents)
        {
            Id = id;
            Name = name;
            Documents = documents;
        }
    }
}
