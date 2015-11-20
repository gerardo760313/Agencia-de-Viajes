using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViajes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CargarDestinos();
        }
        catch (Exception ex)
        {
            
            Title = ex.Message;
        }
    }

    private void CargarDestinos()
    {
       // gvViajes.DataSource = new BusViajes().Obtener();
        //gvViajes.DataBind();
    }
}