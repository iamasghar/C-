<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aa.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.aa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>HTML Table</h2>

    <table>
        <tr>
            <th>Company</th>
            <th>Contact</th>
            <th>Country</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("prd_title") %></td>
                    <td><%# Eval("prd_price") %></td>
                    <td><a href="products.aspx?id = <%# Eval("prd_id") %>">Check</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
