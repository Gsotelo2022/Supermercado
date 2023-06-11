using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermercado
{
    public partial class Form_Principal : Form
    {
        E_Cliente objECliente = new E_Cliente();
        E_Usuario objEUsuario;
        /// <summary>
        /// Constructor
        /// </summary>
        public Form_Principal(E_Usuario unUsuario)
        {
            InitializeComponent();
            this.objEUsuario = unUsuario;


            if (unUsuario.Rol == "ADMINISTRADOR")
            {


                this.tabControl1.TabPages.Remove(tabVendedor);
                this.tabControl1.TabPages.Remove(tabGerente);
                this.tabControl1.TabPages.Remove(tabEncargado);

                unUsuario = new E_Administrador();
            }
            else if (unUsuario.Rol == "GERENTE")
            {


                this.tabControl1.TabPages.Remove(tabVendedor);
                this.tabControl1.TabPages.Remove(tabAdmin);
                this.tabControl1.TabPages.Remove(tabEncargado);

                unUsuario = new E_Gerente();
            }
            else if (unUsuario.Rol == "ENCARGADO")
            {


                this.tabControl1.TabPages.Remove(tabGerente);
                this.tabControl1.TabPages.Remove(tabVendedor);
                this.tabControl1.TabPages.Remove(tabAdmin);

                unUsuario = new E_Encargado();
            }
            else if (unUsuario.Rol == "CAJERO")
            {

                this.tabControl1.TabPages.Remove(tabGerente);
                this.tabControl1.TabPages.Remove(tabAdmin);
                this.tabControl1.TabPages.Remove(tabEncargado);

                unUsuario = new E_Cajero();


            }
        }

        /// <summary>
        /// Cuando el Formulario Principal se cierra, se cierra toda la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Gerente

        #region EVENTOS

        /// <summary>
        /// Desencadena la busqueda de ventas por mes y año.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXMes_Click(object sender, EventArgs e)
        {
            Negocio.N_Gerente gerenteNeg = new Negocio.N_Gerente();

            int añoSelect = 0;
            string mesSelect = this.cmbBoxMeses.SelectedItem.ToString();
            int mesSelectNum = 0;

            try
            {
                switch (mesSelect)
                {
                    case "ENERO":
                        mesSelectNum = (int)Entidades.Dias.ENERO;
                        break;
                    case "FEBRERO":
                        mesSelectNum = (int)Entidades.Dias.FEBRERO;
                        break;
                    case "MARZO":
                        mesSelectNum = (int)Entidades.Dias.MARZO;
                        break;
                    case "ABRIL":
                        mesSelectNum = (int)Entidades.Dias.ABRIL;
                        break;
                    case "MAYO":
                        mesSelectNum = (int)Entidades.Dias.MAYO;
                        break;
                    case "JUNIO":
                        mesSelectNum = (int)Entidades.Dias.JUNIO;
                        break;
                    case "JULIO":
                        mesSelectNum = (int)Entidades.Dias.JULIO;
                        break;
                    case "AGOSTO":
                        mesSelectNum = (int)Entidades.Dias.AGOSTO;
                        break;
                    case "SEPTIEMBRE":
                        mesSelectNum = (int)Entidades.Dias.SEPTIEMBRE;
                        break;
                    case "OCTUBRE":
                        mesSelectNum = (int)Entidades.Dias.OCTUBRE;
                        break;
                    case "NOVIEMBRE":
                        mesSelectNum = (int)Entidades.Dias.NOVIEMBRE;
                        break;
                    case "DICIEMBRE":
                        mesSelectNum = (int)Entidades.Dias.DICIEMBRE;
                        break;
                }


                if (string.IsNullOrEmpty(this.txtBoxAño.Text))
                {
                    throw new Entidades.Exc_Negocio("Debe escribir un año antes de continuar.");
                }
                else
                {
                    añoSelect = int.Parse(this.txtBoxAño.Text);
                }

                this.dtGridPorMes.DataSource = gerenteNeg.CrearReporteDeVentasPorMes(mesSelectNum, añoSelect);
            }
            catch (Entidades.Exc_Negocio exc)
            {
                MessageBox.Show(exc.Mensaje);

                this.dtGridPorMes.DataSource = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por semana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXSem_Click(object sender, EventArgs e)
        {
            Negocio.N_Gerente gerenteNeg = new Negocio.N_Gerente();

            DateTime desde = this.dtPickerDesde.Value;
            DateTime hasta = this.dtPickerHasta.Value;

            try
            {
                this.dtGridPorSem.DataSource = gerenteNeg.CrearReporteDeVentasPorSemana(desde, hasta);
            }
            catch (Entidades.Exc_Negocio exc)
            {
                MessageBox.Show(exc.Mensaje);

                this.dtGridPorSem.DataSource = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXVend_Click(object sender, EventArgs e)
        {
            Negocio.N_Gerente gerenteNeg = new Negocio.N_Gerente();

            string vendSelect = this.cmbBoxVendedor.SelectedItem.ToString();
            int usuarioId = int.Parse(vendSelect.Split('-')[0].Split(' ')[0]);

            try
            {
                this.dtGridPorVend.DataSource = gerenteNeg.CrearReporteDeVentasPorVendedor(usuarioId);
            }
            catch (Entidades.Exc_Negocio exc)
            {
                MessageBox.Show(exc.Mensaje);

                this.dtGridPorVend.DataSource = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        #endregion

        #region MÉTODOS PRIVADOS

        /// <summary>
        /// Carga los controles para que el usuario eliga los filtros deseados.
        /// </summary>
        private void CargarDatosEnGerente()
        {
            // Carga el cmbBox que filtra la búsqueda por meses.
            List<string> meses = new List<string>()
            {
                "ENERO",
                "FEBRERO",
                "MARZO",
                "ABRIL",
                "MAYO",
                "JUNIO",
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBRE"
            };

            this.cmbBoxMeses.DataSource = meses;
            cmbBoxMeses.SelectedIndex = 0;

            //Carga el cmbBox que filtra la búsqueda por vendedor.
            List<string> vendedores = new List<string>();
            // idUsuario - Nombre Apellido

            try
            {
                N_Usuario usuarioNeg = new N_Usuario();

                var empleados = usuarioNeg.retornarEmpleados();

                foreach (DataRow row in empleados.Rows)
                {
                    if (row["Rol"].ToString().Contains("CAJERO"))
                    {
                        vendedores.Add(row["Id_Usuario"] + "-" + row["Nombre"] + " " + row["Apellido"]);
                    }
                }

                cmbBoxVendedor.DataSource = vendedores;
                cmbBoxVendedor.SelectedIndex = 0;
            }
            catch (Exc_Negocio exc)
            {
                MessageBox.Show(exc.Mensaje);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        #endregion

        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            //Limpio campos
            txtDescripcion.Text = "";
            //txtPrecio.Text = "";
            nudPrecio.Text = "";
            nudCantidad.Text = "";
            cmbHabilitado.Text = "";
        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdModificar1.Text = dgvModificarProducto1.CurrentRow.Cells[0].Value.ToString();
            txtDescripcionModificar1.Text = dgvModificarProducto1.CurrentRow.Cells[1].Value.ToString();
            nudPrecioModificar1.Text = dgvModificarProducto1.CurrentRow.Cells[2].Value.ToString();
            nudCantidadModificar1.Text = dgvModificarProducto1.CurrentRow.Cells[3].Value.ToString();
            cmbHabilitadoModificar1.Text = dgvModificarProducto1.CurrentRow.Cells[4].Value.ToString();
        }        
        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoMP_Click(object sender, EventArgs e)
        {
            E_Producto objEProducto = new E_Producto();
            objEProducto.Descripcion = txtDescripcionModificar.Text;

            N_Producto objNProducto = new N_Producto();

            dgvModificarProducto1.DataSource = objNProducto.BuscarProducto(objEProducto.Descripcion);

            //Limpio Campo
            txtDescripcionModificar.Text = "";
        }

        private void btnLimpiarCamposMP_Click(object sender, EventArgs e)
        {
            //Descripcion del buscador
            txtDescripcionModificar.Text = "";
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            N_Producto objProducto = new N_Producto();
            N_Usuario objNUsuario = new N_Usuario();
            //E_Empleado objEEmpleado = new E_Empleado();


            dgvProductos.DataSource = objProducto.RetornarProductos();
            dgvListaEmpleados.DataSource = objNUsuario.listarEmpleados();

            N_Rol objNRol = new N_Rol();


            List<E_Rol> nombresRol = objNRol.RetornarRoles();

            cBoxPermisos.DataSource = nombresRol;
            cBoxPermisos.DisplayMember = "Nombre";


        }

        private void btnEncargadoCP_Click(object sender, EventArgs e)
        {
            //Instancio Entidad
            E_Producto objProducto = new E_Producto();
            //Instancio Negocio
            N_Producto objN_Producto = new N_Producto();

            //Excepciones
            try
            {
                //Valido que no hayan errores al ingresar los campos
                Negocio.ExcepcionesProductos.Exproductos.verificarCampos(txtDescripcion.Text, double.Parse(nudPrecio.Text), int.Parse(nudCantidad.Text), cmbHabilitado.Text);
                //Descripcion           
                objProducto.Descripcion = txtDescripcion.Text;                
                //Precio               
                objProducto.Precio = double.Parse(nudPrecio.Text);
                //Cantidad
                objProducto.Cantidad = int.Parse(nudCantidad.Text);                           
                //Habiitado
                objProducto.Habilitado = cmbHabilitado.Text;                
                //Creacion del producto                
                objN_Producto.CrearProducto(objProducto);
                dgvProductos.DataSource = objN_Producto.RetornarProductos();
                //Limpio campos
                txtDescripcion.Text = "";
                nudPrecio.Text = "";
                nudCantidad.Text = "";
                cmbHabilitado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            N_Producto objN_Producto = new N_Producto();
            dgvStock.DataSource = objN_Producto.RetornarProductos();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
    
        }

        private void btnBuscarProductoCS_Click(object sender, EventArgs e)
        {
            E_Producto objEProducto = new E_Producto(); 
            objEProducto.Descripcion=txtDescripcionBCargarStock.Text;

            N_Producto objNProducto= new N_Producto();             
            
            dgvCargarStock.DataSource = objNProducto.BuscarProducto(objEProducto.Descripcion);

            //Limpio Campo
            txtDescripcionBCargarStock.Text = "";
            //dgvStock.DataSource = objN_Producto.retornarProductos();
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            N_Producto objNProducto = new N_Producto();
            dgvAlerta.DataSource = objNProducto.ProductoAlerta();
        }

        private void btnModificarDatosProductoMP_Click(object sender, EventArgs e)
        {
            //Instancio Entidad
            E_Producto objE_Producto = new E_Producto();

            try
            {
                //Excepciones
                Negocio.ExcepcionesProductos.Exproductos.verificarCampos(txtDescripcionModificar1.Text, double.Parse(nudPrecioModificar1.Text), int.Parse(nudCantidadModificar1.Text), cmbHabilitadoModificar1.Text);
                //Asigno Id
                objE_Producto.IdProducto = int.Parse(txtIdModificar1.Text);
                //Asigno nueva descripcion
                objE_Producto.Descripcion = txtDescripcionModificar1.Text;
                //Asigno nuevo precio
                objE_Producto.Precio = double.Parse(nudPrecioModificar1.Text);
                //Asigno nuevo estado
                objE_Producto.Habilitado = cmbHabilitadoModificar1.Text;

                //Modificacion del producto
                N_Producto objNProducto = new N_Producto();
                objNProducto.ModificarProducto(objE_Producto);

                //Llenar Grilla
                dgvModificarProducto1.DataSource = objNProducto.RetornarProductos();

                //Limpio valores
                txtIdModificar1.Text = "";
                txtDescripcionModificar1.Text = "";
                nudPrecioModificar1.Text = "";
                nudCantidadModificar1.Text = "";
                cmbHabilitadoModificar1.Text = "";
                //Descripcion del buscador
                txtDescripcionModificar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCamposDatosProductoMP_Click(object sender, EventArgs e)
        {
            //Limpio valores
            txtIdModificar1.Text = "";
            txtDescripcionModificar1.Text = "";
            nudPrecioModificar1.Text = "";
            nudCantidadModificar1.Text = "";
            cmbHabilitadoModificar1.Text = "";
            //Descripcion del buscador
            txtDescripcionModificar.Text = "";
        }

        private void dgvCargarStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvCargarStock
            txtIdCargarStock1.Text = dgvCargarStock.CurrentRow.Cells[0].Value.ToString();
            txtDescripcionCargarStock1.Text = dgvCargarStock.CurrentRow.Cells[1].Value.ToString();
            //nudCantidadCargarStock1.Text= dgvCargarStock.CurrentRow.Cells[4].Value.ToString();
            if (txtDescripcionCargarStock1.Text == "")
            {
                nudCantidadCargarStock1.Enabled = false;
            }
            else
            {
                nudCantidadCargarStock1.Enabled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {       
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            E_Producto objEProducto = new E_Producto();
            //Excepcion Carga stock
            try
            {
                //Excepciones
                Negocio.ExcepcionesProductos.Exproductos.verificarCamposCargaStock(int.Parse(txtIdCargarStock1.Text), int.Parse(nudCantidadCargarStock1.Text));
                objEProducto.IdProducto = int.Parse(txtIdCargarStock1.Text);
                objEProducto.Cantidad = int.Parse(nudCantidadCargarStock1.Text);
                //Instancio Negocio
                N_Producto objNProdcuto = new N_Producto();
                objNProdcuto.CargarStock(objEProducto);
                dgvCargarStock.DataSource = objNProdcuto.RetornarProductos();

                //Limpiar campos 
                txtIdCargarStock1.Text = "";
                txtDescripcionCargarStock1.Text = "";
                nudCantidadCargarStock1.Text = "";
                //Limpio campo descripcion de la busqueda
                txtDescripcionBCargarStock.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarCamposCS_Click(object sender, EventArgs e)
        {
            //Limpiar campos 
            txtIdCargarStock1.Text = "";
            txtDescripcionCargarStock1.Text = "";
            nudCantidadCargarStock1.Text = "";
            //Limpio campo descripcion de la busqueda
            txtDescripcionBCargarStock.Text = "";
        }


        private void btnEncargadoLimpiarCamposCP_Click(object sender, EventArgs e)
        {
            //Limpio campos
            txtDescripcion.Text = "";
            //txtPrecio.Text = "";
            nudPrecio.Text = "";
            nudCantidad.Text = "";
            cmbHabilitado.Text = "";
        }
        private void dgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbLegajo.Text = dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo;
                if (!int.TryParse(txbLegajo.Text, out legajo))
                {
                    throw new Exc_Negocio("El campo Legajo no es un número válido");
                }

                if (!(cBoxPermisos.SelectedItem is Entidades.E_Rol rol) || rol == null)
                {
                    throw new Exc_Negocio("Seleccione un permiso válido");
                }

                int permiso = rol.Id;
                string nombreUsuario = txbNomUsuario.Text;
                if (!ValidarNoVacio(nombreUsuario, "nombre de usuario"))
                {
                    return;
                }

                string contraseña = txbContrasenia.Text;
                if (!ValidarNoVacio(contraseña, "contraseña"))
                {
                    return;
                }

                string reingresarContraseña = txbReingContr.Text;
                if (reingresarContraseña != contraseña)
                {
                    throw new Exc_Negocio("Debe reingresar la contraseña correctamente");
                }

                N_Usuario objNUsuario = new N_Usuario();
                string mensaje = objNUsuario.crearUsuario(legajo, permiso, nombreUsuario, contraseña);
                MessageBox.Show(mensaje);
            }
            catch (Exc_Negocio ex)
            {
                MessageBox.Show(ex.Mensaje);
            }

            bool ValidarNoVacio(string valor, string nombreCampo)
            {
                if (string.IsNullOrEmpty(valor))
                {
                    MessageBox.Show($"El campo {nombreCampo} no puede ser vacío");
                    return false;
                }
                return true;
            }
        }

        private void btnCancUsu_Click(object sender, EventArgs e)
        {
            txbNomUsuario.Text = "";
            txbContrasenia.Text = "";
            txbReingContr.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login loginForm = new Form_Login();
            loginForm.ShowDialog();
        }

        private void benerarCliente_btn_Click(object sender, EventArgs e)
        {

        }

        private void modificarcliente_btn_Click(object sender, EventArgs e)
        {

        }

        private void iniciarVenta_btn_Click(object sender, EventArgs e)
        {

        }

        private void buscarCliente_btn_Click(object sender, EventArgs e)
        {

        }

        private void benerarCliente_btn_Click_1(object sender, EventArgs e)
        {
            string apellidoTxt = this.apellidoCliente_tbx.Text;
            string nombreTxt = this.nombrCliente_tbx.Text;
            string dniTxt = this.dniCliente_tbx.Text;
            string cuilTxt = this.cuitCliente_tbx.Text;
            string telefonoTxt = this.telefonoCliente_tbx.Text;
            string direccionTxt = this.direccionCliente_tbx.Text;


            if (!this.ValidarApellYNombre(apellidoTxt))
            {
                MessageBox.Show("Apellido solo admite caracteres!!!");
                this.apellidoCliente_tbx.Text = " ";
                return;
            }

            if (!this.ValidarApellYNombre(nombreTxt))
            {
                MessageBox.Show("Nombre solo admite caracteres!!!");
                this.nombrCliente_tbx.Text = " ";
                return;
            }

            if (!this.validarDireccion(direccionTxt))
            {
                MessageBox.Show("Direccion solo admite caracteres!!!");
                this.direccionCliente_tbx.Text = " ";
                return;
            }

            try
            {
                long.Parse(dniTxt);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dni solo admite digitos!!!");
                this.dniCliente_tbx.Text = " ";
                return;
            }

            try
            {
                long.Parse(cuilTxt);

            }
            catch (FormatException)
            {
                MessageBox.Show("Cuil solo admite digitos!!!");
                this.cuitCliente_tbx.Text = " ";
                return;
            }

            try
            {
                int.Parse(telefonoTxt);
            }
            catch (FormatException)
            {
                MessageBox.Show("Telefonio solo admite digitos!!!");
                this.telefonoCliente_tbx.Text = " ";
                return;
            }

            E_Cliente nuevoCliente = new E_Cliente();

            nuevoCliente.Apellido = apellidoTxt;
            nuevoCliente.Nombre = nombreTxt;
            nuevoCliente.Dni = int.Parse(dniTxt);
            nuevoCliente.Cuil = int.Parse(cuilTxt);
            nuevoCliente.Telefono = int.Parse(telefonoTxt);
            nuevoCliente.Direccion = direccionTxt;


            objECliente = nuevoCliente;




            N_Cajero objNCajero = new N_Cajero();

            objNCajero.CrearCliente(nuevoCliente);

            MessageBox.Show("Se registró a " + nuevoCliente.Nombre + " " + nuevoCliente.Apellido + " con exito!!!");

            this.BorrarFormulario();
        }

        private void buscarCliente_btn_Click_1(object sender, EventArgs e)
        {
            string dniTxt = this.dni_tbx.Text;
            int dniCliente;

            if (String.IsNullOrWhiteSpace(dniTxt))
            {
                MessageBox.Show("Campo DNI con espacios o nulo!!!!");
                this.dni_tbx.Text = " ";
                return;
            }

            try
            {
                dniCliente = int.Parse(dniTxt);
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo DNI solo admite dígitos!!!!");
                this.dni_tbx.Text = " ";
                return;
            }


            N_Cajero objNCajero = new N_Cajero();

            DataTable dtCliente = objNCajero.ValidarCliente(dniCliente);

            if (dtCliente.Rows.Count == 0)
            {
                MessageBox.Show("La búsqueda no obtuvo Resultados!!!");
                this.dni_tbx.Text = " ";

                this.BorrarFormulario();
                return;
            }

            this.dbDatosCliente_dg.DataSource = dtCliente;

            DataRow fila = dtCliente.Rows[0];

            objECliente.Dni = Convert.ToInt32(fila["Dni"]);
            objECliente.Apellido = fila["Apellido"].ToString();
            objECliente.Nombre = fila["Nombre"].ToString();
            objECliente.Direccion = fila["Direccion"].ToString();
            objECliente.Telefono = Convert.ToInt32(fila["Telefono"]);
            objECliente.Cuil = Convert.ToInt32(fila["Cuil"]);
        }

        private void iniciarVenta_btn_Click_1(object sender, EventArgs e)
        {
            //AGREGAR CLIENTE GENÉRICO CON DNI = 1 y DESCOMENTAR

            /*if (String.IsNullOrEmpty(this.dniClienteBusqueda_tbx.Text)
                || String.IsNullOrWhiteSpace(this.dniClienteBusqueda_tbx.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente!!!");
                return;
            }*/

            new Form_Ventas(objEUsuario, objECliente).ShowDialog();
        }

        private void modificarcliente_btn_Click_1(object sender, EventArgs e)
        {
            if (this.dbDatosCliente_dg.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente!!!!!");
                return;
            }
            else
            {
                this.dbDatosCliente_dg.Rows.Remove(this.dbDatosCliente_dg.CurrentRow);
                new Form_ModCliente(objECliente).Show();
            }
        }
        private void BorrarFormulario()
        {
            this.apellidoCliente_tbx.Text = " ";
            this.nombrCliente_tbx.Text = " ";
            this.dniCliente_tbx.Text = " ";
            this.telefonoCliente_tbx.Text = " ";
            this.cuitCliente_tbx.Text = " ";
            this.direccionCliente_tbx.Text = " ";
        }

        private bool ValidarApellYNombre(string unString)
        {

            string patronNomApellido = @"^[A-Za-z\s]*$";

            return Regex.IsMatch(unString, patronNomApellido);
        }


        private bool validarDireccion(string unString)
        {
            string patronDireccion = @"^[A-Za-z0-9\s]*$";

            return Regex.IsMatch(unString, patronDireccion);
        }
    }
}
