using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                LlenarCategoria();
                LlemnarDestino();
            }
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message; ;
        }
    }

    private void LlemnarDestino()
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            
            Title = "Error: "+ex.Message;
        }
    }

    private void LlenarCategoria()
    {
        try
        {

        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }
}