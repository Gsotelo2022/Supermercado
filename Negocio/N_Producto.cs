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
        //Busco productos en alerta
        public DataTable productoAlerta()
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.devuelvoProductoEnAlerta();
        }
        public void crearProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();
            objProductoDatos.recibirDatosProducto(objProducto);
        }

        public void modificarProducto(E_Producto objE_Producto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos= new D_Producto();
            objProductosDatos.actualizarValores(objE_Producto);
        }

        public void cargarStock(E_Producto objEProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos = new D_Producto();
            objProductosDatos.actualizarStock(objEProducto);
        }
    }
}
