using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_OrdenDeCompra
    {
		private int _idOrdenDeCompra;

		public int IdOrdenDeCompra
		{
			get { return _idOrdenDeCompra; }
			set { _idOrdenDeCompra = value; }
		}


		private List<E_OrdenDetalle> _detalle;

		public List<E_OrdenDetalle> Detalle
		{
			get { return _detalle; }
			set { _detalle = value; }
		}


		private DateTime _fecha;

		public DateTime Fecha
		{
			get { return _fecha; }
			set { _fecha = value; }
		}

		private double _total;

		public double Total
		{
			get { return _total; }
			set { _total = value; }
		}

		private E_Usuario _cajero;

		public E_Usuario Cajero
		{
			get { return _cajero; }
			set { _cajero = value; }
		}


		private E_Cliente _cliente;

		public E_Cliente Cliente
		{
			get { return _cliente; }
			set { _cliente = value; }
		}

		public E_OrdenDeCompra()
		{
			this.Detalle = new List<E_OrdenDetalle>();
		}
	}
}
