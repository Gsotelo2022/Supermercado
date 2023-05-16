using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carga_Stock
    {
		private int _id_Stock;

		public int Id_Stock
		{
			get { return _id_Stock; }
			set { _id_Stock = value; }
		}
		private Producto Id_Producto;

		public Producto MyProperty
		{
			get { return Id_Producto; }
			set { Id_Producto = value; }
		}
		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}
		private DateTime _fecha_Carga;

		public DateTime Fecha_Carga
		{
			get { return _fecha_Carga; }
			set { _fecha_Carga = value; }
		}
	}
}
