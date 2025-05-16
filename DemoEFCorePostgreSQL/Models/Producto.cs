namespace DemoEFCorePostgreSQL.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Precio { get; set; } = string.Empty;

    }
}
