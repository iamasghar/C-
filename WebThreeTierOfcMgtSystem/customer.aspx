<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="WebThreeTierOfcMgtSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
                        <div class="col-12">
                            <div class="page-title-box">
                                <div class="page-title-right">
                                    <ol class="breadcrumb m-0">
                                        <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                        <li class="breadcrumb-item active">Customer</li>
                                    </ol>
                                </div>
                                <h4 class="page-title"> Customers</h4>
                            </div>
                        </div>
                    </div>
    
    
    <table style="width: 100%; height: 154px; margin-bottom: 58px;">
    <br /><br />
        <tr>
            <td id="pid">Cus ID :</td>
            <td>
                <asp:TextBox ID="txt_eid" class="form-control"  runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Name :</td>
            <td>
                <asp:TextBox ID="txt_name" class="form-control"  runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>CnicCnic :</td>
            <td>
                <asp:TextBox ID="cnic" class="form-control"  runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Cell :</td>
            <td>
                <asp:TextBox ID="txt_cell" class="form-control"  runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Address :</td>
            <td>
                <asp:TextBox ID="txt_address" class="form-control"  runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                
                <asp:Button   class="btn btn-primary"  Width="88px"  ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                <asp:Button   class="btn btn-primary" Width="88px"  ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                <asp:Button  class="btn btn-primary"  Width="88px"  ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                <asp:Button   class="btn btn-primary" Width="88px"  ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
