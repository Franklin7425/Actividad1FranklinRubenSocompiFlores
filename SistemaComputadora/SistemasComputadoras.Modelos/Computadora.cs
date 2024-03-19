using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasComputadoras.Modelos
{
    public class Computadora
    {
        public int IdComputadora { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaFabricacion { get; set; }
    }
}
