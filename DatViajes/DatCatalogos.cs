using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Data
{
    public class DatCatalogos
    {
        public SqlConnection con;
        public DatCatalogos()
        {
            con = new SqlConnection("Data Source= CHINO\\MSSQLSERVER2012; Initial Catalog = Agencia-de-Viajes; User Id = sa; password=12345");
        }
        public DataTable ObtenerDestino() 
         {
             SqlCommand com = new SqlCommand("spObtenerDestino", con);
             com.CommandType = CommandType.StoredProcedure;
             com.Parameters.Add(new SqlParameter());
             SqlDataAdapter da = new SqlDataAdapter(com);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }
        public DataTable ObtenerCategoria()
        {
            SqlCommand com = new SqlCommand("spObtenerCategoria", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
