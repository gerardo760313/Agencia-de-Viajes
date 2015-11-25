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
    public class BusViaje
    {
        public BusViaje() { }
        public List<EntViaje> Obtener() 
       {
               DataTable dt = new DatViaje().Obtener();
               List<EntViaje> lst = new List<EntViaje>();
               foreach (DataRow dr in dt.Rows) 
               {
                   EntViaje ent = new EntViaje();
                   ent.id = Convert.ToInt32(dr["VIAJ_Id"]);
                   ent.nombre = dr["VIAJ_NOMB"].ToString();
                   ent.fechaLlegada = Convert.ToDateTime(dr["VIAJ_FECH_LLEG"]);
                   ent.categoriaId = Convert.ToInt32(dr["VIAJ_CATE_ID"]);
                   ent.destinoId = Convert.ToInt32(dr["VIAJ_DEST_ID"]);
                   ent.fechaAlta = Convert.ToDateTime(dr["VIAJ_FECH_ALTA"]);
                   ent.estatus = Convert.ToBoolean(dr["VIAJ_ESTA"]);
                   ent.descripcion  =dr["VIAJ_DESC"].ToString();
                   ent.video  = dr["VIAJ_VIDE"].ToString();
                   ent.fotoLugar  = dr["VIAJ_FOTO_LUG"].ToString();
                   ent.fotoHotel  = dr["VIAJ_FOTO_HOTE"].ToString();
                   ent.costo  = Convert.ToDouble(dr["VIAJ_DESC"]);                   
                   lst.Add(ent);                   
               }
               return lst;
 
           }
        public EntViaje Obtener(int id)
        {
            try
            {
                DataTable dt = new DatViaje().Obtener();
                EntViaje ent = new EntViaje();
                ent.id = Convert.ToInt32(dt.Rows[0]["VIAJ_Id"]);
                ent.nombre = dt.Rows[0]["VIAJ_NOMB"].ToString();
                ent.fechaLlegada = Convert.ToDateTime(dt.Rows[0]["VIAJ_FECH_LLEG"]);
                ent.categoriaId = Convert.ToInt32(dt.Rows[0]["VIAJ_CATE_ID"]);
                ent.destinoId = Convert.ToInt32(dt.Rows[0]["VIAJ_DEST_ID"]);
                ent.fechaAlta = Convert.ToDateTime(dt.Rows[0]["VIAJ_FECH_ALTA"]);
                ent.estatus = Convert.ToBoolean(dt.Rows[0]["VIAJ_ESTA"]);
                ent.descripcion = dt.Rows[0]["VIAJ_DESC"].ToString();
                ent.video = dt.Rows[0]["VIAJ_VIDE"].ToString();
                ent.fotoLugar = dt.Rows[0]["VIAJ_FOTO_LUG"].ToString();
                ent.fotoHotel = dt.Rows[0]["VIAJ_FOTO_HOTE"].ToString();
                ent.costo = Convert.ToDouble(dt.Rows[0]["VIAJ_DESC"]);
                return ent;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }


        }
        public void Insertar(EntViaje ent)
        {
            int filas = new DatViaje().spInsertar(ent.nombre, ent.fechaLlegada.ToString("MM/dd/yyyy"), ent.categoriaId, ent.destinoId, ent.fechaAlta.ToString("MM/dd/yyyy"), ent.estatus, ent.descripcion, ent.video, ent.fotoLugar, ent.fotoHotel, ent.costo);
            if (filas != 1)
                throw new ApplicationException("Error al insertar");
        }
        public void Actualizar(EntViaje ent)
        {
            try
            {
                int filas = new DatViaje().Actualizar(ent.id, ent.nombre, ent.fechaLlegada.ToString("MM/dd/yyyy"), ent.destinoId, ent.categoriaId, ent.fechaAlta.ToString("MM/dd/yyyy"), ent.estatus, ent.descripcion, ent.video, ent.fotoLugar, ent.fotoHotel, ent.costo);
                if (filas != 1)
                    throw new ApplicationException("Error al actualizar");
                {

                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }
        public void Borrar(int id)
        {
            int filas = new DatViaje().Borrar(id);
            if (filas != 1)
                throw new ApplicationException("Error al borrar viaje");

        }

    }
}
