using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
		private int _idUsuario;

		public int IdUsuario
		{
			get { return _idUsuario; }
			set { _idUsuario = value; }
		}

		private string _rol;

		public string Rol
		{
			get { return _rol; }
			set { _rol = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private E_Empleado _empleadoDatos;

		public E_Empleado EmpleadoDatos
		{
			get { return _empleadoDatos; }
			set { _empleadoDatos = value; }
		}


	}
}
