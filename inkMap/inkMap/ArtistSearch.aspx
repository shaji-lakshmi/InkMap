<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistSearch.aspx.cs" Inherits="inkMap.ArtistSearch" %>

<%@ Register Src="~/CustomerMainNav.ascx" TagPrefix="uc1" TagName="CustomerMainNav" %>
<%@ Register Src="~/ArtistSideNav.ascx" TagPrefix="uc1" TagName="ArtistSideNav" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ArtistSearch</title>
        <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="assets/css/global.css" rel="stylesheet" />
</head>

<body>
    <form id="ArtistSearch" runat="server">
        <div class="container-fluid">
            <uc1:CustomerMainNav runat="server" ID="CustomerMainNav" />
            <div>
                <uc1:ArtistSideNav runat="server" id="ArtistSideNav" />
                </div>
            <div class="main">
               <br />
                <br />
                <div class="row">

                     <div class="col-md-2"></div>
                    <div class="col-md-6">
            <asp:TextBox ID="txtLocationArtist" runat="server" Text="Zip or City"></asp:TextBox>
           
            <asp:Button ID="btnLocationSearch" runat="server" Text="Search" OnClick="btnLocationSearch_Click" />
            <br />
                        </div>
                       </div>
                <br />
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-3">
                        <div class="card">
  <div class="card-header">
    <asp:Label ID="lblArtistFName" runat="server" Text=""></asp:Label> <asp:Label ID="lblArtistLName" runat="server" Text=""></asp:Label>
  </div>
  <div class="card-body">
    <p class="card-text"></p>
      <p class="card-text"><asp:Label ID="lblCompany" runat="server" Text="Label"></asp:Label></p>

      <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>
      <p class="card-text"><asp:Label ID="lblState" runat="server" Text="Label"></asp:Label></p>
    <a href="#" class="btn btn-primary">View Profile</a>
  </div>
</div>
            
            <br />
            
            <br />
            
            <br />
            
            <br />
            
                        </div>
     </div>
                </div>
            </div>
    </form>
</body>
</html>
