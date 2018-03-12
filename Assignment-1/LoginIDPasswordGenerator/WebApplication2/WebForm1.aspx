<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="lblHeader" runat="server" Text="Welcome to LoginID and Password Generator" Font-Bold="True" BorderColor="#CC3300"></asp:Label> <br /><br /><br />
    <asp:Label ID="lblInput" runat="server" Text="Enter your input below"></asp:Label>
    <br /><br />
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text="Enter Your First Name"></asp:Label>
                </td>
                <td>
                    -
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" placeholder="First Name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblFirstNameError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLastName" runat="server" Text="Enter Your Last Name"></asp:Label>
                </td>
                <td>
                    -
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" placeholder="Last Name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblLastNameError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAge" runat="server" Text="Enter Your Age"></asp:Label>
                </td>
                <td>
                    -
                </td>
                <td>
                    <asp:TextBox ID="txtAge" TextMode="Number" placeholder="Age" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblAgeError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="Red" BorderColor="Blue" BorderStyle="Solid" ForeColor="White" OnClick="btnSubmit_Click" />&nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btnReset" runat="server" Text="Reset" BackColor="#3399FF" BorderColor="Black" OnClick="btnReset_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblAnswer" runat="server" Text=""></asp:Label>
                </td>
            </tr>    
        </table>
    </div>
    </form>
</body>
</html>
