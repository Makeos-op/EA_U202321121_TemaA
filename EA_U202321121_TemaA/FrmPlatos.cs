using EA_U202321121_TemaA.Entities;
using EA_U202321121_TemaA.Services;
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
    public partial class FrmPlatos : Form
    {
        private PlatoService platoService = new PlatoService();
        public FrmPlatos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPlato_Click(object sender, EventArgs e)
        {
            if (txtCodigoPlato.Text == ""||txtNombrePlato.Text==""||cmbTipoPlato.Text==""||txtPrecioPlato.Text=="")
            {
                MessageBox.Show("Faltan datos por completar");
            }
            Plato plato = new Plato();
            {
                plato.Nombre = txtNombrePlato.Text;
                plato.TipoCocina = cmbTipoPlato.Text;
                plato.Precio = int.Parse(txtPrecioPlato.Text);
                switch (cmbTipoPlato.Text)
                {
                    case "Peruana":
                        plato.Codigo = "PER" +"-"+ txtCodigoPlato.Text;
                        break;
                    case "Internacional":
                        plato.Codigo = "INT" +"-"+ txtCodigoPlato.Text;
                        break;
                    case "Fusión":
                        plato.Codigo = "FUS" +"-"+ txtCodigoPlato.Text;
                        break;
                    case "Vegetariana":
                        plato.Codigo = "VEG" +"-"+ txtCodigoPlato.Text;
                        break;
                }
                platoService.RegistrarPlato(plato);
                MostrarPlatos(PlatoService.MostrarPlatos());
            }
            ;
        }
        //Maneja el dgvListadoPlatos para mostrar los platos registrados
        private void MostrarPlatos(List<Plato> platos)
        {
            dgvListadoPlatos.DataSource = null;
            if (platos.Count==0)
            {
                return;
            }
            dgvListadoPlatos.DataSource = platos;
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            if (dgvListadoPlatos.SelectedRows.Count==0)//Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un plato para agregar ingredientes");
                return;
            }
            string codigoPlato = dgvListadoPlatos.SelectedRows[0].Cells["Codigo"].Value.ToString(); //Obtiene el código del plato seleccionado
            FrmIngredientes form = new FrmIngredientes(codigoPlato); //Pasa el código del plato al formulario de ingredientes
            form.Show();
        }
    }
}
