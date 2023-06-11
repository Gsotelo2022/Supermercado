using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_OrdenDetalle
    {
        private E_OrdenDetalle CalcularSubtotal(E_OrdenDetalle objEOrdenDetalle)
        {
            objEOrdenDetalle.Subtotal = objEOrdenDetalle.Producto.Precio * objEOrdenDetalle.Cantidad;

            return objEOrdenDetalle;
        }


        public E_OrdenDetalle DevolverSubtotal(E_OrdenDetalle objEOrdenDetalle)
        {
            return this.CalcularSubtotal(objEOrdenDetalle);
        }
    }
}
