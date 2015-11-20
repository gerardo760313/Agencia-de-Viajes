using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Data
{
    public class DatViaje
    {
        public SqlConnection con;
        public DatViaje() 
        {
            con = new SqlConnection("Data Source= CHINO\\MSSQLSERVER2012; Initial Catalog = Agencia-de-Viajes; User Id = sa; password=12345");
            DataTable dt = new DataTable();
        }
        public DataTable Obtener() 
        {
            SqlCommand com = new SqlCommand("spObtenerPeliculas", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Obtener(int id) 
        {
            SqlCommand com = new SqlCommand("spObtenerViaje", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = id });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Insertar(string nombre, string fechaLlegada, int categoria, int destino, string fechaAlta, bool estatus, string descripcion, string video, string fotoLugar, string fotoHotel, double costo) 
        {
            SqlCommand com = new SqlCommand(string.Format("INSERT INTO VIAJE(VIAJ_ID, VIAJ_NOMB, VIAJ_FECH_LLEG, VIAJ_CATE_ID, VIAJ_DEST_ID, VIAJ_FECH_ALTA, VIAJ_ESTA, VIAJ_DESC, VIAJ_VIDE ,VIAJ_FOTO_LUG, VIAJ_FOTO_HOTE, VIAJ_COST) VALUES ((SELECT ISNULL(MAX(VIAJ_ID) +1, 1) FROM VIAJE), {0},'{1}','{2}', {3}, {4}, '{5}','{6}','{7}','{8}', '{9}','{10}',{11})",nombre, fechaLlegada, categoria, destino, fechaAlta, estatus, descripcion, video, fotoLugar, fotoHotel, costo), con);
            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }
 
            
        }
        public int Actualizar(int id, string nombre, string fechaLlegada, int categoria, int destino, string fechaAlta, bool estatus, string descripcion, string video, string fotoLugar, string fotoHotel, double costo) 
        {
            try
            {
                SqlCommand com = new SqlCommand("UPDATE VIAJE SET VIAJ_NOMB = '{0}', VIAJ_FECH_LLEG = '{1}',VIAJ_CATE_ID = {2}, VIAJ_DEST_ID = {3}, VIAJ_FECH_ALTA = '{4}', VIAJ_ESTA = '{5}',VIAJ_DESC = '{6}', VIAJ_VIDE = '{7}', VIAJ_FOTO_LUG = '{8}', VIAJ_FOTO_HOTE = '{9}', VIAJ_COST = {10} WHERE VIAJ_ID = {11}", con);
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }
        }
        public int Borrar(int id) 
        {
            try
            {
                SqlCommand com = new SqlCommand("Delete FROM VIAJE WHERE PELI_ID = " + id, con);
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            } 
        }
        public DataTable ObtenerDestino(int id) 
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT VIAJ_ID, VIAJ_NOMB, VIAJ_FECH_LLEG, VIAJ_CATE_ID, VIAJ_DEST_ID, VIAJ_FECH_ALTA, VIAJ_ESTA, VIAJ_DESC, VIAJ_VIDE, VIAJ_FOTO_LUG, VIAJ_FOTO_HOTE, VIAJ_COST FROM VIAJE INNER JOIN DESTINO On DEST_ID = VIAJ_DEST_ID INNER JOIN CATEGORIA On CATE_ID = VIAJ_CATE_ID WHERE VIAJ_DEST_ID = " + id, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
        }
        public DataTable ObtenerCategoria(int id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT VIAJ_ID, VIAJ_NOMB, VIAJ_FECH_LLEG, VIAJ_CATE_ID, VIAJ_DEST_ID, VIAJ_FECH_ALTA, VIAJ_ESTA, VIAJ_DESC, VIAJ_VIDE, VIAJ_FOTO_LUG, VIAJ_FOTO_HOTE, VIAJ_COST FROM VIAJE INNER JOIN DESTINO On DEST_ID = VIAJ_DEST_ID INNER JOIN CATEGORIA On CATE_ID = VIAJ_CATE_ID WHERE VIAJ_CATE_ID = " + id, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
        }
        public DataTable spObtenerViaje(string nombre, int categoriaid, int destinoId, DateTime fechaLlegada) 
        {
            SqlDataAdapter da = new SqlDataAdapter("", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        

    }
}
