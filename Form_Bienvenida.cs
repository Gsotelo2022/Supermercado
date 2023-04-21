using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form_Bienvenida : Form
    {
        public Form_Bienvenida()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);

            if (progressBar.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
        }

    }
}
