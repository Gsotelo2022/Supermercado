using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ExcepcionesProductos
{
    public class Exproductos
    {        
        public void Exproducto() { 
        }
        public static void verificarCampos(string _descripcion, double _precio, int _cantidad, string _habilitado)
        {
            //Descripcion
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("No ingresó Descripción del producto");
            }
            //Precio
            if (_precio <= 0)
            {
                throw new Exception("El precio del producto no es válido");
            }
            //Cantidad
            if (_cantidad <= 0)
            {
                throw new Exception("La cantidad del producto no es válida");
            }
            //Descripcion
            if (string.IsNullOrEmpty(_habilitado))
            {
                throw new Exception("No definio si el producto esta Habilitado o no");
            }
        }

        public static void verificarCamposCargaStock(int Id , int _cantidad)
        {
            //Descripcion
            if (Id <= 0)
            {
                throw new Exception("No ingresó Descripción del producto");
            }
            //Cantidad
            if (_cantidad <= 0)
            {
                throw new Exception("La cantidad del producto no es válida");
            }
        }

    }
}
