using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Business.Entity
{
   public class EntUsuario
    {
        public int id { get; set; }
        public string  nombre { get; set; }
        public string mail { get; set; }
        public string pass { get; set; }
    }
}
