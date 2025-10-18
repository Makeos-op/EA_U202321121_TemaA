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
    public partial class FrmPlatos : Form
    {
        private PlatoRepository platoService = new PlatoRepository(); //Instancia del repositorio de platos
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
            if (txtCodigoPlato.Text == ""||txtNombrePlato.Text==""||cmbTipoPlato.Text==""||txtPrecioPlato.Text=="") //Verifica si hay campos vacíos
            {
                MessageBox.Show("Faltan datos por completar");//Muestra un mensaje de error
                return;//Sale del método
            }
            if (double.Parse(txtPrecioPlato.Text) < 0)
            {
                MessageBox.Show("No se admiten valores Negativos");
                return;
            }
            Plato plato = new Plato(); //Crea un nuevo objeto Plato
            {
                plato.Nombre = txtNombrePlato.Text; // Asigna los valores de los controles al objeto Plato
                plato.TipoCocina = cmbTipoPlato.Text;
                plato.Precio = int.Parse(txtPrecioPlato.Text); //Convierte el texto a entero
                switch (cmbTipoPlato.Text) //Asigna el código del plato según el tipo de cocina
                {
                    case "Peruana":
                        plato.Codigo = "PER" +"-"+ txtCodigoPlato.Text; //Concatena el prefijo con el código ingresado
                        break;
                    case "Internacional":
                        plato.Codigo = "INT" +"-"+ txtCodigoPlato.Text; //Concatena el prefijo con el código ingresado
                        break;
                    case "Fusión":
                        plato.Codigo = "FUS" +"-"+ txtCodigoPlato.Text; //Concatena el prefijo con el código ingresado
                        break;
                    case "Vegetariana":
                        plato.Codigo = "VEG" +"-"+ txtCodigoPlato.Text; //Concatena el prefijo con el código ingresado
                        break;
                }
                platoService.RegistrarPlato(plato); //Registra el plato usando el servicio
                MostrarPlatos(PlatoRepository.MostrarPlatos()); //Muestra la lista actualizada de platos
            }
            ;
        }
        //Maneja el dgvListadoPlatos para mostrar los platos registrados
        private void MostrarPlatos(List<Plato> platos) //Recibe una lista de platos
        {
            dgvListadoPlatos.DataSource = null; //Limpia el origen de datos del DataGridView
            if (platos.Count==0) //Verifica si la lista está vacía
            {
                return; //Sale del método
            }
            dgvListadoPlatos.DataSource = platos; //Asigna la lista de platos como origen de datos del DataGridView
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
