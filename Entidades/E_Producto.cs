using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Producto
    {
		private int _idProdcuto;

		public int IdProducto
		{
			get { return _idProdcuto; }
			set { _idProdcuto = value; }
		}
		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		private double _precio;

		public double Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}
		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

		private string _habilitado;

		public string Habilitado
		{
			get { return _habilitado; }
			set { _habilitado = value; }
		}
    }
}
