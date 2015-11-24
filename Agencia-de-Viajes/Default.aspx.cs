using Agencia.Viajes.Business;
using Agencia.Viajes.Business.Entity;
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
                List<EntViaje> list = new BusViaje().Obtener();
                cargarDestinos(list);
                cargarNacionales(list);
                cargarInternacionales(list);

                LlenarCategoria();
                LlenarDestino();
            }
        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message; ;
        }
    }

    private void cargarInternacionales(List<EntViaje> list)
    {
        try
        {
            //Language Integrate Query
            //Linq Este fragmento de código genera un query en c# para filtrar datos

            var inter =
                from v in list
                where v.destinoId == 1
                select v;

            LiteralControl litCab = new LiteralControl();
            LiteralControl litBody = new LiteralControl();
            litCab.Text = "";
            litBody.Text = "";
            int cont = 0;
            foreach (EntViaje ent in inter.ToList())
            {
                if (cont == 0)
                {
                    litCab.Text += "<li data-target=\"#carInternacionales\" data-slide-to=\"" + cont + "\" class=\"active\"></li>";

                    litBody.Text += "<div class=\"item active\">";
                    litBody.Text += "     <img src=\"" + ent.fotoLugar + "\" alt=\"" + ent.nombre + "\" style=\"margin: auto; text-align: center; height:300px\" />";
                    litBody.Text += "     <div class=\"carousel-caption\">";
                    litBody.Text += "          <h3>" + ent.nombre + "</h3>";
                    //litBody.Text += "          <p>The atmosphere in Chania has a touch of Florence and Venice.</p>";
                    litBody.Text += "     </div>";
                    litBody.Text += "</div>";
                }
                else
                {
                    litCab.Text += "<li data-target=\"#carInternacionales\" data-slide-to=\"" + cont + "\"></li>";

                    litBody.Text += "<div class=\"item\">";
                    litBody.Text += "     <img src=\"" + ent.fotoLugar + "\" alt=\"" + ent.nombre + "\" style=\"margin: auto; text-align: center; height:300px\" />";
                    litBody.Text += "     <div class=\"carousel-caption\">";
                    litBody.Text += "          <h3>" + ent.nombre + "</h3>";
                    //litBody.Text += "          <p>The atmosphere in Chania has a touch of Florence and Venice.</p>";
                    litBody.Text += "     </div>";
                    litBody.Text += "</div>";
                }
                cont = 0;
            }
            phCarrCabNac.Controls.Add(litCab);
            phCarrBodyNac.Controls.Add(litBody);
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }

    private void cargarNacionales(List<EntViaje> list)
    {
        var nac =
            from v in list
            where v.destinoId == 2
            select v;

        try
        {
            LiteralControl litCab = new LiteralControl();
            LiteralControl litBody = new LiteralControl();
            litCab.Text = "";
            litBody.Text = "";

            int cont = 0;
            foreach (EntViaje ent in nac.ToList())
            {
                if (cont == 0)
                {
                    litCab.Text += "<li data-target=\"#carNacinales\" data-slide-to=\"" + cont + "\" class=\"active\"></li>";

                    litBody.Text += "<div class=\"item active\">";
                    litBody.Text += "     <img src=\"" + ent.fotoLugar + "\" alt=\"" + ent.nombre + "\" style=\"margin: auto; text-align: center; height:300px\" />";
                    litBody.Text += "     <div class=\"carousel-caption\">";
                    litBody.Text += "          <h3>" + ent.nombre + "</h3>";
                    //litBody.Text += "          <p>The atmosphere in Chania has a touch of Florence and Venice.</p>";
                    litBody.Text += "     </div>";
                    litBody.Text += "</div>";
                }
                else
                {
                    litCab.Text += "<li data-target=\"#carNacinales\" data-slide-to=\"" + cont + "\"></li>";

                    litBody.Text += "<div class=\"item\">";
                    litBody.Text += "     <img src=\"" + ent.fotoLugar + "\" alt=\"" + ent.nombre + "\" style=\"margin: auto; text-align: center; height:300px\" />";
                    litBody.Text += "     <div class=\"carousel-caption\">";
                    litBody.Text += "          <h3>" + ent.nombre + "</h3>";
                    //litBody.Text += "          <p>The atmosphere in Chania has a touch of Florence and Venice.</p>";
                    litBody.Text += "     </div>";
                    litBody.Text += "</div>";
                }
                cont = 0;
            }
            phCarrCabInter.Controls.Add(litCab);
            phCarrBodyInter.Controls.Add(litBody);
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }


    private void cargarDestinos(List<EntViaje> list)
    {
        try
        {
            LiteralControl literal = new LiteralControl();
            literal.Text = "";
            foreach (EntViaje ent in list)
            {
                literal.Text += "                        <div class=\"col-sm-4\">";
                literal.Text += "                            <div class=\"panel panel-default\">";
                literal.Text += "                                <div class=\"panel-heading\" style=\"height: 150px\">";
                literal.Text += "                                    <img src=\"" + ent.fotoLugar + "\" alt=\"Destino turistico\" id=\"imgLugar\" class=\"img-responsive\" style=\"margin: auto; height: 120px \" />";
                literal.Text += "                                </div>";

                literal.Text += "                                <div class=\" panel-body\" style=\"height: 95%;\">";
                literal.Text += "                                    <div class=\"row\">";
                literal.Text += "                                        <div class=\"col-xs-4\" style=\"height: 100px\">";
                literal.Text += "                                            <img src=\"" + ent.fotoHotel + "\" alt=\"Hotel\" id=\"imgHotel\" class=\"img-responsive\" style=\"margin: auto; height: 100px\" />";
                literal.Text += "                                        </div>";

                literal.Text += "                                        <div class=\"col-xs-8\">";
                literal.Text += "                                            <span>Fecha: </span>";
                literal.Text += "                                            <label>" + ent.fechaLlegada + "</label>";
                literal.Text += "                                            <span>Categoria: </span>";
                literal.Text += "                                            <label>" + ent.Categoria + "</label>";
                literal.Text += "                                            <span>Destino: </span>";
                literal.Text += "                                            <label>" + ent.Destino + "</label>";
                literal.Text += "                                            <br />";
                if (ent.estatus)
                    literal.Text += "<input type=\"checkbox\" disabled checked/>";
                else
                    literal.Text += "<input type=\"checkbox\" disabled>";
                literal.Text += "                                        </div>";

                literal.Text += "                                    </div>";

                literal.Text += "                                    <div id=\"descripcion\" style=\"text-align: center; margin: 5px auto;\">";
                literal.Text += "                                        <textarea id=\"txtDescr\" class=\"form-control\" cols=\"43\" rows=\"4\" style=\"text-align: justify; background-color: White;\" disabled=\"disabled\">";
                literal.Text = ent.descripcion;
                literal.Text += "                                </textarea>";
                literal.Text += "                                    </div>";

                literal.Text += "                                    <div id=\"video\" style=\"text-align: center; margin: 0px auto;\">";
                literal.Text += "                                        <iframe src=\"" + ent.video + "\" frameborder=\"0\" allowfullscreen controls style=\"width:95%\"></iframe>";
                literal.Text += "                                    </div>";
                literal.Text += "                                </div>";

                literal.Text += "                                <div class=\"panel-footer\" style=\"height: 50px; text-align: center;\">";
                literal.Text += "                                    <a href=\"AltaEdicion.aspx?ID=" + ent.id.ToString() + "\">Editar<img src=\"img/edit.png\" Id=\"imgEditar\" width=\"40px\"/></a>";
                literal.Text += "                                </div>";

                literal.Text += "                            </div>";
                literal.Text += "                        </div>";
            }
            phdestinos.Controls.Add(literal);
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }

    private void LlenarDestino()
    {
        try
        {
            List<EntDestino> listDest = BusDestino().Obtener();
            ddlDestino.DataSource = listDest;
            ddlDestino.DataTextField = "nombre";
            ddlDestino.DataValueField = "id";
            ddlDestino.DataBind();

        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }

    private void LlenarCategoria()
    {
        try
        {
            List<EntCategoria> listCat = BusCategoria().Obtener();
            ddlCategoria.DataSource = listCat;
            ddlCategoria.DataTextField = "nombre";
            ddlCategoria.DataValueField = "id";
            ddlCategoria.DataBind();

        }
        catch (Exception ex)
        {

            Title = "Error: " + ex.Message;
        }
    }
}