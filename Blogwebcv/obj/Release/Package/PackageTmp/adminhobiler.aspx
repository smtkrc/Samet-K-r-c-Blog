<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminhobiler.aspx.cs" Inherits="Blogwebcv.adminhobiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server" style="background-color: rgb(128, 128, 128)">
        <table class="table table-bordered" style="background-color: rgb(128, 128, 128)">

            <tr>
                <th>ID</th>
                <th class="auto-style4">HOBİLER</th>
                <th class="auto-style4">İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%# Eval("ID") %></th>
                            <td><%# Eval("HOBI") %></td>
                           
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"hobisil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1"
                                    runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"hobiguncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2"
                                    runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>

                        </tr>

                    </ItemTemplate>

                </asp:Repeater>

            </tbody>

        </table>
        <asp:HyperLink NavigateUrl="~/hobiekle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Hobi Ekle</asp:HyperLink>
    </form>

</asp:Content>
