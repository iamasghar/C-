<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editproduct.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.editproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">Edit Products</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">Edit Products</li>
                </ol>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="card-box">
                <h4 class="header-title">Product Info</h4>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Id<span class="text-danger">*</span></label>
                        <asp:TextBox ID="p_id" ReadOnly="true" class="form-control" placeholder=" Product Id " runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox ID="hdnpass" Style="display: none;" runat="server"></asp:TextBox>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Name<span class="text-danger">*</span></label>
                        <asp:TextBox ID="p_name" parsley-trigger="change" required="" class="form-control" placeholder="Name " runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Price <span class="text-danger">*</span></label>
                        <asp:TextBox ID="p_price" parsley-trigger="change" required="" class="form-control" placeholder="Price " runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Stock <span class="text-danger">*</span></label>
                        <asp:TextBox ID="p_stock" parsley-trigger="change" required="" class="form-control" placeholder="Stock " runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4" class="col-form-label">Expiry <span class="text-danger">*</span></label>
                        <asp:TextBox ID="expiry" parsley-trigger="change" required="" class="form-control" placeholder="22/06/2999 " runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4" class="col-form-label">Manufactured By<span class="text-danger">*</span></label>
                        <asp:TextBox ID="p_manuf" parsley-trigger="change" required="" class="form-control" placeholder="Manufactured By " runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-12">
                        <label for="inputEmail4" class="col-form-label">Image</label>
                        <asp:TextBox ID="hdnimg" Style="display: none;" runat="server"></asp:TextBox>
                        <asp:FileUpload ID="image" class="form-control btn-block btn-dark" runat="server" />
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
