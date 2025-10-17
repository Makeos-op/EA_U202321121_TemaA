using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U202321121_TemaA.Entities
{
    internal class Ingrediente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }  
        public string TipoIngrediente { get; set; }
        public double CantidadKG { get; set; }
    }
}
