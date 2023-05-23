using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Producto
    {
        /*Traigo los productos*/
        public DataTable retornarProductos() { 
            Datos.D_Producto objDatos = new Datos.D_Producto();
            return objDatos.Listado();
        }
        //Busco Producto
        public DataTable BuscarProducto(string descripcion)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.devuelvoProducto(descripcion);
        }

        /*Metodo para actualizar cantidad*/
        public void actualizarCantidad() {
            N_Carga_Stock objCarga = new N_Carga_Stock();
			objCarga.cargarStock();            
        }

        public void crearProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();
            objProductoDatos.recibirDatosProducto(objProducto);
        }
    }
}
