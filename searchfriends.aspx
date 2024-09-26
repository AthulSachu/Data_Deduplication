<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.master" AutoEventWireup="true" CodeFile="searchfriends.aspx.cs" Inherits="searchfriends" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 145%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
        }
        .style4
        {
            height: 75px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td align="center" class="style2">
                Search Friends</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;<asp:TextBox ID="txtsearchname" runat="server" placeholder="Enter Name" 
                    Height="40px" Width="300px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="btnsearchname" runat="server" Text="Search" 
                    onclick="btnsearchname_Click" BackColor="Black" ForeColor="White" 
                    Height="40px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="style4">
                <table id="tab" runat="server" style="width:100%;">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

