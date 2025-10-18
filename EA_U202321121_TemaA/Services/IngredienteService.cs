using EA_U202321121_TemaA.Entities;
using EA_U202321121_TemaA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Services
{
    internal class IngredienteService
    {
        //Objeto de la clase IngredienteRepository
        private IngredienteRepository ingredienteRepository = new IngredienteRepository();
        public bool RegistrarIngrediente(string CodigoPlato, Ingrediente ingrediente)
        {
            return ingredienteRepository.RegistrarIngrediente(CodigoPlato, ingrediente);
        }
        // Mostrar
        public List<Ingrediente> MostrarIngredientes(string codigoPlato)
        {
            return ingredienteRepository.MostrarIngredientes(codigoPlato);
        }
    }
}
