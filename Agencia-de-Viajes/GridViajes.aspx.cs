using Agencia.Viajes.Business;
using Agencia.Viajes.Business.Entity;
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
            LlenarCategoriaFT();
            LlenarDestinoFT();
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }

    private void LlenarDestinoFT()
    {
        try
        {
            List<EntDestino> listDest = new BusDestino().obtDestino();
            DropDownList ddlDest = (DropDownList)gvViajes.FooterRow.FindControl("ddlDestinoFT");

            ddlDest.DataSource = listDest;
            ddlDest.DataTextField = "nombre";
            ddlDest.DataValueField = "id";
            ddlDest.DataBind();

        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }

    private void LlenarCategoriaFT()
    {
        try
        {
            List<EntCategoria> listCat = new BusCategoria().obtCat();
            DropDownList ddlCat = new DropDownList();

            ddlCat.DataSource = listCat;
            ddlCat.DataTextField = "nombre";
            ddlCat.DataValueField = "id";
            ddlCat.DataBind();

        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }

    private void CargarDestinos()
    {
        try
        {
            gvViajes.DataSource = new BusViaje().Obtener();
            gvViajes.DataBind();
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }

    protected void lnbAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            EntViaje entViaje = new EntViaje();
            
            entViaje.nombre = ((TextBox)gvViajes.FooterRow.FindControl("txtNombreFT")).Text;
            entViaje.fechaLlegada = Convert.ToDateTime(((TextBox)gvViajes.FooterRow.FindControl("txtLlegadaEIT")).Text);
            entViaje.categoriaId = Convert.ToInt32(((TextBox)gvViajes.FooterRow.FindControl("ddlCategoriaFT")).Text);

            new BusViaje().Insertar(entViaje);
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            
            Title = "Error: "+ex.Message;
        }
    }
    protected void gvViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int id = e.RowIndex;
            new BusViaje().Borrar(id);
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }
    protected void gvViajes_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        String path = Server.MapPath("img\\");
        path = path + DateTime.Now.ToString("HHmm");

        try
        {
            EntViaje ent = new EntViaje();
            
            ent.fotoLugar = gvViajes.DataKeys[e.RowIndex].Values["fotoLugar"].ToString();
            ent.fotoHotel = gvViajes.DataKeys[e.RowIndex].Values["fotoHotel"].ToString();

            FileUpload fuFotoLug = (FileUpload)gvViajes.Rows[e.RowIndex].FindControl("fuFotoLugarEIT");
            FileUpload fuFotoHot = (FileUpload)gvViajes.Rows[e.RowIndex].FindControl("fuFotoHotelEIT");
            if (fuFotoLug.HasFile)
            {
                string fileName = fuFotoLug.FileName;
                ent.fotoLugar = path + fileName;
                fuFotoLug.SaveAs(ent.fotoLugar);
                ent.fotoLugar = "img/" + DateTime.Now.ToString("HHmm") + fileName;
            }
            if (fuFotoHot.HasFile)
            {
                string fileName = fuFotoHot.FileName;
                ent.fotoHotel = path + fileName;
                fuFotoHot.SaveAs(ent.fotoHotel);
                ent.fotoHotel = "img" + DateTime.Now.ToString("HHmm") + fileName;
            }

            ent.id = Convert.ToInt32( gvViajes.DataKeys[e.RowIndex].Values["Id"]);
            ent.nombre = ((TextBox)gvViajes.Rows[e.RowIndex].FindControl("txtNombreEIT")).Text;
            ent.fechaLlegada = Convert.ToDateTime(((TextBox)gvViajes.Rows[e.RowIndex].FindControl("txtLlegadaEIT")).Text);
            ent.categoriaId = Convert.ToInt32 (((DropDownList)gvViajes.Rows[e.RowIndex].FindControl("ddlCategoriaEIT")).SelectedItem.Value);
            ent.destinoId = Convert.ToInt32(((DropDownList)gvViajes.Rows[e.RowIndex].FindControl("ddlDestinoEIT")).SelectedItem.Value);
            ent.descripcion = ((TextBox)gvViajes.Rows[e.RowIndex].FindControl("txtDescrEIT")).Text;
            ent.video = ((TextBox)gvViajes.Rows[e.RowIndex].FindControl("txtVideoEIT")).Text;
            ent.estatus = ((CheckBox)gvViajes.Rows[e.RowIndex].FindControl("ckbEstatusEIT")).Checked;

            new BusViaje().Actualizar(ent);
            Response.Redirect("Default.aspx");

        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }
    protected void gvViajes_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            gvViajes.EditIndex = e.NewEditIndex;
            CargarDestinos();
            LlenarCategoriaFT();
            LlenarDestinoFT();

            List<EntDestino> listDest = new BusDestino().obtDestino();
            DropDownList ddlDest = (DropDownList)gvViajes.Rows[e.NewEditIndex].FindControl("ddlDestinoEIT");
            ddlDest.DataSource = listDest;
            ddlDest.DataTextField = "nombre";
            ddlDest.DataValueField = "id";
            ddlDest.DataBind();
            ddlDest.SelectedValue = gvViajes.DataKeys[e.NewEditIndex].Values["destinoId"].ToString();


            List<EntCategoria> listCat = new BusCat().obtCat();
            DropDownList ddlCat = (DropDownList)gvViajes.Rows[e.NewEditIndex].FindControl("ddlCategoriaEIT");
            ddlCat.DataSource = listCat;
            ddlCat.DataTextField = "nombre";
            ddlCat.DataValueField = "id";
            ddlCat.DataBind();
            ddlCat.SelectedValue = gvViajes.DataKeys[e.NewEditIndex].Values["categoriaId"].ToString();
        }
        catch (Exception ex)
        {
            Title = "Error: " + ex.Message;
        }

    }
    protected void gvViajes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            gvViajes.EditIndex = -1;
            CargarDestinos();
            LlenarCategoriaFT();
            LlenarDestinoFT();
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }
}