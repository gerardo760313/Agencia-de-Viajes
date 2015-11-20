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
             SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DESTINO", con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }
         public DataTable ObtenerCategoria() 
         {
             SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Categoria", con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }
    }
}
