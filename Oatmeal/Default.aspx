<%@ Page Title="Oatmeals" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Oatmeal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Welcome.</h1>
        <h2>Oatmeals group is proud to serve breakfast for you!</h2>
    <br>
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner">
                    <div class="item active">
                        <img src="~/Images/rest.jpg" alt="Restaurant" runat="server" style="width:100%;">
                        <div class="carousel-caption">
                            <h1>Exquisite interior</h1>

                        </div>
                    </div>
                    <div class="item">
                        <img src="~/Images/rr.jpg" alt="Food" runat="server" style="width:100%;">
                        <div class="carousel-caption">
                            <h1>Scrumptious food</h1>
                        </div>
                    </div>
                    <div class="item">
                        <img src="~/Images/aa.jpg" alt="New York" runat="server" style="width:100%;">
            <div class="carousel-caption">
                <h1>Bon appétit!</h1>
            </div>

                    </div>
                </div>
                <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
  </div>
</asp:Content>