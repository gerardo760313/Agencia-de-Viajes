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
        public int spInsertar(string nombre, string fechaLlegada, int categoria, int destino, string fechaAlta, bool estatus, string descripcion, string video, string fotoLugar, string fotoHotel, double costo) 
        {
            SqlCommand com = new SqlCommand("spInsertar", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@nombre", Value = nombre });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechaLlegada", Value = fechaLlegada });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Categoria", Value = categoria });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@DesyinoId", Value = destino });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@FechaAlta", Value = fechaAlta });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@Estatus", Value = estatus });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Descripcion", Value = descripcion });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Video", Value = video});
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@FotoLugar", Value = fotoLugar });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@FotoHotel", Value = fotoHotel });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Decimal, ParameterName = "@Costo", Value = costo });
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
                SqlCommand com = new SqlCommand("spActualizar", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@id", Value = id });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@nombre", Value = nombre });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechaLlegada", Value = fechaLlegada });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Categoria", Value = categoria });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@DesyinoId", Value = destino });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@FechaAlta", Value = fechaAlta });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@Estatus", Value = estatus });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Descripcion", Value = descripcion });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Video", Value = video });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@FotoLugar", Value = fotoLugar });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@FotoHotel", Value = fotoHotel });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Decimal, ParameterName = "@Costo", Value = costo });

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
                SqlCommand com = new SqlCommand("spBorrar" + id, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = id });
                
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
            SqlCommand com = new SqlCommand("spObtenerViajeCompleto", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() {SqlDbType = SqlDbType.NVarChar, ParameterName = "@nombre", Value = nombre});
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Categoria", Value = categoriaid });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@DesyinoId", Value = destinoId });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@FechaLlegada", Value = fechaLlegada });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        

    }
}
