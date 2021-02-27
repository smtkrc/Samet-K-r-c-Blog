<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="sertifikaguncelle.aspx.cs" Inherits="Blogwebcv.sertifikaguncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label5" runat="server" ForeColor="White" Font-Italic="true" Text="ID"></asp:Label>
                <asp:TextBox ID="txtıd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" ForeColor="White" Font-Italic="true" Text="EGİTİM"></asp:Label>
                <asp:TextBox ID="txtbaslık" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />


            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />

        </div>

    </form>

</asp:Content>
