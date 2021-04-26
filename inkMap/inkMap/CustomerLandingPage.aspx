<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLandingPage.aspx.cs" Inherits="inkMap.CustomerLandingPage" %>

<%@ Register Src="~/CustomerMainNav.ascx" TagPrefix="uc1" TagName="CustomerMainNav" %>
<%@ Register Src="~/ArtistSideNav.ascx" TagPrefix="uc1" TagName="ArtistSideNav" %>





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
        <div class="container-fluid">
        <uc1:CustomerMainNav runat="server" id="CustomerMainNav" />
        <div>
            <uc1:ArtistSideNav runat="server" id="ArtistSideNav" />
        </div>
            </div>
    </form>
</body>
</html>
