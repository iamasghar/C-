<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <div class="row">
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

    <div class="row">
        <div class="col-sm-7">
            <table>
                <tr>
                    <td id="pid">Prd ID</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_id" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>Title</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_title" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_price" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Stock</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_stock" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Expiry</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_expiry" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manufacture</td>
                    <td style="width: 567px">
                        <asp:TextBox ID="p_manuf" class="form-control" runat="server" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Image</td>
                    <td style="width: 567px">
                        <asp:FileUpload ID="files" runat="server" Width="560px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 567px">
                        <asp:Button ID="Insert" class="btn btn-primary" runat="server" OnClick="Insert_Click" Text="Insert" Width="121px" />
                        <asp:Button ID="Update" class="btn btn-primary" runat="server" Text="Update" Width="121px" OnClick="Update_Click" />
                        <asp:Button ID="Delete" class="btn btn-primary" runat="server" Text="Delete" Width="121px" OnClick="Delete_Click" />
                        <asp:Button ID="Show" class="btn btn-primary" runat="server" Text="Show" Width="121px" OnClick="Show_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="col-sm-5">
            <asp:Image ID="Image1" runat="server" Height="197px" Width="260px" />
            <div class="row pt-2 pb-2">
                <div class="col-sm-3">
                    <asp:TextBox ID="hidn_id" Style="display: none;" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="New Image"></asp:Label>
                </div>
                <div class="col-sm-9">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>
            <div class="row">
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Style="width: 70%;" Text="Update Image" OnClick="Button1_Click" />
            </div>
        </div>
    </div>

    <div class="row">
    </div>--%>

    <div class="row">
        <div class="col-sm-12">
            <div class="page-title-box">
                <h4 class="page-title">Add Products</h4>
                <ol class="breadcrumb float-right">
                    <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                    <li class="breadcrumb-item active">Add Products</li>
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
                        <asp:TextBox ID="p_id" parsley-trigger="change" required="" class="form-control" placeholder=" Product Id " runat="server"></asp:TextBox>
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
                        <asp:FileUpload ID="image" parsley-trigger="change" required="" class="form-control btn-block btn-dark" runat="server" />
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" Text="Submit" OnClick="Insert_Click" />
            </div>
        </div>
    </div>
</asp:Content>
