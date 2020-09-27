<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="GolfClub.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Name
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Gender
            <asp:DropDownList ID="drpGender" runat="server">
                <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
               <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
               <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Membership Fee
            <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
        </div>
    </form>
</body>
</html>
