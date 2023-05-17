using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Producto
    {
        /*Traigo los productos*/
        public DataTable retornarProductos() { 
            Datos.Producto objDatos = new Datos.Producto();
            return objDatos.Listado();
        }


        /*Metodo para actualizar cantidad*/
        public void actualizarCantidad() {
            N_Carga_Stock objCarga = new N_Carga_Stock();
			objCarga.cargarStock();
		}
    }
}
