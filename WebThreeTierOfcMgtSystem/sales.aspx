<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.sales" %>

<script runat="server">

    protected void Show_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="row">
                        <div class="col-12">
                            <div class="page-title-box">
                                <div class="page-title-right">
                                    <ol class="breadcrumb m-0">
                                        <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                        <li class="breadcrumb-item active">Sales</li>
                                    </ol>
                                </div>
                                <h4 class="page-title">Bike Spare Parts</h4>
                            </div>
                        </div>
                    </div>
    
    
    <asp:Label ID="success" runat="server" ForeColor="#00CC00"></asp:Label>
    <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <table style="width: 100%; height: 247px;">
            <tr>
                <td>Trx ID</td>
                <td style="width: 379px">
                    <asp:TextBox ID="trxid"  class="form-control"  runat="server" Width="370px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 35px">Products</td>
                <td style="height: 35px; width: 379px">
                    <asp:DropDownList ID="products"  class="form-control"  runat="server" Height="36px" Width="370px" OnSelectedIndexChanged="products_SelectedIndexChanged">
                        <asp:ListItem>     --- Select Product ---</asp:ListItem>
                    </asp:DropDownList>
                    
                </td>
                <td style="height: 35px"><asp:Button ID="Show" class="btn btn-info"  runat="server" OnClick="Show_Click" Text="Show" Width="80px" /></td>
            </tr>
            <tr>
                <td>Price</td>
                <td style="width: 379px">
                    <asp:TextBox ID="price" class="form-control"  runat="server" Width="370px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Stock</td>
                <td style="width: 379px">
                    <asp:TextBox ID="stock" class="form-control"  runat="server" Width="370px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Quantaty</td>
                <td style="width: 379px">
                    <asp:TextBox ID="quantaty" class="form-control"  runat="server" Width="370px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Date</td>
                <td style="width: 379px">
                    <asp:TextBox ID="date" class="form-control"  runat="server" Width="370px" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>SoldBy</td>
                <td style="width: 379px">
                    <asp:TextBox ID="soldby" class="form-control"  runat="server" Width="370px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 379px">
                    <asp:Button ID="Sell" class="btn btn-primary" runat="server" OnClick="Sell_Click" Text="Button" Width="370px" />
                </td>
            </tr>
        </table>
    <br />
    <div class="container-fluid">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
</asp:Content>
