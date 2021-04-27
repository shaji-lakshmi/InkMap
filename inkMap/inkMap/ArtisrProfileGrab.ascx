<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArtisrProfileGrab.ascx.cs" Inherits="inkMap.ArtisrProfileGrab" %>

 <div class="main">
         <div class="row" id="Profileheading">
             <div class="col-md-3">
                 <asp:Image ID="gimgprofile" runat="server" Width="200px" Height="150px" />
             </div>
             <div class="col-md-2">
                 <asp:Label ID="lblgName" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
              
             <asp:Label ID="lblgEmail" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblgPhone" runat="server" Text="Label"></asp:Label>
             </div>
             <div class="col-md-1"></div>

             <div class="col-md-3">

                 <asp:Label ID="lblgCompany" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblgLocation" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
             <asp:Label ID="lblgRating" runat="server" Text="Label"></asp:Label>
             
             </div>

             <div class="col-md-3">
                    <asp:LinkButton ID="lbtnappointment" class="btn btn-lg btn-block btnredirect" runat="server" Text="Make Appointment"></asp:LinkButton>
                 <br /> 
                    <asp:LinkButton ID="lbtnAddTestimonial" class="btn btn-lg btn-block btnredirect" runat="server" Text="Add Testimonial"></asp:LinkButton>
             </div>

         </div>

            <div class="row">
                
                      <asp:Repeater ID="rptImages" runat="server">
                <ItemTemplate>
                    <asp:Image ID="gportfolio"  runat="server" ImageUrl='<%#Eval("imgFile") %>' Width="250px" Height="250px"/><br />
                </ItemTemplate>
            </asp:Repeater>
                </div>
      <div>
            <h1>Searches and returns testimonials by artist ID</h1>
            <asp:TextBox ID="txtartistid" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Button" onclick="btnSearch_Click"/>

            <asp:GridView ID="gvTestimonials" runat="server">
            </asp:GridView>
            <asp:Label ID="lblErrorMessage" runat="server" Text="Label"></asp:Label>
        </div>
     </div>