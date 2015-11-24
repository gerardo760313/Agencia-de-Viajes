<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mostrar.aspx.cs" Inherits="Mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Container">
        <div class ="row">
            <div class="col-sm-4">
                            <div class="panel panel-default">
                                <div class="panel-heading" style="height: 150px">
                                    <img src="img/Acapulco.jpg" alt="Destino turistico" id="imgLugar" class="img-responsive" style="margin: auto; height: 120px " />
                                </div>

                                <div class=" panel-body" style="height: 95%;">
                                    <div class="row">
                                        <div class="col-xs-4" style="height: 100px">
                                            <img src="img/CopacabanaAcapulco.jpg" alt="Hotel" id="imgHotel" class="img-responsive" style="margin: auto; height: 100px" />
                                        </div>

                                        <div class="col-xs-8">
                                            <span>Fecha: </span>
                                            <label>19/11/2015</label>
                                            <span>Categoria: </span>
                                            <label>5 estrellas</label>
                                            <span>Destino: </span>
                                            <label>Acapulco</label>
                                            <br />
                                            <input type="checkbox" id="chkEstatus" checked="checked" disabled="disabled" />
                                        </div>

                                    </div>

                                    <div id="descripcion" style="text-align: center; margin: 5px auto;">
                                        <textarea id="txtDescr" class="form-control" cols="43" rows="4" style="text-align: justify; background-color: White;" disabled="disabled">Este centro turitico cuenta con ....
                                </textarea>
                                    </div>


                                    <div id="video" style="text-align: center; margin: 0px auto;">
                                        <iframe src="video/DestinosGuerrero.mp4" frameborder="0" allowfullscreen controls style="width:95%"></iframe>
                                    </div>
                                </div>

                                <div class="panel-footer" style="height: 50px; text-align: center;">
                                    <asp:LinkButton Text="Reservar" runat="server" ID="lkbReservar" />
                                </div>

                            </div>
                        </div> 
        </div>
    
    </div>
    </form>
</body>
</html>
