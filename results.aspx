<%@ Page Title="Results" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="results.aspx.cs" Inherits="results" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Save &amp; Download RESULTS" />
  <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataKeyNames="lineNumber"
        ForeColor="#333333" GridLines="None" AutoGenerateColumns="False"
        Width="755px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="lineNumber" HeaderText="Original Record" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="BirthDate" DataFormatString="{0:d}" HtmlEncode="false"
                HeaderText="Birth Date">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="BirthNumber" HeaderText="Birth Number">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="NameNumber" HeaderText="Name Number">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Fortune" HeaderText="Zodiac">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Attributes" HeaderText="Attributes">
                <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="SummingAttributes" HeaderText="Attributes Match">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ods_Fortunes" runat="server" SelectMethod="GetData" TypeName="FortuneDataSource"
        OnSelecting="ods_Fortunes_Selecting">
        <SelectParameters>
            <%--<asp:ControlParameter ControlID="CheckBoxList1" Name="sentAttributes" PropertyName="SelectedValue"
                Type="Object" />--%>
            <asp:Parameter Name="sentAttributes" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

