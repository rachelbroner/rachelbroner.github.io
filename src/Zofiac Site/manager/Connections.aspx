<%@ Page Title="Connections" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true"
    CodeFile="Connections.aspx.cs" Inherits="Connections" %>

<%@ Register Src="~/Controls/ManageAttributes.ascx" TagName="ManageAttributes" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/AttributesBirthNumnerCon.ascx" TagName="AttributesBirthNumnerCon"
    TagPrefix="uc2" %>
<%@ Register Src="~/Controls/AttributesNameNumberCon.ascx" TagName="AttributesNameNumberCon"
    TagPrefix="uc3" %>
<%@ Register Src="~/Controls/AttributesFortuneCon.ascx" TagName="AttributesFortuneCon"
    TagPrefix="uc4" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Manage Connections Tables</h2>
    <table style="width: 100%" runat="server" ID="tblContainer">
        <tr>
            <td valign="top">
                <uc4:AttributesFortuneCon ID="AttributesFortuneCon1" runat="server" />
            </td>
            <td valign="top">
                <uc2:AttributesBirthNumnerCon ID="AttributesBirthNumnerCon1" runat="server" />
            </td>
            <td valign="top">
                <uc3:AttributesNameNumberCon ID="AttributesNameNumberCon1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
