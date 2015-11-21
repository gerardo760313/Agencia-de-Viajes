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
                                    <li data-target="#carNacinales" data-slide-to="0" class="active"></li>
                                    <li data-target="#carNacinales" data-slide-to="1"></li>
                                    <li data-target="#carNacinales" data-slide-to="2"></li>
                                    <li data-target="#carNacinales" data-slide-to="3"></li>
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <div class="item active">
                                        <img src="img/Acapulco.jpg" alt="Acapulco" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Acapulco</h3>
                                            <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/Cancun.jpg" alt="Cancún" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Cancún</h3>
                                            <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/LosCabos.jpg" alt="Los Cabos" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Los Cabos</h3>
                                            <p>Beatiful flowers in Kolymbari, Crete.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/PuertoVallarta.jpg" alt="Puerrto Vallarta" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Puerto Vallarta</h3>
                                            <p>Beatiful flowers in Kolymbari, Crete.</p>
                                        </div>
                                    </div>
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
                                    <li data-target="#carInternacionales" data-slide-to="0" class="active"></li>
                                    <li data-target="#carInternacionales" data-slide-to="1"></li>
                                    <li data-target="#carInternacionales" data-slide-to="2"></li>
                                    <li data-target="#carInternacionales" data-slide-to="3"></li>
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner" role="listbox">
                                    <div class="item active">
                                        <img src="img/MachuPichuPeru.jpg" alt="Perú" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Machu Pichu, Perú</h3>
                                            <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/MurallaChinaPekin.jpg" alt="Pekín" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Muralla China, Pelkín</h3>
                                            <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/RioJaneiroBrasil.jpg" alt="Basil" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Río de Janeiro, Brasil</h3>
                                            <p>Beatiful flowers in Kolymbari, Crete.</p>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="img/TajMahaIndia.jpg" alt="La Índia" style="margin: auto; text-align: center; height:300px" />
                                        <div class="carousel-caption">
                                            <h3>Taj Maha, Índia</h3>
                                            <p>Beatiful flowers in Kolymbari, Crete.</p>
                                        </div>
                                    </div>
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
                            <div class="row; text-center">
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
                    <div class="row">
                        <div class="col-sm-4">
                            <div class="panel panel-default">
                                <div class="panel-heading" style="height: 150px">
                                    <img src="img/Acapulco.jpg" alt="Destino turistico" id="imgLugar" class="img-responsive" style="margin: auto; height: 120px" />
                                </div>

                                <div class=" panel-body" style="height: 400px;">
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


                                    <div id="video" style="text-align: center; margin: 5px auto;">
                                        <iframe src="video/DestinosGuerrero.mp4" frameborder="0" allowfullscreen controls></iframe>

                                    </div>
                                </div>

                                <div class="panel-footer" style="height: 50px; text-align: center;">
                                    <asp:LinkButton Text="Reservar" runat="server" ID="lkbReservar" />
                                </div>

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
