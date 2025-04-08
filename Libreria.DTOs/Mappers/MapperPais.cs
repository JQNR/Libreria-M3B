using Libreria.DTOs.DTOs.DTOsPais;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.Mappers
{
    public class MapperPais
    {
        public static Pais FromDTOPaisToPais(DTOAltaPais dto)
        {
            Pais ret = new Pais();
            ret.Nombre = dto.Nombre;
            ret.Codigo = dto.Codigo;
            return ret;
        }

        public static List<DTOPais> FromListPaisToListDtoPais(List<Pais> paises)
        {
            List<DTOPais> ret = new List<DTOPais>();

            foreach (Pais pais in paises) {
                DTOPais p = new DTOPais();
                p.Nombre = pais.Nombre;
                p.Codigo = pais.Codigo;
                p.Id = pais.Id;
                ret.Add(p);
            }
            return ret;


        }
    }
}
