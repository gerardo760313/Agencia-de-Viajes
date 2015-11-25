using System;
using System.Collections.Generic;
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
        

    }
}
