<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArtistMainNavascx.ascx.cs" Inherits="inkMap.ArtistMainNavascx" %>


<nav class="navbar navbar-expand-lg">
  <a class="navbar-brand" href="#">InkMap</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
    <div class="navbar-nav">
        <asp:LinkButton ID="LinkButton1" runat="server" class="nav-item nav-link" OnClick="LinkButton1_Click">Profile</asp:LinkButton>
      <a class="nav-item nav-link" href="#">Settings</a>
      <a class="nav-item nav-link" href="Default.aspx">Logout</a>
    </div>
  </div>
</nav>