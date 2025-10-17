using EA_U202321121_TemaA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Repositories
{
    internal class PlatoRepository
    {
        private static List<Plato> platos = new List<Plato>();

        // Registro ( Tipo de dato : Objeto Plato.cs plato = nombre ) 
        public bool RegistrarPlato(Plato plato)
        {
            platos.Add(plato);
            return true;
        }
        // Mostrar
        public static List<Plato> MostrarPlatos()
        {
            return platos;
        }

        public List<Plato> MostrarPlatosPorPrecio()
        {
            return platos.OrderBy(p => p.Precio).ToList(); // Ordena los platos por precio de menor a mayor
        }
        public List<Plato> PlatosMayorIngredientes()
        {
            int maxIngredientes =
                platos.Count == 0 ? // Si no hay platos, el máximo es 0
                0
                :
                platos.Max(k => k.Ingredientes.Count); // Encuentra el número máximo de ingredientes en los platos existentes
            return platos.Where(p => p.Ingredientes.Count == maxIngredientes).ToList(); // Retorna los platos que tienen el número máximo de ingredientes

        }
        public List<Plato> PlatosCocinaPeruana()
        {
            List<Plato> PlatosCocinaPeruana = platos.Where(p => p.TipoCocina == "Cocina Peruana").ToList(); // Filtra los platos que son de cocina peruana
            return PlatosCocinaPeruana.Where(j=>j.Ingredientes.Exists(i=>i.CantidadKG.Equals(1))).ToList(); // De esos platos, retorna solo los que tienen al menos un ingrediente con cantidad igual a 1 kg
        }
        public List<Plato> PlatosConMenorIngredientePescado()
        {
            List<Plato> platosPescado = platos.Where(p => p.Ingredientes.Exists(i => i.TipoIngrediente == "Pescado")).ToList(); // Filtra los platos que contienen al menos un ingrediente de tipo pescado
            int minCantidadPescado =
                platosPescado.Count == 0 ? // Si no hay platos, el minimo es 0
                0
                :   
                platosPescado.Min(p => p.Ingredientes.Count(i => i.TipoIngrediente == "Pescado")); // Encuentra el número mínimo de ingredientes de tipo pescado en los platos filtrados
            return platosPescado.Where(p => p.Ingredientes.Count(i=> i.TipoIngrediente=="Pescado").Equals(minCantidadPescado)).ToList(); // Retorna los platos que tienen el número mínimo de ingredientes de tipo pescado
        }
    }

}
