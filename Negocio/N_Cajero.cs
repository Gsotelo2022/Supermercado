using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Cajero
    {
        public DataTable ValidarCliente(int unDni)
        {
            D_Cliente dCliente = new D_Cliente();

            return dCliente.BuscarCliente(unDni);
        }

        public void CrearCliente(E_Cliente uncliente)
        {
            D_Cliente dCliente = new D_Cliente();

            dCliente.CrearCliente(uncliente);
        }

        public void ModificaCliente(E_Cliente unCliente)
        {
            D_Cliente dCliente = new D_Cliente();

            dCliente.ModificarCliente(unCliente);
        }


        public E_OrdenDeCompra CrearOrdenDeCompra()
        {

            return new E_OrdenDeCompra();
        }

        public E_Factura CrearFactura(E_OrdenDeCompra objEOrdenDeCompra)
        {

            E_Factura objEFactura = new E_Factura();
            objEFactura.Compra = objEOrdenDeCompra;

            return objEFactura;
        }
    }
}
