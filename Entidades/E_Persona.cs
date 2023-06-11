using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Persona
    {
		private long _dni;

		public long Dni
		{
			get { return _dni; }
			set { _dni = value; }
		}


		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}


		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}


		private long _cuil;

		public long Cuil

		{
			get { return _cuil; }
			set { _cuil = value; }
		}

		private long _telefono;

		public long Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}


		private string _direccion;

		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}
	}
}
