using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Keyless]
    public class Images
    {
        public int? IdImgProducto { get; set; }
        public byte? Imagen { get; set; }
    }
}
