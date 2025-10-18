using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA_U202321121_TemaA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            FrmPlatos form = new FrmPlatos();// Crea una instancia del formulario de platos
            form.Show();// Muestra el formulario de platos
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes form = new FrmReportes(); // Crea una instancia del formulario de reportes
            form.Show();// Muestra el formulario de reportes
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario principal y termina la aplicación
        }
    }
}
