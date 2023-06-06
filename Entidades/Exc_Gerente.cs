using System;

namespace Entidades
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

