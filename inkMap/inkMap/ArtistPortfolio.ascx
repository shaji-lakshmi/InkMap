<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArtistPortfolio.ascx.cs" Inherits="inkMap.ArtistPortfolio" %>
 
     <div class="main">
         <div class="row" id="Profileheading">
             <div class="col-md-3">
                 <asp:Image ID="imgprofile" runat="server" Width="200px" Height="150px" />
             </div>
             <div class="col-md-2">
                 <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
              
             <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
             </div>
             <div class="col-md-1"></div>

             <div class="col-md-3">

                 <asp:Label ID="lblCompany" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblLocation" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblRating" runat="server" Text="Label"></asp:Label>
             
             </div>
             


             
         </div>

         <div class="row">
              <asp:Repeater ID="rptImages" runat="server">
                <ItemTemplate>
                    <asp:Image ID="Image1"  runat="server" ImageUrl='<%#Eval("imgFile") %>' Width="250px" Height="250px"/><br />
                </ItemTemplate>
            </asp:Repeater>
         </div>
     </div>

