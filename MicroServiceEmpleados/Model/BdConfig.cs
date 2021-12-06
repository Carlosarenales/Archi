namespace MicroServiceEmpleados.Model
{
    public class BdConfig : IBdConfig
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }

    public interface IBdConfig
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
