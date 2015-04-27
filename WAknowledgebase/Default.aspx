<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WAknowledgebase._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="padding: 0 !important;">
        <iframe src="slider/index.html" scrolling="no" width="100%" height="400" frameborder="0"></iframe>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Жүйемен танысу</h2>
            <p>
                Бұл жерде сіз порталдың барлық қызметтерімен танысып, өзіңізге қажетті бөлімді қолдана білуді уйрене аласыз...
            </p>
            <p>
                <a class="btn btn-default" href="About.aspx">Толығырақ &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Портал қызметкерлеріне сұрақ қою</h2>
            <p>
                Жер салығы бойынша портал қызметкерлеріне өзіңізге қажетті бөлім бойынша сұрақтар қосуға немесе алдын ала қосылған сұрақтар ішінен жауап алуыңызға болады.
            </p>
            <p>
                <a class="btn btn-default" href="Search.aspx">Толығырақ &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Құжаттар мен кодекстер жиынтығы</h2>
            <p>
               Жер салығы бойынша заң, кодекс, ережелердегі  жаңартулармен немесе өзгерістермен танысу
            </p>
            <p>
                <a class="btn btn-default" href="Search.aspx">Толығырақ &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
