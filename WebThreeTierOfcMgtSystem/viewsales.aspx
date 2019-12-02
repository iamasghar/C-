<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewsales.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.viewsales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">View Sales</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">View Sales</li>
                </ol>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <div class="container-fluid ">
        <table id="datatable" class="table table-bordered">
            <thead>
                <tr>
                    <th>TRX-ID</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Date</th>
                    <th>Sell By</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("trx_id") %></td>
                            <td><%# Eval("prd_title") %></td>
                            <td><%# Eval("prd_price") %></td>
                            <td><%# Eval("prd_quantity") %></td>
                            <td><%# Eval("prd_sell_date") %></td>
                            <td><%# Eval("prd_sell_by") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
