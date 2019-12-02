<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adduser.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.adduser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="page-title-box">
                <div class="page-title-right">
                    <ol class="breadcrumb m-0">
                        <li class="breadcrumb-item"><a href="javascript: void(0);">Users</a></li>
                        <li class="breadcrumb-item active">Add User</li>
                    </ol>
                </div>
                <h4 class="page-title">Add User</h4>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="card-box">
                <h4 class="header-title">User Info</h4>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">User Id</label>
                        <asp:TextBox ID="u_id" na parsley-trigger="change" required class="form-control" placeholder=" User Id " runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Name</label>
                        <asp:TextBox ID="name" parsley-trigger="change" required class="form-control" placeholder="Name " runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Cnic</label>
                        <asp:TextBox ID="cnic" parsley-trigger="change" required class="form-control" placeholder="Cnic " runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Email</label>
                        <asp:TextBox ID="email" parsley-trigger="change" required class="form-control" placeholder="Email " runat="server" TextMode="Email"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Password</label>
                        <asp:TextBox ID="pwd" parsley-trigger="change" required class="form-control" placeholder="Password " runat="server" TextMode="Password">123</asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Conform Password</label>
                        <asp:TextBox ID="cpwd" parsley-trigger="change" required class="form-control" placeholder="Re-enter Password " runat="server" TextMode="Password">123</asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputCity" class="col-form-label">Phone Number</label>
                        <asp:TextBox ID="cell" parsley-trigger="change" required class="form-control" placeholder="Phone Number " runat="server" TextMode="Phone"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputState" class="col-form-label">Access Level</label>
                        <asp:DropDownList parsley-trigger="change" required ID="access_level" class="form-control" runat="server">
                            <%--                            <asp:ListItem Selected="True" Value="0">  -- Select --</asp:ListItem>--%>
                            <asp:ListItem Value="1">Admin</asp:ListItem>
                            <asp:ListItem Value="2">Employee</asp:ListItem>
                            <asp:ListItem Value="3">Customer</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="inputAddress" class="col-form-label">Address</label>
                    <asp:TextBox ID="address" parsley-trigger="change" required class="form-control" placeholder="Address " runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
