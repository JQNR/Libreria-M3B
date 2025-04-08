using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int VendedorId { get; set; }
        public Usuario Vendedor { get; set; }

        public int ClienteId { get; set; }
        public Usuario Cliente{ get; set; }
        public List<DetalleVenta> Carrito { get; set; }

        public Venta( Usuario vendedor, Usuario cliente)
        {
            Fecha = DateTime.Now;
            Vendedor = vendedor;
            Cliente = cliente;
            Carrito = new List<DetalleVenta>();
        }
        public Venta()
        {
            Fecha = DateTime.Now;
            Carrito = new List<DetalleVenta>();
        }
        public decimal PrecioFinal() {
            decimal ret = 0;

            foreach (var item in Carrito) {
                ret += item.MontoPagado();
            }
            return ret;
        }

    }
}
