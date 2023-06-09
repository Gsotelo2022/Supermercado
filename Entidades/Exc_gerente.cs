using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Exc_gerente
    {
        public class Exc_Gerente : Exception
        {
            #region ATRIBUTOS

            private string mensaje;

            #endregion

            /// <summary>
            /// Constructor: Instancia el valor de la variabel local de la clase.
            /// </summary>
            /// <param name="texto"></param>
            public Exc_Gerente(string texto)
            {
                this.Mensaje = texto;
            }

            #region PROPIEDADES

            public string Mensaje
            {
                get { return mensaje; }
                set { mensaje = value; }
            }

            #endregion
        }
    }
}
