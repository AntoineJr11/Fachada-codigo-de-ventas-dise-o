using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.clases
{
  public  class personaMODERNISTA
    {

        public int IdPersona { get; set; }

        public int NumeroIdentificacion { get; set; }

        public string NumeroFiscal { get; set; }


        public string NombresPersona { get; set; }

        public string ApellidosPersonal{ get; set; }

        public string Direccion{ get; set; }

        public string CorreoElectronico { get; set; }

        public string NumeroTelefono { get; set; }

        public personaMODERNISTA(int idPersona, int numeroIdentificacion, string numeroFiscal, 
            string nombresPersona, string apellidosPersonal, string direccion, 
            string correoElectronico, string numeroTelefono)
        {
            IdPersona = idPersona;
            NumeroIdentificacion = numeroIdentificacion;
            NumeroFiscal = numeroFiscal;
            NombresPersona = nombresPersona;
            ApellidosPersonal = apellidosPersonal;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            NumeroTelefono = numeroTelefono;
        }
    }
}
