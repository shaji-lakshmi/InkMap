<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistSearch.aspx.cs" Inherits="inkMap.ArtistSearch" %>

<%@ Register Src="~/CustomerMainNav.ascx" TagPrefix="uc1" TagName="CustomerMainNav" %>
<%@ Register Src="~/ArtistSideNav.ascx" TagPrefix="uc1" TagName="ArtistSideNav" %>
<%@ Register Src="~/ArtistMainNavascx.ascx" TagPrefix="uc1" TagName="ArtistMainNavascx" %>





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
            <uc1:ArtistMainNavascx runat="server" ID="ArtistMainNavascx" />
            <div>
                <uc1:ArtistSideNav runat="server" ID="ArtistSideNav" />
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
                    <div class="col-md-5"></div>
                    
                    <div class="col-md-3">
                        <br />
                    <br />
                     <asp:LinkButton ID="lbtnViewProfile" runat="server" class="btn btn-primary" OnClick="lbtnViewProfile_Click">View Sample Artist Profile</asp:LinkButton>

                 <asp:Label ID="lblNoresults" runat="server"></asp:Label>
</div>
                </div>
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <div class="card">
                    <asp:Repeater ID="rptsearchResults" runat="server">
                    <ItemTemplate>
                         <asp:Label ID="lblArtistFName" runat="server" Text='<%#Eval("artist_FName") %>'></asp:Label>
                                <asp:Label ID="lblArtistLName" runat="server" Text='<%#Eval("artist_LName") %>'></asp:Label>

                        <br />
                        <br />
                        <asp:Label ID="lblCompany" runat="server" Text='<%#Eval("company") %>'></asp:Label>
                        <br />
                        <br />
                         <asp:Label ID="lblCity" runat="server" Text='<%#Eval("city") %>'></asp:Label>
                                    <asp:Label ID="lblState" runat="server" Text='<%#Eval("state") %>'></asp:Label>
                        <br />
                       <br />
                        <asp:Label ID="lblRating" runat="server" Text='<%#Eval("rating") %>'></asp:Label>
                        <br />
                        <br />
                         <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("email") %>'></asp:Label>
                                               <br />
                        <br />
                   <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("phoneNumber") %>'></asp:Label>

                    </ItemTemplate>
                      </asp:Repeater>
                </div>
                        </div>
            </div>
        </div>
    </form>
</body>
</html>
