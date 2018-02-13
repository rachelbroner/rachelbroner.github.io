<%@ Page Title="NumeroSay" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Label ID="lblFullName" runat="server" style="text-align: right;float:right" Text="הכנס שם מלא"></asp:Label>
    <asp:TextBox ID="txtFullName" runat="server" style="text-align: right;float:right" ToolTip="הכנס שם מלא"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFullName" ErrorMessage="שם זה שדה חובה" style="text-align: right;float:right" ></asp:RequiredFieldValidator>
    <br />
    <br />
    
    <asp:Label ID="lblDate" runat="server" style="text-align: right;float:right;direction:rtl" Text="הכנס תאריך לידה בפורמט הבא:"></asp:Label>
    <asp:Label ID="lblDateFormat" runat="server" style="text-align: right;float:right;direction:rtl" Text="dd/mm/yyyy"></asp:Label>
    <asp:TextBox ID="txtDate" style="text-align: right;float:right" runat="server" ToolTip="dd/mm/yyyy"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDate" ErrorMessage="תאריך ליזה זה שדה חובה" style="text-align: right;float:right"></asp:RequiredFieldValidator>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDate" ErrorMessage="The date has to be in the format dd/mm/yyyy" style="text-align: right;float:right" ValidationExpression="[0-9][0-9]*/[0-9][0-9]*/[1-2][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblErrors" runat="server" style="text-align: right;float:right;direction:rtl" Font-Bold="True" Font-Size="Large" ForeColor="#CC3300"></asp:Label>
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" style="text-align: right;float:right;direction:rtl" Text="שלח" OnClick="btnSubmit_Click" />
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Table ID="tblResults" style="text-align: right;float:none;direction:rtl" runat="server" Width="915px" BorderColor="Black" BorderStyle="Solid" GridLines="Both" Visible="False">
                <asp:TableRow ID="TableHead" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" HorizontalAlign="Center">
                    <asp:TableCell runat="server" Width="20%">תכונה</asp:TableCell>
                    <asp:TableCell runat="server">מאפיין</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="RowFourtune" runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">מזל</asp:TableCell>
                    <asp:TableCell ID="CellFourtune" runat="server"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="RowName" runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">מספר שם</asp:TableCell>
                    <asp:TableCell ID="CellNameNumber" runat="server"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="RowBirthNumber" runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">מספר יום הולדת</asp:TableCell>
                    <asp:TableCell ID="CellBirthNumber" runat="server"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="RowAttributes" runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">מאפייני אישיות</asp:TableCell>
                    <asp:TableCell ID="CellAttributes" runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    <p>
        &nbsp;</p>
    <br />
    </asp:Content>
