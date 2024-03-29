﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="supplyers.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.supplyers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="page-title-box">
                <div class="page-title-right">
                    <ol class="breadcrumb m-0">
                        <li class="breadcrumb-item"><a href="javascript: void(0);">Suppliers</a></li>
                        <li class="breadcrumb-item active">Add Supplier</li>
                    </ol>
                </div>
                <h4 class="page-title">Add User</h4>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="card-box">
                <h4 class="header-title">Supplier Info</h4>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Id<span class="text-danger">*</span></label>
                        <asp:TextBox ID="txt_sid" parsley-trigger="change" required="" class="form-control" placeholder=" Supplier Id " runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox ID="hdnpass" Style="display: none;" runat="server"></asp:TextBox>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Name<span class="text-danger">*</span></label>
                        <asp:TextBox ID="txt_name" parsley-trigger="change" required="" class="form-control" placeholder="Name " runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Phone <span class="text-danger">*</span></label>
                        <asp:TextBox ID="txt_cell" parsley-trigger="change" required="" class="form-control" placeholder="Phone Number " runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Address<span class="text-danger">*</span></label>
                        <asp:TextBox ID="txt_address" parsley-trigger="change" required="" class="form-control" placeholder="Address " runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
