using Libreria.LogicaNegocio.VO.Compartidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public NombreCompleto NombreCompleto { get; set; }
        public Pais Nacionalidad { get; set; }

        public Autor(NombreCompleto nombreCompleto, Pais nacionalidad)
        {
         
            NombreCompleto = nombreCompleto;
            Nacionalidad = nacionalidad;
        }

        public Autor()
        {
            
        }
    }
}
