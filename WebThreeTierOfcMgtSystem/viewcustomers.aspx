<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewcustomers.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.viewcustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">View Customers</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">View Customers</li>
                </ol>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <div class="row">
        <table id="datatable" class="table table-bordered">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Cnic</th>
                    <th>Cell</th>
                    <th>Address</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("u_id") %></td>
                            <td><%# Eval("name") %></td>
                            <td><%# Eval("cnic") %></td>
                            <td><%# Eval("cell") %></td>
                            <td><%# Eval("address") %></td>
                            <td>
                                <a href="edituser.aspx?edtusr=<%#Eval("u_id")%>" data-toggle="tooltip" title="Edit"><i class="far fa-edit"></i></a>
                                <a href="viewcustomers.aspx?dltcus=<%#Eval("u_id")%>" data-toggle="tooltip" title="Delete"><i class="far fa-trash-alt"></i></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
