using System.Collections.Generic;

namespace SapConn.Models
{
    public class StructureMetadata
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public ICollection<ParameterMetadata> Values { get; set; }

        public StructureMetadata()
        {
            Values = new List<ParameterMetadata>();
        }

        public override string ToString()
        {
            return $"[{Name}]";
        }
    }
}
