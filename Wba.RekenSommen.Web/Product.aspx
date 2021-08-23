<%@ Page Title="" Language="C#" MasterPageFile="~/Rekenen.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Wba.RekenSommen.Web.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MasterContent" runat="server">
        <div class="jumbotron">
        <h1>Vermenigvuldiging</h1>
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-1 col-lg-3"></div>
            <div class="col-10 col-lg-6">
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text">
                            <asp:Label ID="lblGetal1" runat="server" Text=""></asp:Label></span>
                        <span class="input-group-text">x</span>
                        <span class="input-group-text">
                            <asp:Label ID="lblGetal2" runat="server" Text=""></asp:Label></span>
                        <span class="input-group-text">=</span>

                    </div>
                    <asp:TextBox ID="txtProduct" runat="server" CssClass="form-control"></asp:TextBox>
                    <div class="input-group-append">
                        <asp:Button ID="btnControleProduct" runat="server" Text="Controle" OnClick="btnControleProduct_Click" CssClass="btn btn-primary" />
                        <asp:Label ID="lblResultaatProduct" runat="server" Text="" CssClass="form-control" Style="min-width: 150px;"></asp:Label>
                        <asp:LinkButton ID="lnkRefresh" runat="server" CssClass="btn btn-dark" OnClick="lnkRefresh_Click"><i class="fas fa-sync-alt"></i></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-1 col-lg-3"></div>
    </div>
</asp:Content>

