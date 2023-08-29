using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaCreacion { get; private set; }

        public Producto()
        {
            FechaCreacion = DateTime.Now;
        }
    }
}