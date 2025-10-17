using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Entities
{
    internal class Plato
    {
        public Plato() 
        {
            Ingredientes = new List<Ingrediente>();
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string TipoCocina { get; set; }
        public double Precio { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
