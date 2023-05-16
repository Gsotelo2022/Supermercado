using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Producto
    {
        /*Metodo para actualizar cantidad*/
        public void actualizarCantidad() {
            N_Carga_Stock objCarga = new N_Carga_Stock();
			objCarga.cargarStock();
		}
    }
}
