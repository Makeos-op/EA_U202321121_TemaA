using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Entities
{
    internal class Plato //Clase Plato (Padre)
    {
        public Plato() //Constructores
        {
            Ingredientes = new List<Ingrediente>(); //Inicializa la lista de ingredientes
        }
        public string Codigo { get; set; } //Propiedades
        public string Nombre { get; set; }//Propiedades
        public string TipoCocina { get; set; }//propiedades
        public double Precio { get; set; }//Propiedades
        public List<Ingrediente> Ingredientes { get; set; } //Propiedades DE LISTA
    }
}
