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
    public partial class FrmReportes : Form
    {
        private PlatoService platoService = new PlatoService();
        public FrmReportes()
        {
            InitializeComponent();
        }
        private void Mostrar(List<Plato> platos)
        {
            dgvResultadosReporte.DataSource = null;
            if (platos.Count == 0)
            {
                return;
            }
            dgvResultadosReporte.DataSource = platos;
        }

        private void btnEjecutarReporte_Click(object sender, EventArgs e)
        {
            switch(cmbSeleccionReporte.Text)
            {
                case "Listar los platos especiales ordenándolos ascendentemente por su precio de venta":
                    Mostrar(platoService.MostrarPlatosPorPrecio());
                    break;
                case "Listar el o los platos especiales con el mayor número de ingredientes frescos":
                    Mostrar(platoService.PlatosMayorIngredientes());
                    break;
                case "Listar el o los platos de Cocina Peruana con ingredientes frescos que tienen una cantidad disponible menor a 1 kg":
                    Mostrar(platoService.PlatosCocinaPeruana());
                    break;
                case "Listar el o los platos especiales con el menor número de ingredientes de tipo Pescado":
                    Mostrar(platoService.PlatosConMenorIngredientePescado());
                    break;
            }
        }
    }
}
