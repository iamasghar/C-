<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.EmployeeForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="page-title-box">
                <div class="page-title-right">
                    <ol class="breadcrumb m-0">
                        <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                        <li class="breadcrumb-item active">Employee</li>
                    </ol>
                </div>
                <h4 class="page-title">Employees</h4>
            </div>
        </div>
    </div>

    <br />
    <br />
    <table style="width: 100%;">
        <tr>
            <td style="height: 22px; width: 162px">Emp ID :</td>
            <td style="height: 22px; width: 577px">
                <asp:TextBox ID="txt_eid" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 162px">Name : </td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_name" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">Cell # :</td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_cell" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">Address : </td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_address" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">Email :</td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_email" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">Password :</td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_password" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">Conform Password : </td>
            <td style="width: 577px">
                <asp:TextBox ID="txt_cpassword" class="form-control" runat="server" Width="370px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 162px">&nbsp;</td>
            <td style="width: 577px">
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Save" Width="90px" />
                <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="Update" Width="90px" />
                <asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="Delete" Width="90px" />
                <asp:Button ID="Button4" class="btn btn-primary" runat="server" OnClick="Button4_Click" Text="Search" Width="90px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
