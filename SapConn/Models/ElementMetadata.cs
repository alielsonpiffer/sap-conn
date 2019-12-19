namespace SapConn.Models
{
    public class ElementMetadata
    {
        public string Name { get; set; }
        public string Documentation { get; set; }
        public object ExtendedDescription { get; set; }
        public string DataType { get; set; }

        public int NucLength { get; set; }
        public int UcLength { get; set; }
        public int Decimals { get; set; }
    }
}
