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
                <div class="col-xs-12; text-right">
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
                            <!--<h3>Nacionales</!--h3> -->
                            <div id="carNacinales" class="carousel slide" data-ride="carousel">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <asp:PlaceHolder runat="server" ID="phCarrCabNac" />
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <asp:PlaceHolder runat="server" ID="phCarrBodyNac" />
                                </div>

                                <!-- Left and right controls -->
                                <a class="left carousel-control" href="#carNacinales" role="button" data-slide="prev">
                                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                                    <span class="sr-only">Previous</span>
                                </a>
                                <a class="right carousel-control" href="#carNacinales" role="button" data-slide="next">
                                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                                    <span class="sr-only">Next</span>
                                </a>
                            </div>
                        </div>

                        <div id="menu1" class="tab-pane fade">
                            <!--<h3>Internacionales</h3>-->
                            <div id="carInternacionales" class="carousel slide" data-ride="carousel">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <asp:PlaceHolder runat="server" ID="phCarrCabInter" />
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <asp:PlaceHolder runat="server" ID="phCarrBodyInter" />
                                </div>

                                <!-- Left and right controls -->
                                <a class="left carousel-control" href="#carInternacionales" role="button" data-slide="prev">
                                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                                    <span class="sr-only">Previous</span>
                                </a>
                                <a class="right carousel-control" href="#carInternacionales" role="button" data-slide="next">
                                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                                    <span class="sr-only">Next</span>
                                </a>
                            </div>
                        </div>
                    </div>
                    &nbsp;
                    <div class="well">
                        <div>
                            <div class="row text-center">
                                <div class="col-sm-4">
                                    <asp:TextBox runat="server" ID="txtFecha" ToolTip="Buscar por fecha" placeholder="Fecha" />
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
                            <div class="row text-center">
                                <div class="col-sm-4">
                                    <asp:TextBox runat="server" ID="txt" ToolTip="Buscar por fecha" placeholder="Fecha1" />
                                </div>
                                <div class="col-sm-4">
                                    <asp:Button Text="Buscar" runat="server" ID="btnBuscar" />
                                </div>
                                <div class="col-sm-4"></div>
                            </div>
                            &nbsp;
                        </div>
                    </div>
                    &nbsp;
                    <div class="row text-center" style="margin-top: 20px">
                        <asp:PlaceHolder runat="server" ID="phdestinos" />
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
