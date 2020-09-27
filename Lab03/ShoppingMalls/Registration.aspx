<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ShoppingMalls.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="border: solid">
                <tr>
                    <td colspan="2">
                        <h2>User Registration</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                        <br />
                        
                         <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail"
                            runat="server" ErrorMessage="Email is Required"
                            ForeColor="Red" ControlToValidate="txtEmail"
                             Display="Dynamic"
                            Text="*"></asp:RequiredFieldValidator>
                        
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                            runat="server" ErrorMessage="Invalid Email Format" ControlToValidate="txtEmail" ForeColor="Red" Text="*"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w)*\.\w+([-.]\w+)*" Operator="Equal" Type="String"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>UserName</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                         <br />
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName"
                            runat="server"
                            ErrorMessage="UserName is required"
                            ForeColor="Red" ControlToValidate="txtName"
                             Display="Dynamic"
                            Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>Password</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Style="height: 25px" TextMode="Password"></asp:TextBox>
                         <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                            runat="server"
                            ErrorMessage="Password is required"
                            ForeColor="Red" ControlToValidate="txtPassword"
                            Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <b>ConfirmPassword</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCPass" runat="server" TextMode="Password"></asp:TextBox>
                         <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword"
                            runat="server"
                            ErrorMessage="Password and ConfirmPassword must macth"
                            ForeColor="Red" ControlToValidate="txtCPass"
                            ControlToCompare="txtPassword" Display="Dynamic"
                            ></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Page Error" ForeColor="Red"/>
                    </td>
                </tr>
                <tr>
                    <td>                    
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
