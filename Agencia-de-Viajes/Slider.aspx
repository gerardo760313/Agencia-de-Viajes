<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Slider.aspx.cs" Inherits="Slider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="myCarousel" class="carousel slide" data-ride="carousel" >
            <!-- Indicators -->
            <ol class="carousel-indicators" >
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox" >
                <div class="item active" >
                    <img src="img/Acapulco.jpg" alt="Chania" style="margin:auto; text-align:center;"/>
                    <div class="carousel-caption">
                        <h3>Acapulco</h3>
                        <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                    </div>
                </div>

                <div class="item">
                    <img src="img/Cancun.jpg" alt="Chania" style="margin:auto; text-align:center;"/>
                    <div class="carousel-caption">
                        <h3>Cancún</h3>
                        <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                    </div>
                </div>

                <div class="item">
                    <img src="img/LosCabos.jpg" alt="Flower"/>
                    <div class="carousel-caption">
                        <h3>Los Cabos</h3>
                        <p>Beatiful flowers in Kolymbari, Crete.</p>
                    </div>
                </div>

                <div class="item">
                    <img src="img/PuertoVallarta.jpg" alt="Flower"style="margin:auto; text-align:center;"/>
                    <div class="carousel-caption">
                        <h3>Puerto Vallarta</h3>
                        <p>Beatiful flowers in Kolymbari, Crete.</p>
                    </div>
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </form>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</body>
</html>
