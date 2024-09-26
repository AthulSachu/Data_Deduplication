<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registeration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 121%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            width: 332px;
        }
        .style4
        {
            width: 332px;
            height: 30px;
        }
        .style5
        {
            height: 30px;
        }
        .style6
        {
            width: 332px;
            height: 74px;
        }
        .style7
        {
            height: 74px;
        }
        .style8
        {
            font-size: large;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center" colspan="2" class="style8">
                <strong>REGISTRATION</strong></td>
        </tr>
        <tr>
            <td class="style3">
                Username</td>
            <td>
                <asp:TextBox ID="txtuusername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtuusername" ErrorMessage="Enter username" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Password</td>
            <td>
                <asp:TextBox ID="txtupassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtupassword" ErrorMessage="Enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Name</td>
            <td>
                <asp:TextBox ID="txtufname" runat="server" 
                    ontextchanged="txtufname_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtufname" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Date of Birth</td>
            <td>
                <asp:TextBox ID="txtudob" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtudob" ErrorMessage="Enter  Date of birth" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Gender</td>
            <td class="style7">
                &nbsp;<asp:RadioButtonList ID="rbgender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="rbgender" ErrorMessage="Enter gender" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Age</td>
            <td>
                <asp:TextBox ID="txtuage" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="txtuage" ErrorMessage="Enter age" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Email</td>
            <td class="style5">
                <asp:TextBox ID="txtuemail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtuemail" ErrorMessage="Enter email" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtuemail" ErrorMessage="Enter valid email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Address</td>
            <td class="style5">
                <asp:TextBox ID="txtuaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="txtuaddress" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Mobile</td>
            <td>
                <asp:TextBox ID="txtumobile" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtumobile" ErrorMessage="Enter mobile number" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Upload Photo</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnusave" runat="server" Text="Save" onclick="btnusave_Click" 
                    BackColor="Black" ForeColor="White" Height="40px" Width="70px" />
                <asp:Button ID="btnuclr" runat="server" Text="Clear" onclick="btnuclr_Click" 
                    BackColor="Black" CausesValidation="False" ForeColor="White" Height="40px" 
                    Width="70px" />
                <asp:Button ID="Button1" runat="server" BackColor="Black" 
                    CausesValidation="False" ForeColor="White" Height="40px" 
                    PostBackUrl="~/login.aspx" Text="Back to Login" Width="120px" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style2" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
    </table>
</asp:Content>

