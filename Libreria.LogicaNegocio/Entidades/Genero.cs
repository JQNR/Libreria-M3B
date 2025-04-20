using Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EdadMinima { get; set; }


        public Genero(string nombre, int edadMinima)
        {
            Nombre = nombre;
            EdadMinima = edadMinima;
            Validar();
        }

        public Genero()
        {
            
        }
        public void Validar() {
            
            if (EdadMinima < 0)
            {

                throw new EdadMinimaException();
            }
            if (String.IsNullOrEmpty(Nombre))
            {

                throw new NombreGeneroException("No cumple el nombre");
            }

        }
    }
}
