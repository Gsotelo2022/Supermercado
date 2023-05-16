using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
		private int _id_Prodcuto;

		public int Id_Producto
		{
			get { return _id_Prodcuto; }
			set { _id_Prodcuto = value; }
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

		private bool _habilitado;

		public bool Habilitado
		{
			get { return _habilitado; }
			set { _habilitado = value; }
		}		
	}
}
