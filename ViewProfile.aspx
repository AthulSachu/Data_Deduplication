<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="style1">
        <tr>
            <td>
                Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Email</td>
            <td class="style2">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Mobile</td>
            <td class="style2">
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Dob</td>
            <td>
                <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gender</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Age</td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:TextBox ID="txtAddres" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                UserName</td>
            <td class="style2">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="BtnDelete" runat="server" onclick="BtnDelete_Click" 
                    Text="Delete" />
            </td>
        </tr>
        <tr>
            <td colspan="2">

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" BackColor="Blue">
    <Columns>
         <asp:ButtonField CommandName="Select" Text="Select" ButtonType="Button" />
        <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150px" />
        <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-Width="150px" />
        <asp:BoundField DataField="Mobile" HeaderText="Mobile" ItemStyle-Width="150px" />
        <asp:BoundField DataField="Dob" HeaderText="Dob" ItemStyle-Width="150px" />      
        <asp:BoundField DataField="Gender" HeaderText="Gender" ItemStyle-Width="150px" />  
        <asp:BoundField DataField="Age" HeaderText="Age" ItemStyle-Width="150px" />
        <asp:BoundField DataField="Address" HeaderText="Address" ItemStyle-Width="150px" /> 
        <asp:BoundField DataField="Username" HeaderText="Username" ItemStyle-Width="150px" />    
        <asp:TemplateField HeaderText="ID" ItemStyle-Width="150" Visible="false">
            <ItemTemplate>
                <asp:Label ID="lblID" runat="server" Text='<%# Eval("UserId") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

