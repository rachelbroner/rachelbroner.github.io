<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AttributesFortuneCon.ascx.cs"
    Inherits="AttributesFortuneCon" %>
    <p>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Add Attribute-Zodiac Connection</asp:LinkButton>
</p>
<div visible="false" id="newAttributeForm" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Attribute:"></asp:Label><br />
                <asp:DropDownList ID="ddlAttributes" DataSourceID="AttributeDataSource" runat="server" DataValueField="Id" DataTextField="attribute">
                    </asp:DropDownList>
            </td>
            <td style="text-align: right">
                 <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Fortune:"></asp:Label><br />
                 <asp:DropDownList ID="ddlFortunes" DataSourceID="FortuneDataSource" runat="server" DataValueField="Id" DataTextField="fortune">
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSaveAttribute" runat="server" Text="Save" OnClick="btnSaveAttribute_Click"
                    Width="57px" />
            </td>
        </tr>
    </table>
</div>
<p>
    <asp:GridView ID="gvAttributes" runat="server" AutoGenerateColumns="False" DataKeyNames="IDattribute,IDfortune"
        DataSourceID="AttributeFortuneDataSource" Width="211px" 
        CellPadding="4" ForeColor="#333333"
        GridLines="None" onrowdatabound="gvAttributes_RowDataBound" 
        onrowupdating="gvAttributes_RowUpdating1" AllowSorting="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <%--<asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" />--%>
            <asp:TemplateField HeaderText="Attributes" SortExpression="attribute">
                <EditItemTemplate>
                    <asp:Label Visible="false" ID="lblAttributeID" runat="server" Text='<%# Eval("IDattribute") %>'></asp:Label>
                    <asp:DropDownList ID="ddlAttributes" runat="server">
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblAttribute" runat="server" Text='<%# Bind("attribute") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="100px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Zodiac" SortExpression="fortune">
                <EditItemTemplate>
                <asp:Label Visible="false" ID="lblFortuneID" runat="server" Text='<%# Eval("IDfortune") %>'></asp:Label>
                  <asp:DropDownList ID="ddlFortunes" runat="server">
                    </asp:DropDownList>      
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("fortune") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="20px" />
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" ButtonType="Image" EditImageUrl="~/images/edit.png">
                <ItemStyle Width="24px" />
            </asp:CommandField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                        CommandName="Delete" ImageUrl="~/images/delete.png" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this connection?');" />
                </ItemTemplate>
                <ItemStyle Width="24px" />
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:AccessDataSource ID="AttributeFortuneDataSource" runat="server" DataFile="~/App_Data/zodiac.mdb"
        DeleteCommand="DELETE FROM [attribute-fortune] WHERE IDattribute=? AND IDfortune=?"
        SelectCommand="SELECT attribute.attribute AS attribute, fortune.fortune AS fortune, attribute.Id AS IDAttribute, fortune.Id AS IDfortune FROM fortune INNER JOIN (attribute INNER JOIN [attribute-fortune] ON attribute.Id = [attribute-fortune].IDattribute) ON fortune.Id = [attribute-fortune].IDfortune;"
        UpdateCommand="SELECT Id FROM [attribute]"
        >
        <DeleteParameters>
            <asp:Parameter Name="IDattribute" Type="Int32" />
            <asp:Parameter Name="IDfortune" Type="Int32" />
        </DeleteParameters>
    
       
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AttributeDataSource" runat="server" DataFile="~/App_Data/zodiac.mdb"
        SelectCommand="SELECT Id, attribute FROM [attribute]"></asp:AccessDataSource>
    <asp:AccessDataSource ID="FortuneDataSource" runat="server" DataFile="~/App_Data/zodiac.mdb"
        SelectCommand="SELECT Id, fortune FROM [fortune]"></asp:AccessDataSource>

    
</p>
