using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Factura
    {
        E_Factura objEFactura = new E_Factura();

        public string Imprimir(E_Factura objEFactura)
        {

            this.objEFactura = objEFactura;

            string _empresa = "SUPERDIA SRL";
            string _cajero = objEFactura.Compra.Cajero.IdUsuario.ToString();
            string _clienteDni = objEFactura.Compra.Cliente.Dni.ToString();
            string _fecha = objEFactura.Compra.Fecha.ToString();
            string _total = objEFactura.Compra.Total.ToString();

            string _textoFactura = "Empresa : " + _empresa + System.Environment.NewLine +
                                   "Fecha   : " + _fecha + System.Environment.NewLine +
                                   "Cajero  : " + _cajero + System.Environment.NewLine +
                                   "Cliente : " + _clienteDni + System.Environment.NewLine +
                                   "Total   : " + "$" + _total + System.Environment.NewLine;


            return _textoFactura;
        }

        public void GuardarFactura()
        {

            D_Factura objDFactura = new D_Factura();

            int _idFactura = objDFactura.CrearFactura(this.objEFactura);

            D_OrdenDetalle objDOrdenDetalle = new D_OrdenDetalle();

            foreach (E_OrdenDetalle unaOrden in this.objEFactura.Compra.Detalle)
            {
                objDOrdenDetalle.GuardarOrdenDetalle(unaOrden, _idFactura);
            }

        }
    }
}
