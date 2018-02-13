<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactForm.ascx.cs" Inherits="ContactForm" %>
<style type="text/css">
    .negativeBar
    {
        background-color: #E8E8E8;
    }
    .pwdBlankBar .positiveBar
    {
        width: 0%;
    }
    .pwdBlankBar .negativeBar
    {
        width: 100%;
    }
    
    .pwdWeakBar .positiveBar
    {
        background-color: Red;
        width: 30%;
    }
    .pwdWeakBar .negativeBar
    {
        width: 70%;
    }
    
    .pwdFairBar .positiveBar
    {
        background-color: #FFCC33;
        width: 65%;
    }
    .pwdFairBar .negativeBar
    {
        width: 35%;
    }
    
    .pwdStrengthBar .positiveBar
    {
        background-color: Green;
        width: 100%;
    }
    .pwdStrengthBar .negativeBar
    {
        width: 0%;
    }
    .style12
    {
        width: 201px;
    }
    .style14
    {
        width: 201px;
        height: 24px;
    }
    .style18
    {
        width: 223px;
    }
    .style20
    {
        width: 223px;
        height: 24px;
    }
</style>
<table cellpadding="0" border="0" cellspacing="0" style="width: 600px;">
    <tr>
        <td class="style18" style="width: 150px">
            <asp:Label ID="lbl_username" runat="server" Font-Bold="True" Text="Your Name:" 
                AssociatedControlID="tb_name"></asp:Label>
        </td>
        <td class="style12" style="width: 205px">
            <table style="width: 100%;">
                <tr>
                    <td>
            <asp:TextBox ID="tb_name" runat="server" Width="240px"></asp:TextBox>
                    </td>
                    <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_name"
                ErrorMessage="*" ForeColor="Red" ValidationGroup="newaccount"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style18" style="width: 150px;">
            <asp:Label ID="lbl_email" runat="server" Font-Bold="True" Text="Your Email:" 
                AssociatedControlID="tb_email"></asp:Label>
        </td>
        <td class="style12" style="width: 205px">
            <table style="width: 100%;">
                <tr>
                    <td>
            <asp:TextBox ID="tb_email" runat="server" Width="240px"></asp:TextBox>
                    </td>
                    <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_email"
                ErrorMessage="*" ForeColor="Red" ValidationGroup="newaccount"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
            <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="tb_email"
                Display="Dynamic" ErrorMessage="Invalid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ValidationGroup="newaccount"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style18" style="width: 150px;">
            <asp:Label ID="lbl_Password" runat="server" Font-Bold="True" Text="Subject:" 
                AssociatedControlID="tb_subject"></asp:Label>
        </td>
        <td class="style12" style="width: 205px">
            <table style="width: 100%;">
                <tr>
                    <td>
            <asp:TextBox ID="tb_subject" runat="server" Password="True" Width="240px" 
                ClientInstanceName="tbPassword"></asp:TextBox>
                    </td>
                    <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tb_subject"
                ErrorMessage="*" ForeColor="Red" ValidationGroup="newaccount"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style20" style="width: 150px;">
            <asp:Label ID="lbl_PasswordConfirm" runat="server" Font-Bold="True" Text="Message:"
                AssociatedControlID="tb_message"></asp:Label>
        </td>
        <td class="style14" style="width: 205px" colspan="1">
            <asp:TextBox ID="tb_message" runat="server" Password="True" Width="358px"
                TextMode="MultiLine" Height="168px" MaxLength="1000"></asp:TextBox>
            <br />
            Maximum 1000 characters</td>
    </tr>
    </table>
