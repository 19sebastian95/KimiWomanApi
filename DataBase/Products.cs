using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    [Keyless]
    public class Products
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }        
        public string? Marca { get; set; }
        public List<Variaciones> Variaciones { get; set; }
    }
}
