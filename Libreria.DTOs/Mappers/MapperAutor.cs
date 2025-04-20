using Libreria.DTOs.DTOs.DTOsAutor;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.VO.Compartidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.Mappers
{
    public class MapperAutor
    {
        public static Autor FromAltaAutorToAutor(DTOAltaAutor dto)
        {
            Autor autor = new Autor();
            autor.NombreCompleto = new NombreCompleto(dto.Nombre, dto.Apellido);
            autor.Nacionalidad = new Pais() { Id = dto.PaisId };//Esto requiere  para el alta de Autor 
            return autor;
        }

        public static List<DTOAutor> FromListToListDto(List<Autor> autors)
        {
            List<DTOAutor> listaDto = autors
                .Select(a => new DTOAutor
                {
                    Id = a.Id,
                    Nombre = a.NombreCompleto.ToString(),
                    Nacionalidad = a.Nacionalidad.Nombre
                })
                .ToList();
            return listaDto;
        }
    }
}
