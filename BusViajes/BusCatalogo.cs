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
        public BusCatalogo() { }
        public List<EntCategoria> ObtenerCategoria() 
        {
            DataTable dt = new DatCatalogos().ObtenerCategoria();
            List<EntCategoria> lst = new List<EntCategoria>();
            foreach (DataRow dr in dt.Rows) 
            {
                EntCategoria ent = new EntCategoria();
                ent.id = Convert.ToInt32(dr["CATE_ID"]);
                ent.nombre = dr["CATE_NOMB"].ToString();
                ent.descripcion = dr["CATE_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntDestino> ObtenerDestino() 
        {
            DataTable dt = new DatCatalogos().ObtenerDestino();
            List<EntDestino> lst = new List<EntDestino>();
            foreach (DataRow dr in dt.Rows) 
            {
                EntDestino ent = new EntDestino();
                ent.id = Convert.ToInt32(dr["DEST_ID"]);
                ent.nombre = dr["DEST_NOMB"].ToString();
                ent.descripcion = dr["DEST_DESC"].ToString();
                lst.Add(ent);                     
            }
            return lst;
        }
    }
}
