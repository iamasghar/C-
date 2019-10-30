<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.products" %>

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
        <table id="datatable" class="table table-bordered">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Price</th>
                    <th>Stock</th>
                    <th>Expairy</th>
                    <th>Manuf</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("prd_id") %></td>
                            <td style="padding: 5px;">
                                <img src="/upload/<%# Eval("img") %>" style="width: 70px; height: 45px;" /></td>
                            <td><%# Eval("prd_title") %></td>
                            <td><%# Eval("prd_price") %></td>
                            <td><%# Eval("prd_stock") %></td>
                            <td><%# Eval("prd_expiry") %></td>
                            <td><%# Eval("prd_manufacturer") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
