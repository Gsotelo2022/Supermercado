using System;
using System.Windows.Forms;

//Incorporo el espacio de nombre System.Data.SqlClient
using System.Data.SqlClient;
using System.Data;
using Entidades;
using Negocio;

namespace Supermercado
{
    public partial class Form_Login : Form
    {




        /// <summary>
        /// Constructor
        /// </summary>
        public Form_Login()
        {
            InitializeComponent();
        }

        #region EVENTOS

        #region Mostrar Clave

        /// <summary>
        /// Cada vez que cambia el estado del check se muestra o no el contenido de la clave.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBoxClave_CheckedChanged(object sender, EventArgs e)
        {
            string _text = this.txtBoxPass.Text;

            if (this.chkBoxClave.Checked)
            {
                this.txtBoxPass.UseSystemPasswordChar = false;
                this.txtBoxPass.Text = _text;
            }
            else
            {
                this.txtBoxPass.UseSystemPasswordChar = true;
                this.txtBoxPass.Text = _text;
            }
        }

        #endregion

        #region Botón Salir

        /// <summary>
        /// Cierra el formulario de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Botón Minimizar

        /// <summary>
        /// Minimiza el formulario de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Botón Ingresar

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usuario, password;

            usuario = txtBoxUser.Text;
            password = txtBoxPass.Text;





            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe completar el campo: Usuario.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe completar el campo: Clave.");
            }
            else
            {
                N_Usuario nUsuario = new N_Usuario();
                DataTable dtUsuario = nUsuario.ValidarUsuario(usuario, password);


                if (dtUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("La búsqueda no obtuvo coincidencias....");

                    return;
                }
                else
                {
                    DataRow fila = dtUsuario.Rows[0];

                    E_Empleado unEmpleado = new E_Empleado();

                    unEmpleado.Dni = Convert.ToInt64(fila[0]);
                    unEmpleado.Nombre = fila[1].ToString();
                    unEmpleado.Apellido = fila[2].ToString();
                    unEmpleado.Cuil = Convert.ToInt64(fila[3]);
                    unEmpleado.Direccion = fila[4].ToString();
                    unEmpleado.Telefono = Convert.ToInt64(fila[5]);
                    unEmpleado.Legajo = Convert.ToInt32(fila[6]);


                    E_Usuario unUsuario = new E_Usuario();

                    unUsuario.IdUsuario = Convert.ToInt32(fila[7]);
                    unUsuario.Nombre = fila[8].ToString();
                    unUsuario.Password = fila[9].ToString();
                    unUsuario.Rol = fila[10].ToString();
                    unUsuario.EmpleadoDatos = unEmpleado;

                    this.Iniciar_Sesion(unUsuario);

                }



            }



        }

        #endregion

        #endregion

        #region MÉTODOS PRIVADOS

        private void Iniciar_Sesion(E_Usuario unUsuario)
        {
            this.Hide();
            new Form_Principal(unUsuario).Show();
        }

        #endregion

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
