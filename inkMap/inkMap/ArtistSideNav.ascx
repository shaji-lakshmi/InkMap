<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArtistSideNav.ascx.cs" Inherits="inkMap.ArtistSideNav1" %>
   <div class="sidenav">
       <asp:Image ID="imgprofileImage" runat="server" Width="200px" Height="150px" />
                <br />
       <asp:Label ID="lblAccountName" runat="server"></asp:Label>
       <br />
       <br />

       <asp:LinkButton ID="lbtnSearch" runat="server" OnClick="lbtnSearch_Click">Search Aritists</asp:LinkButton>
        <br />
       <asp:LinkButton ID="lbtnSave" runat="server">Saved Artists</asp:LinkButton>
       <br />
       <asp:LinkButton ID="lbtnUpcoming" runat="server">Upcoming Appointments</asp:LinkButton>

            </div>