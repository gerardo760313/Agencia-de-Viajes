using Agencia.Viajes.Business.Entity;
using Agencia.Viajes.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Business
{
    public class BusCatalogo
    {
        public List<EntCategoria> ObtCategoria()
        {
            try
            {
                DataTable dt = new DatCatalogos().ObtenerCategoria();
                List<EntCategoria> list = new List<EntCategoria>();
                foreach (DataRow dr in dt.Rows)
                {
                    EntCategoria ent = new EntCategoria();
                    ent.id = Convert.ToInt32(dr["CATE_ID"]);
                    ent.nombre = dr["CATE:NOMB"].ToString();
                    list.Add(ent);
                }
                return list;
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }


        }
        public List<EntDestino> ObtDestino()
        {
            try
            {
                List<EntDestino> list = new List<EntDestino>();
                DataTable dt = new DatCatalogos().ObtenerDestino();
                foreach (DataRow dr in dt.Rows)
                {
                    EntDestino ent = new EntDestino();
                    ent.id = Convert.ToInt32( dr["DEST_ID"]);
                    ent.nombre = dr["DEST_NOMB"].ToString();
                    list.Add(ent);
                }

                return list;
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
        }
    }

}
