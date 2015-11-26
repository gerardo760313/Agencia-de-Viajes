using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Viajes.Data
{
    public class DatUsuario
    {
        public SqlConnection con;
        public DatUsuario()
        {

            con = new SqlConnection("Data Source= JMRV\\MSSQLSERVER2012; Initial Catalog = AgenciaViajes; User Id = sa; password=12345");
        }

        public DataTable ObtenerUsuario(string mail, string pass) 
        {
            SqlCommand com = new SqlCommand("spObtenerUsuario", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Mail", Value = mail });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Pass", Value = pass });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
