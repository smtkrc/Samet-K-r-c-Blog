﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="EgıtımEkle.aspx.cs" Inherits="Blogwebcv.EgıtımEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <form id="form1" runat="server">
            <div class="form-group">

                <div>
                    <asp:Label ID="Label1" runat="server" ForeColor="White" Font-Italic="true" Text="Başlık"></asp:Label>
                    <asp:TextBox ID="txtbaslık" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="Label2" runat="server" ForeColor="White" Font-Italic="true" Text="altBaşlık"></asp:Label>
                    <asp:TextBox ID="txtaltbaslık" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="Label3" runat="server" ForeColor="White" Font-Italic="true" Text="Açıklama"></asp:Label>
                    <asp:TextBox ID="txtacıklama" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="Label5" runat="server" ForeColor="White" Font-Italic="true" Text="Genel not ortalaması"></asp:Label>
                    <asp:TextBox ID="txtgnot" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="Label4" runat="server" ForeColor="White" Font-Italic="true" Text="Tarih"></asp:Label>
                    <asp:TextBox ID="txttarıh" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />

                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />

            </div>

        </form>


</asp:Content>
