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
        public DataTable RetornarProductos() { 
            Datos.D_Producto objDatos = new Datos.D_Producto();
            return objDatos.Listado();
        }
        //Busco Producto
        public DataTable BuscarProducto(string descripcion)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.DevuelvoProducto(descripcion);
        }
        //Busco productos en alerta
        public DataTable ProductoAlerta()
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.DevuelvoProductoEnAlerta();
        }
        public void CrearProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();
            objProductoDatos.RecibirDatosProducto(objProducto);
        }

        public void ModificarProducto(E_Producto objE_Producto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos= new D_Producto();
            objProductosDatos.ActualizarValores(objE_Producto);
        }

        public void CargarStock(E_Producto objEProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos = new D_Producto();
            objProductosDatos.ActualizarStock(objEProducto);
        }
    }
}
