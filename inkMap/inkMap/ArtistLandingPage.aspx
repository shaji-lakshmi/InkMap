<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistLandingPage.aspx.cs" Inherits="inkMap.ArtistLandingPage" %>

<%@ Register Src="~/ArtistSideNav.ascx" TagPrefix="uc1" TagName="ArtistSideNav" %>
<%@ Register Src="~/ArtistPortfolio.ascx" TagPrefix="uc1" TagName="ArtistPortfolio" %>
<%@ Register Src="~/ArtistMainNavascx.ascx" TagPrefix="uc1" TagName="ArtistMainNavascx" %>






<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:ArtistMainNavascx runat="server" id="ArtistMainNavascx" />
        <div>
            <uc1:ArtistSideNav runat="server" ID="ArtistSideNav" />
        </div>
        <div class="main">
            <uc1:ArtistPortfolio runat="server" id="ArtistPortfolio" />
        </div>
    </form>
</body>
</html>
