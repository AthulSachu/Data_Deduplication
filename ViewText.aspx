<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.master" AutoEventWireup="true" CodeFile="ViewText.aspx.cs" Inherits="ViewText" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" GridLines="Vertical" style="margin-left: 52px" 
                    Width="618px" Height="214px" onrowcommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkmail" runat="server" 
                                    CommandArgument='<%# Eval("[linkingid]") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblId" runat="server" Text='<%#Eval("[linkingid]") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    <%--<asp:TemplateField>
                    
                    <ItemTemplate>

                            <asp:Label ID="lblfrmid" runat="server" Text='<%#Eval("[From_id]") %>' Visible="True"></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>--%>



                     <%-- <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton  ID="lbllnk" runat="server" CommandName="details" CommandArgument='<%# Eval("[linkingid]") %>'  Text='<%#Eval("[textcontent]") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
--%>

                      
                        <asp:BoundField DataField="fromusername" HeaderText="From" />
                       <%--  <asp:BoundField DataField="tousername" HeaderText="To" />--%>
                          <asp:BoundField DataField="textcontent" HeaderText="Message" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Delete Text" />
    <br />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    </asp:Content>

