﻿using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.Mappers
{
    public class MapperGenero
    {
        public static Genero FromDtoAltaGenero(DTOAltaGenero dto)
        {

            Genero genero = new Genero(dto.Nombre, dto.EdadMinima);
          
            return genero;
        }


        public static List<DTOGenero> FromListGeneroToListDtoGenero(List<Genero> generos)
        {

            List<DTOGenero> ret = new List<DTOGenero>();

            foreach (Genero genero in generos)
            {

                DTOGenero dto = new DTOGenero();
                dto.Id = genero.Id;
                dto.Nombre = genero.Nombre;
                dto.EdadMinima = genero.EdadMinima;
                if (genero.EdadMinima > 17)
                {
                    dto.ATP = false;
                }
                else {
                    dto.ATP = true;
                }
                ret.Add(dto);
            }
            return ret;

        }
    }
}
