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
            FrmPlatos form = new FrmPlatos();
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes form = new FrmReportes();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
