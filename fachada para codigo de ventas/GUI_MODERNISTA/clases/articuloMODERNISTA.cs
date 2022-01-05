using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.clases
{
   public class articuloMODERNISTA
    {

        public int IdArticulo { get; set; }

        public int NombreArticulo { get; set; }

        public int PrecioArticulo { get; set; }

        public int CantidadRticulo { get; set; }

        public articuloMODERNISTA(int idArticulo, int nombreArticulo, int precioArticulo, int cantidadRticulo)
        {
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            PrecioArticulo = precioArticulo;
            CantidadRticulo = cantidadRticulo;
        }
    }
}
