using System;
using System.Collections.Generic;
using System.Text;

namespace TallerModulo1.Models.Entidades
{
   public class ProductoTienda
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImage { get; set; }
        public decimal Price { get; set; }
    }
}
