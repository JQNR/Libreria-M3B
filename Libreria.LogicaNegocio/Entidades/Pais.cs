using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Pais( string nombre, string codigo)
        {
           
            Nombre = nombre;
            Codigo = codigo;
        }

        public Pais()
        {
            
        }
        public void Validar() { 
        
            //TODO Crear validaciones para País
        }
    }
}
