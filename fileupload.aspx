<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="fileupload.aspx.cs" Inherits="fileupload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        search file<asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="BTNUPLOAD" runat="server" Text="upload" onclick="BTNUPLOAD_Click" />
    </p>
</asp:Content>

