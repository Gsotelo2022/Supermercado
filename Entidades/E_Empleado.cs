using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Empleado : E_Persona
	{
		private int _legajo;

		public int Legajo
		{
			get { return _legajo; }
			set { _legajo = value; }
		}

	}
}
