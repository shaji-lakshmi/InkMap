<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistPortfolioCreation.aspx.cs" Inherits="inkMap.ArtistPortfolioCreation" %>

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
                        <asp:Label ID="lblPortfolioTitle" runat="server" Text="Upload Your Work"></asp:Label></h1>
                </div>
            </div>
                   <br />
                   <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-2">
                    <asp:Label ID="lblUploadportfoliopics" runat="server" Text="Upload Images:"></asp:Label>
                </div>
                <div class="col-md-2">
                    <asp:FileUpload ID="uploadPortfolio" runat="server" />
                </div>
            </div>
                   <br />
                    <br />
                <div class="row">
                <div class="col-md-6"></div>
                    <div class="col-md-3">
                   <asp:LinkButton ID="lbtnAddMore" class="btn btn-lg btn-block btnredirect" runat="server" Text="Add Another Picture" OnClick="lbtnAddMore_Click"></asp:LinkButton>
                </div>
                <div class="col-md-3">
                   <asp:LinkButton ID="lbtnUploadPortfolio" class="btn btn-lg btn-block btnredirect" runat="server" Text="Create" OnClick="lbtnUploadPortfolio_Click"></asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
