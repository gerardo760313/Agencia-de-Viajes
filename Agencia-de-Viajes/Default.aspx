<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agencia de Viajes JMEN's</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12; text-right ">
                    <a href="#">Registro</a>
                    <a href="#">Login</a>
                </div>
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <ul class="nav nav-tabs">
                        <li class="active"><a data-toggle="tab" href="#home">Nacionales</a></li>
                        <li><a data-toggle="tab" href="#menu1">Internacionales</a></li>
                    </ul>

                    <div class="tab-content">
                        <div id="home" class="tab-pane fade in active">
                            <h3>Nacionales</h3>
                            <p>Some content.</p>
                        </div>
                        <div id="menu1" class="tab-pane fade">
                            <h3>Internacionales</h3>
                            <p>Some content in menu 1.</p>
                        </div>
                    </div>

                    &nbsp;
                    <div class="well">
                        <div>
                            <div class="row; text-center">
                                <div class="col-sm-4">
                                    <asp:TextBox runat="server" ID="txt" ToolTip="Buscar por fecha" placeholder="Fecha" />
                                </div>
                                <div class="col-sm-4">
                                    <asp:DropDownList runat="server" ID="ddlCategoria" ToolTip="Selecciona una categoria" AppendDataBoundItems="true">
                                        <asp:ListItem Text="Categoria" Value="-1" />
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-4">
                                    <asp:DropDownList runat="server" ID="ddlDestino" ToolTip="Selecciona un destino" AppendDataBoundItems="true">
                                        <asp:ListItem Text="Destino" Value="-1" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row; text-center">
                                <div class="col-sm-4">
                                    <asp:TextBox runat="server" ID="TextBox1" ToolTip="Buscar por fecha" placeholder="Fecha1" />
                                </div>
                                <div class="col-sm-4">
                                    <asp:Button Text="Buscar" runat="server" ID="btnBuscar" />
                                </div>
                                <div class="col-sm-4">
                                </div>
                            </div>
                            &nbsp;
                        </div>

                    </div>

                    &nbsp;
                    <div class="col-sm-4">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="height: 120px">
                                <img src="img/avatarportada.png" alt="Destino turistico" id="imgLugar" class="img-responsive" style="margin: auto" />
                            </div>

                            <div class=" panel-body" style="height: 400px;">
                                <div class="row">
                                    <div class="col-xs-4" style="height: 100px">
                                        <img src="img/avatarmin.png" alt="Hotel" id="imgHotel" class="img-responsive" style="margin: auto" />
                                    </div>

                                    <div class="col-xs-8">
                                        <span>Fecha: </span>
                                        <label>19/11/2015</label>
                                        <span>Categoria: </span>
                                        <label>5 estrellas</label>
                                        <span>Destino: </span>
                                        <label>Cancún</label>
                                        <br />
                                        <input type="checkbox" id="chkEstatus" checked="checked" disabled="disabled" />
                                    </div>

                                </div>

                                <div id="descripcion" style="text-align: center; margin: 5px auto;">
                                    <textarea id="txtDescr" class="form-control" cols="43" rows="4" style="text-align: justify; background-color: White;" disabled="disabled">Este centro turitico cuenta con ....
                                </textarea>
                                </div>


                                <div id="video" class="text-center" style="text-align: center; margin: 5px auto;">
                                    <iframe src="video/HOTEL_TRANSYLVANIA_2.mp4 " frameborder="0" allowfullscreen controls ></iframe>

                                </div>
                            </div>

                            <div class="panel-footer" style="height: 50px; text-align: center;">
                                <asp:LinkButton Text="Reservar" runat="server" ID="lkbReservar" />
                            </div>

                        </div>
                    </div>

                </div>
                <div class="col-md-1"></div>

            </div>
        </div>
    </form>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</body>
</html>
