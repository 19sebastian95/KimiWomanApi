using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Keyless]
    public class Variaciones
    {
        public int IdVariacion { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int? ValorAnterior { get; set; }
        public int ValorActual { get; set; }
        public string? Caracteristica { get; set; }
        public List<Images>? Imagenes { get; set; }
        public bool? Oferta { get; set; }
    }
}
