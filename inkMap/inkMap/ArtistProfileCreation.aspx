<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistProfileCreation.aspx.cs" Inherits="inkMap.ArtistProfileCreation" %>

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
        <div class="forms">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-m-4">
                    <h1 class="homePageTitle">
                        <asp:Label ID="ProfileTitle" runat="server" Text="Artist Profile Confirmation"></asp:Label></h1>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-2">
                    <asp:Label ID="lblUploadProfilePic" runat="server" Text="Upload Profile Picture:"></asp:Label>
                </div>
                <div class="col-md-2">
                    <asp:FileUpload ID="uploadProfilePic" runat="server" />

                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblFName" runat="server" Text="First Name:"></asp:Label>
                <br />
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                    <br />
                    <asp:Label ID="lblCompany" runat="server" Text="Company:"></asp:Label>
                    <br />
                </div>
                <div class="col-md-3">
                     <asp:Label ID="lblPrintFName" runat="server" ></asp:Label>
                <br />
                    <asp:Label ID="lblPrintEmail" runat="server" ></asp:Label>
                    <br />
                    <asp:Label ID="lblPrintCompany" runat="server" ></asp:Label>
                    <br />
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblLName" runat="server" Text="Last Name:"></asp:Label>
                <br />
                    <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone:"></asp:Label>
                    <br />
                    <asp:Label ID="lblLocation" runat="server" Text="Location:"></asp:Label>
                    <br />
                </div>
                <div class="col-md-3">
                     <asp:Label ID="lblPrintLName" runat="server" ></asp:Label>
                <br />
                    <asp:Label ID="lblPrintPhone" runat="server" ></asp:Label>
                    <br />
                    <asp:Label ID="lblPrintLocation" runat="server" ></asp:Label>
                    <br />
                </div>
    
            </div>
            <br />
                <div class="row">
                <div class="col-md-9"></div>
                <div class="col-md-3">
                   <asp:LinkButton ID="lbtnUpload" class="btn btn-lg btn-block btnredirect" runat="server" Text="Upload Work" OnClick="lbtnUpload_Click"></asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
