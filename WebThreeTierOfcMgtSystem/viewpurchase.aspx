<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewpurchase.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.viewpurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">View Purchases</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">View Purchases</li>
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
                    <th>Purchased By</th>
                    <th>Supplier By</th>
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
                            <td><%# Eval("prd_per_date") %></td>
                            <td><%# Eval("prd_per_by") %></td>
                            <td><%# Eval("prd_supplyer") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
