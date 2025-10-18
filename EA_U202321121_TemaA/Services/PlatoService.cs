using EA_U202321121_TemaA.Entities;
using EA_U202321121_TemaA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Services
{
    internal class PlatoService
    {
        private PlatoRepository platoRepository = new PlatoRepository();
        public bool RegistrarPlato(Plato plato)
        {
           return platoRepository.RegistrarPlato(plato); 
        }
        // Mostrar
        public static List<Plato> MostrarPlatos()
        {
            return PlatoRepository.MostrarPlatos(); // PlatoRepository por la lista estatica
        }

        public List<Plato> MostrarPlatosPorPrecio()
        {
            return platoRepository.MostrarPlatosPorPrecio(); 
        }
        public List<Plato> PlatosMayorIngredientes()
        {
            return platoRepository.PlatosMayorIngredientes();
        }
        public List<Plato> PlatosCocinaPeruana()
        {
            return platoRepository.PlatosCocinaPeruana();
        }
        public List<Plato> PlatosConMenorIngredientePescado()
        {
            return platoRepository.PlatosConMenorIngredientePescado();
        }
    }
}
