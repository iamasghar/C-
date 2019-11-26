<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validate.aspx.cs" Inherits="WebThreeTierOfcMgtSystem.validate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validate</title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script>
        $.validator.addMethod('CNIC', function (value) {
            return /^(\d{5}-\d{7}-\d{1})$/.test(value);
        }, "Please enter your cnic in this formate (01234-5555555-6)");
        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    name: "required",
                    passw: {
                        required : true,
                        minlength : 8
                    },
                    cnic : "required CNIC",
                },
                messages : {
                    name: "Please Enter Your Name",
                    passw: "PLease enter 8 cha long pass"
                }

            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="name" runat="server" Width="482px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="passw" runat="server" TextMode="Password" Width="482px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Cnic</td>
                <td>
                    <asp:TextBox ID="cnic" runat="server" Width="483px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Button" Width="535px" />
                </td>
            </tr>
        </table>
    </div>
    </form>
    
    
</body>
</html>
