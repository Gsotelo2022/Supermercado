using System;
using System.Windows.Forms;

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
            /*Entidades.Usuario objUsuario = new Entidades.Usuario()
            {
                Nombre = txtBoxUser.Text,
                Contraseña = txtBoxPass.Text
            };

            Negocio.Usuario gestorUsuario = new Negocio.Usuario();

            try
            {
                if (gestorUsuario.ValidarUsuario(objUsuario))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña inválidos.");
                }
            }
            catch (Entidades.ExcepcionNegocio exPers)
            {
                MessageBox.Show(exPers.Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió una Exception: " + ex.Message);
            }*/

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
                if (usuario == "GracielaFarias" && password == "gf123")
                {
                    iniciar_sesion(1);
                }
                else if (usuario == "DelfinaGomez" && password == "dg123")
                {
                    iniciar_sesion(2);
                }
                else if (usuario == "GabrielSotelo" && password == "gs123")
                {
                    iniciar_sesion(3);
                }
                else if (usuario == "GabrielDella" && password == "gd123")
                {
                    iniciar_sesion(4);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                    //Application.Exit();
                }

                //this.Hide();
            }
        }

        #endregion

        #endregion

        #region MÉTODOS PRIVADOS

        private void iniciar_sesion(int codigo)
        {
            this.Hide();
            new Form_Principal(codigo).Show();
        }

        #endregion
    }
}
