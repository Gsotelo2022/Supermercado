using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Factura
    {
		private int _idFactura;

		public int IdFactura
		{
			get { return _idFactura; }
			set { _idFactura = value; }
		}


		private E_OrdenDeCompra _compra;

		public E_OrdenDeCompra Compra

		{
			get { return _compra; }
			set { _compra = value; }
		}
	}
}
