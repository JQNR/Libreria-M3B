using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }

        public DetalleVenta()
        {
            
        }
        public DetalleVenta(Libro libro, decimal precioUnidad, int cantidad)
        {

            Libro = libro;
            PrecioUnidad = precioUnidad;
            Cantidad = cantidad;
        }

        public decimal MontoPagado()
        {
            return PrecioUnidad * Cantidad;

        }
    }
}
