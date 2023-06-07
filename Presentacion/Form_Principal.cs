using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermercado
{
    public partial class Form_Principal : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public Form_Principal(int codigo)
        {
            InitializeComponent();

            switch (codigo)
            {
                case 1:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                case 2:
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                case 3:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    break;
                case 4:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                default: break;
            }
        }

        #region EVENTOS

        /// <summary>
        /// Cuando el Formulario Principal se cierra, se cierra toda la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion



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

            dgvProductos.DataSource = objProducto.RetornarProductos();
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
    }
}
