using GUI_MODERNISTA.clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Movimientos
{
    public class Movimiento
    {
        public void insertar(string idarticulo, string nombArticulo, string precioArticulo, string cantidadArticulo)
        {
            //idarticulo = "1234";
            //nombArticulo = "iPhone 12";
            //precioArticulo = "100000";
            //cantidadArticulo = "5";

            string insertarVar;
            insertarVar = $"{idarticulo}|{nombArticulo}|{precioArticulo}|{cantidadArticulo}";
            StreamWriter agregar = new StreamWriter("Articuos.txt", true);
            agregar.WriteLine(insertarVar);
            agregar.Close();
        }
        public List<articulo> Mostrar()
        {
            StreamReader documento = new StreamReader("Articuos.txt",true);
        List<articulo> insertarArt = new List<articulo>();
            string[] unidades;
            string comparar;
            while((comparar=documento.ReadLine())!=null)
            {
                unidades = comparar.Split('|');
                articulo agregarArticulo = new articulo();
                agregarArticulo.IdArticulo = unidades[0];
                agregarArticulo.NombreArticulo = unidades[1];
                agregarArticulo.PrecioArticulo = unidades[2];
                agregarArticulo.CantidadRticulo = unidades[3];
                insertarArt.Add(agregarArticulo);
            }
            documento.Close();
        return insertarArt;
            
        }
        public void eliminar(string datoaeliminar)
        {
            StreamReader leer = new StreamReader("Articuos.txt",true);
            StreamWriter escribir = new StreamWriter("ArchivoAuxiliar.txt",true);
            string[] unidades;
            string comparar;
            while((comparar=leer.ReadLine())!=null)
            {
                unidades = comparar.Split('|');
                if (unidades[0].Trim().Equals(datoaeliminar))
                {
                    //eliminado
                }
                else
                {
                    escribir.WriteLine(comparar);
                }
            }
            leer.Close();
            escribir.Close();
            File.Delete("Articuos.txt");
            File.Move("ArchivoAuxiliar.txt","Articuos.txt");
        }

        public void modificar(string idarticulo, string nombArticulo, string precioArticulo, string cantidadArticulo)
        {
            StreamReader leer = new StreamReader("Articuos.txt", true);
            StreamWriter escribir = new StreamWriter("ArchivoAuxiliar.txt", true);
            string[] unidades;
            string comparar;
            while ((comparar = leer.ReadLine()) != null)
            {
                unidades = comparar.Split('|');
                if (unidades[0].Trim().Equals(idarticulo))
                {
                    string insertarVar;
                    insertarVar = $"{idarticulo}|{nombArticulo}|{precioArticulo}|{cantidadArticulo}";
                    escribir.WriteLine(insertarVar);
                }
                else
                {
                    escribir.WriteLine(comparar);
                }
            }
            leer.Close();
            escribir.Close();
            File.Delete("Articuos.txt");
            File.Move("ArchivoAuxiliar.txt", "Articuos.txt");
        }
    }
}
