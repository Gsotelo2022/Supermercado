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

        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Entidades.Usuario objUsuario = new Entidades.Usuario()
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
            }
        }
    }
}
