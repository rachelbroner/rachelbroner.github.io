<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="contact-us.aspx.cs" Inherits="contact_us" %>

<%@ Register Src="Controls/ContactForm.ascx" TagName="ContactForm" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <uc1:ContactForm ID="ContactForm1" runat="server" />
    <br />
    <center>
        <asp:Label ID="lbl_msg" runat="server" Text="Message Sent Succesfully" Font-Bold="True"
            ForeColor="Red" Visible="false">
        </asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_Send" runat="server" Text="Send Message" 
            onclick="btn_Send_Click" ValidationGroup="newaccount" />
    </center>
</asp:Content>
