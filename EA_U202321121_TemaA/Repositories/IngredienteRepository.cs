using EA_U202321121_TemaA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Repositories
{
    // Logica del programa 
    internal class IngredienteRepository
    {
        public bool RegistrarPlato(string CodigoPlato,Ingrediente ingrediente)
        {
            if (ExisteIngrediente(CodigoPlato,ingrediente.Codigo))
            {
                return false;
            }
            List<Plato> platos = PlatoRepository.MostrarPlatos(); // Obtienes todos los platos disponibles
            Plato plato = platos.Find(p => p.Codigo.Equals(CodigoPlato)); //Encuentras el plato específico por su código
            plato.Ingredientes.Add(ingrediente); //Agregas el ingrediente a la lista de ingredientes del plato
            return true;
        }
        // Duplicado
        public bool ExisteIngrediente(string codigoPlato,string codigoIngrediente)
        {
            List<Plato> platos = PlatoRepository.MostrarPlatos(); // Obtienes todos los platos disponibles
            Plato plato = platos.Find(p => p.Codigo.Equals(codigoPlato)); //Encuentras el plato específico por su código
            return plato.Ingredientes.Exists(p => p.Codigo.Equals(codigoIngrediente)); // Verificas si el ingrediente ya existe en ese plato
        }
        // Mostrar
        public List<Ingrediente> MostrarIngredientes(string codigoPlato)
        {
            List<Plato> platos = PlatoRepository.MostrarPlatos(); //Obtienes todos los platos disponibles
            Plato plato = platos.Find(p => p.Codigo.Equals(codigoPlato)); //Encuentras el plato específico por su código
            return plato.Ingredientes; //Retornas la lista de ingredientes del plato
        }
    }
}
