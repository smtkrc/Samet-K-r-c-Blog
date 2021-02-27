<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminyetenekler.aspx.cs" Inherits="Blogwebcv.adminyetenekler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server" style="background-color: rgb(128, 128, 128)">
        <table class="table table-bordered" style="background-color: rgb(128, 128, 128)">

            <tr>
                <th>ID</th>
                <th class="auto-style4">YETENEK</th>
                <th class="auto-style4">İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%# Eval("ID") %></th>
                            <td><%# Eval("YETENEK") %></td>
                           
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"yeteneksil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1"
                                    runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"yetenekguncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2"
                                    runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>

                        </tr>

                    </ItemTemplate>

                </asp:Repeater>

            </tbody>

        </table>
        <asp:HyperLink NavigateUrl="~/yetenekekle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
    </form>

</asp:Content>
