using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_OrdenDetalle
    {
		private int _idOrdenDetalle;

		public int IdOrdenDetalle
		{
			get { return _idOrdenDetalle; }
			set { _idOrdenDetalle = value; }
		}


		private E_Producto _producto;

		public E_Producto Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}


		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}



		private double _subtotal;

		public double Subtotal
		{
			get { return _subtotal; }
			set { _subtotal = value; }
		}
	}
}
