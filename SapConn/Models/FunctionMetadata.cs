namespace SapConn.Models
{
    public class FunctionMetadata
    {
        public string Verb { get; set; } // VERB
        public string Name { get; set; } // ABAPNAME
        public string Description { get; set; } // BAPI_TEXT
        public string ObjectName { get; set; } // OBJECTNAME
        public string ObjectDescription { get; set; } // BO_TEXT
    }

}
