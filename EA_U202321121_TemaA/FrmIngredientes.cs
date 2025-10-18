using EA_U202321121_TemaA.Entities;
using EA_U202321121_TemaA.Repositories;
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
    public partial class FrmIngredientes : Form
    {
        private IngredienteRepository ingredienteService = new IngredienteRepository();
        private string codigoPlato;
        public FrmIngredientes(string codigoplato)
        {
            InitializeComponent();
            codigoPlato = codigoplato;
        }

        private void btnRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            if (txtCodigoIngrediente.Text == "" || txtNombreIngrediente.Text == "" || cmbTipoIngrediente.Text == "" || txtCantidadIngrediente.Text == "")
            {
                MessageBox.Show("Faltan datos por completar");
            }
            Ingrediente ingrediente = new Ingrediente();
            {
                ingrediente.Codigo = txtCodigoIngrediente.Text;
                ingrediente.Nombre = txtNombreIngrediente.Text;
                ingrediente.TipoIngrediente = cmbTipoIngrediente.Text;
                ingrediente.CantidadKG = double.Parse(txtCantidadIngrediente.Text);
            }
            ;
            bool registrado = ingredienteService.RegistrarIngrediente(codigoPlato, ingrediente);
            if (!registrado)
            {
                MessageBox.Show("El ingrediente ya existe");
                return;
            }
            MostrarIngredientes(ingredienteService.MostrarIngredientes(codigoPlato));
        }
        //Maneja el dgvListadoPlatos para mostrar los platos registrados
        private void MostrarIngredientes(List<Ingrediente> ingredientes)
        {
            dgvListadoIngredientes.DataSource = null;
            if (ingredientes.Count == 0)
            {
                return;
            }
            dgvListadoIngredientes.DataSource = ingredientes;
        }
    }
}
