<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistSearch.aspx.cs" Inherits="inkMap.ArtistSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ArtistSearch</title>
</head>
<body>
    <form id="ArtistSearch" runat="server">
        <div>
            <asp:TextBox ID="txtLocationArtist" runat="server"></asp:TextBox>

            <asp:Button ID="btnLocationSearch" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
