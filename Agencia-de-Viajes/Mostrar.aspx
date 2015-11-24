<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mostrar.aspx.cs" Inherits="Mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <div class="row">
                <div class=" col-md-2"></div>
                <div class=" col-md-8">
                    <div class="panel panel-default">

                        <div class="panel-heading" style="height: 300px; text-align: center">
                            <img src="img/Acapulco.jpg" alt="Destino turistico" id="imgLugar" class="img-responsive" style="margin: auto; height: 90%" />
                        </div>

                        <div class=" panel-body" style="height: 95%;">
                            <div class="row">
                                <div class="col-xs-4" style="height: 200px">
                                    <img src="img/CopacabanaAcapulco.jpg" alt="Hotel" id="imgHotel" class="img-responsive" style="margin: auto; height: 95%" />
                                </div>

                                <div class="col-xs-4">
                                    <span>Fecha: </span>
                                    <label>19/11/2015</label>
                                    <span>Categoria: </span>
                                    <label>5 estrellas</label>
                                    <span>Destino: </span>
                                    <label>Acapulco</label>
                                    <br />
                                    <input type="checkbox" id="chkEstatus" checked="checked" disabled="disabled" />


                                    <div id="descripcion" style="text-align: center; margin: 5px auto;">
                                        <textarea id="txtDescr" class="form-control" cols="43" rows="4" style="text-align: justify; background-color: White;" disabled="disabled">Este centro turitico cuenta con ....
                                </textarea>
                                    </div>
                                </div>

                                <div class="col-xs-4">
                                    <div id="video" style="text-align: center; margin: 5px auto; width: 200px">
                                        <iframe src="video/DestinosGuerrero.mp4" frameborder="0" allowfullscreen controls style="width: 100%"></iframe>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="panel-footer" style="height: 50px; text-align: center;">
                            <asp:LinkButton Text="Reservar" runat="server" ID="lkbReservar" />
                        </div>

                    </div>
                </div>
                <div class=" col-md-2"></div>
            </div>

        </div>
        <script src="js/jquery-2.1.4.js"></script>
        <script src="js/bootstrap.js"></script>
    </form>
</body>
</html>
