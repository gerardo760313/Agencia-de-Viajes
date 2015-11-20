using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Business.Entity
{
        public class EntViaje
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public DateTime fechaLlegada { get; set; }
        public int categoriaId { get; set; }
        public int destinoId { get; set; }
        public DateTime fechaAlta { get; set; }
        public bool estatus { get; set; }
        public string descripcion { get; set; }
        public string video { get; set; }
        public string fotoLugar { get; set; }
        public string fotoHotel { get; set; }
        public decimal costo { get; set; }

        private EntCategoria categoria;
        public  EntCategoria Categoria
        { 
            get 
            {
                if (categoria == null)
                    categoria = new EntCategoria();
                    return categoria;   
            }                            
            set 
            {
            if(categoria == null)
                categoria = new EntCategoria();
                categoria = value;
            }            
            
           
        }
        private EntDestino destino;
        public  EntDestino Destino
        { 
            get
            {
                if (destino == null)
                    destino = new EntDestino();
                return destino;
            }
            set 
            {
                if (destino == null)
                    destino = new EntDestino();
                destino = value;
            }
             
             }



    }
}
