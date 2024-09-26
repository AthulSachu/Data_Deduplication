<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Changepassword.aspx.cs" Inherits="Changepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
        }
        .style4
        {
            width: 416px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center" class="style2" colspan="2">
                CHANGE PASSWORD</td>
        </tr>
        <tr>
            <td class="style4" align="center">
                Current password</td>
            <td>
                <asp:TextBox ID="txtcurrent" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtcurrent" ErrorMessage="Enter current password" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4" align="center">
                New password</td>
            <td>
                <asp:TextBox ID="txtnew" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtcurrent" ControlToValidate="txtnew" 
                    ErrorMessage="Current and new password equal" ForeColor="Red" 
                    Operator="NotEqual"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style4" align="center">
                Confirm password</td>
            <td>
                <asp:TextBox ID="txtconfirm" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToCompare="txtnew" ControlToValidate="txtconfirm" 
                    ErrorMessage="Password mismatch" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="center" class="style3" colspan="2">
                <asp:Button ID="btnchangesave" runat="server" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnchangeclr" runat="server" Text="Clear" />
            </td>
        </tr>
    </table>
</asp:Content>

