using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.clases
{
   public class articulo
    {
        //clase comun para articulo (atributos)
        public string IdArticulo { get; set; }

        public string NombreArticulo { get; set; }

        public string PrecioArticulo { get; set; }

        public string CantidadRticulo { get; set; }

        public articulo() { }
        public articulo(string idArticulo, string nombreArticulo, string precioArticulo, string cantidadRticulo)
        {
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            PrecioArticulo = precioArticulo;
            CantidadRticulo = cantidadRticulo;
        }
    }
}
