using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_OrdenDeCompra
    {
        public void AgregarDetalle(E_OrdenDeCompra e_OrdenDeCompra, E_OrdenDetalle e_OrdenDetalle)
        {
            e_OrdenDeCompra.Detalle.Add(e_OrdenDetalle);
        }

        private E_OrdenDeCompra CalcularTotal(E_OrdenDeCompra e_OrdenDeCompra)
        {
            e_OrdenDeCompra.Total = 0;

            foreach (E_OrdenDetalle unDetalle in e_OrdenDeCompra.Detalle)
            {
                e_OrdenDeCompra.Total += unDetalle.Subtotal;

            }

            return e_OrdenDeCompra;
        }


        public E_OrdenDeCompra DevolverTotal(E_OrdenDeCompra e_OrdenDeCompra)
        {
            return this.CalcularTotal(e_OrdenDeCompra);
        }
    }
}
