using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExcepcionDeGerente : Exception
    {
        #region ATRIBUTOS

        private string mensaje;

        #endregion

        /// <summary>
        /// Constructor: Instancia el valor de la variabel local de la clase.
        /// </summary>
        /// <param name="texto"></param>
        public ExcepcionDeGerente(string texto)
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
