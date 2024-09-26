<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="FILE_DETAILS.aspx.cs" Inherits="FILE_DETAILS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-size: x-large;
        }
        .style3
        {
            width: 116px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style1">
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
            <td valign="top">
                <span class="style2">File</span>
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" Height="42px" Width="248px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnPanelUpload" runat="server" OnClick="btnPanelUpload_Click" 
                    Text="Upload" Height="30px" Width="120px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False" BackColor="#CCFFFF">
                    <table class="style1">
                        <tr>
                            <td class="style3">
                                File Name
                            </td>
                            <td>
                                <asp:Label ID="lblfileName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                File Size
                            </td>
                            <td>
                                <asp:Label ID="lblfileSize" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                Fie Type
                            </td>
                            <td>
                                <asp:Label ID="lblfileType" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
