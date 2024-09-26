<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.master" AutoEventWireup="true" CodeFile="newpage.aspx.cs" Inherits="newpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            width: 116px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">





    <table class="style1">
        <tr>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                    Height="16px" onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                    Width="83px" RepeatDirection="Horizontal">
                    <asp:ListItem>Text</asp:ListItem>
                    <asp:ListItem>Image</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
               <asp:Panel ID="p1" runat="server" Visible="False">
    
    <table class="style1">
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Username:&nbsp;<asp:Label ID="lbluname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:<asp:Label ID="lblname" 
                    runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Text:&nbsp;
                <asp:TextBox ID="txtmessage" runat="server" TextMode="MultiLine" 
                    ontextchanged="txtmessage_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsend" runat="server" onclick="btnsend_Click" Text="Send" />
                <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
    </table>
    </asp:Panel></td>
        </tr>
        <tr><td></td>
        </tr>
        <tr><td>
            <asp:Panel ID="p2" runat="server" Visible="False">
                <table class="style1">
                    <tr>
                        <td>
                            <span class="style2">File</span>&nbsp;</td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" Height="42px" Width="248px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnPanelUpload" runat="server" Height="30px" 
                                OnClick="btnPanelUpload_Click" Text="Upload" Width="120px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Panel ID="Panel1" runat="server" BackColor="#CCFFFF" Visible="False">
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
                <br />
            </asp:Panel>
            </td>
        </tr>
        <tr><td>&nbsp;</td>
        </tr>
    </table>





    
</asp:Content>

