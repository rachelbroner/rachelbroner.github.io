<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageAttributes.ascx.cs"
    Inherits="Controls_ManageAttributes" %>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Add Attribute</asp:LinkButton>
</p>
<div visible="false" id="newAttributeForm" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Attribute:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbAttribute" runat="server" MaxLength="100" Width="120px"></asp:TextBox>
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
    <asp:Label runat="server" ID="lblErrorMessage" Visible="False"></asp:Label>
    <asp:GridView ID="gvAttributes" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"
        DataSourceID="AccessDataSource1" Width="211px" CellPadding="4" ForeColor="#333333"
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <%--<asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" />--%>
            <asp:BoundField DataField="attribute" HeaderText="Attributes" SortExpression="attribute">
                <ItemStyle Width="120px" />
            </asp:BoundField>
            <asp:CommandField ShowEditButton="True" ButtonType="Image" EditImageUrl="~/images/edit.png">
                <ItemStyle Width="24px" />
            </asp:CommandField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                        CommandName="Delete" ImageUrl="~/images/delete.png" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this attribute?');" />
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
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/zodiac.mdb"
        DeleteCommand="DELETE FROM [attribute] WHERE [Id] = ?" InsertCommand="INSERT INTO [attribute] ([attribute]) VALUES (?)"
        SelectCommand="SELECT * FROM [attribute]" UpdateCommand="UPDATE [attribute] SET [attribute] = ? WHERE [Id] = ?">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="attribute" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="attribute" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
</p>
