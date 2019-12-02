<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewproducts.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.viewproducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">View Products</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">View Products</li>
                </ol>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <div class="container-fluid ">
        <table id="datatable" class="table table-bordered">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Price</th>
                    <th>Stock</th>
                    <th>Expairy</th>
                    <th>Manuf</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="padding: 5px;">
                                <img src="/upload/<%# Eval("img") %>" style="width: 70px; height: 45px;" /></td>
                            <td><%# Eval("prd_title") %></td>
                            <td><%# Eval("prd_price") %></td>
                            <td><%# Eval("prd_stock") %></td>
                            <td><%# Eval("prd_expiry") %></td>
                            <td><%# Eval("prd_manufacturer") %></td>
                            <td>
                                <a href="editproduct.aspx?edtprd=<%# Eval("prd_id") %>" data-toggle="tooltip" title="Edit"><i class="far fa-edit"></i></a>
                                <a href="editproductimage.aspx?edtprdimg=<%# Eval("prd_id") %>" data-toggle="tooltip" title="Edit Image"><i class="far fa-image"></i></a>
                                <a href="viewproducts.aspx?dltprd=<%# Eval("prd_id") %>" data-toggle="tooltip" title="Delete"><i class="far fa-trash-alt"></i></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
