using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Cliente : E_Persona
	{
		private DateTime _fechaDeRegistro;

		public DateTime FechaDeRegistro

		{
			get { return _fechaDeRegistro; }
			set { _fechaDeRegistro = value; }
		}
	}
}
