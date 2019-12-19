namespace SapConn.Models
{
    public class ParameterMetadata
    {
        public string Name { get; set; }
        public object Direction { get; set; }
        public string DefaultValue { get; set; }
        public string Documentation { get; set; }

        public object Value { get; set; }

        public bool Active { get; set; }
        public bool Optional { get; set; }

        public object DataType { get; set; }
        public object ExtendedDescription { get; set; }
        public int NucLength { get; set; }
        public int UcLength { get; set; }
        public int Decimals { get; set; }
    }
}
