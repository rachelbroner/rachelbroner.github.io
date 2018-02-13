<%@ Page Title="Content" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true"
    CodeFile="content.aspx.cs" Inherits="manager_content" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>
        Manage Content Pages</h1>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="500px">
        <asp:TabPanel runat="server" HeaderText="About Us" ID="TabPanel1">
            <ContentTemplate>
                <asp:TextBox ID="tbAbout" runat="server" Height="500px" Rows="100" Width="700px"></asp:TextBox>
                <asp:HtmlEditorExtender ID="TextBox1_HtmlEditorExtender" runat="server" Enabled="True"
                    TargetControlID="tbAbout" DisplaySourceTab="True">
                    <Toolbar>
                        <asp:Undo />
                        <asp:Redo />
                        <asp:Bold />
                        <asp:Italic />
                        <asp:Underline />
                        <asp:StrikeThrough />
                        <asp:Subscript />
                        <asp:Superscript />
                        <asp:JustifyLeft />
                        <asp:JustifyCenter />
                        <asp:JustifyRight />
                        <asp:JustifyFull />
                        <asp:InsertOrderedList />
                        <asp:InsertUnorderedList />
                        <asp:CreateLink />
                        <asp:UnLink />
                        <asp:RemoveFormat />
                        <asp:SelectAll />
                        <asp:UnSelect />
                        <asp:Delete />
                        <asp:Cut />
                        <asp:Copy />
                        <asp:Paste />
                        <asp:BackgroundColorSelector />
                        <asp:ForeColorSelector />
                        <asp:FontNameSelector />
                        <asp:FontSizeSelector />
                        <asp:Indent />
                        <asp:Outdent />
                        <asp:InsertHorizontalRule />
                        <asp:HorizontalSeparator />
                    </Toolbar>
                </asp:HtmlEditorExtender>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Privacy">
            <ContentTemplate>
                <asp:TextBox ID="tbPrivacy" runat="server" Height="500px" Rows="100" Width="700px"></asp:TextBox>
                <asp:HtmlEditorExtender ID="HtmlEditorExtender1" runat="server" Enabled="True" TargetControlID="tbPrivacy"
                    DisplaySourceTab="True">
                    <Toolbar>
                        <asp:Undo />
                        <asp:Redo />
                        <asp:Bold />
                        <asp:Italic />
                        <asp:Underline />
                        <asp:StrikeThrough />
                        <asp:Subscript />
                        <asp:Superscript />
                        <asp:JustifyLeft />
                        <asp:JustifyCenter />
                        <asp:JustifyRight />
                        <asp:JustifyFull />
                        <asp:InsertOrderedList />
                        <asp:InsertUnorderedList />
                        <asp:CreateLink />
                        <asp:UnLink />
                        <asp:RemoveFormat />
                        <asp:SelectAll />
                        <asp:UnSelect />
                        <asp:Delete />
                        <asp:Cut />
                        <asp:Copy />
                        <asp:Paste />
                        <asp:BackgroundColorSelector />
                        <asp:ForeColorSelector />
                        <asp:FontNameSelector />
                        <asp:FontSizeSelector />
                        <asp:Indent />
                        <asp:Outdent />
                        <asp:InsertHorizontalRule />
                        <asp:HorizontalSeparator />
                        <%-- <asp:InsertImage />--%>
                    </Toolbar>
                </asp:HtmlEditorExtender>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="FAQ">
            <ContentTemplate>
                <asp:TextBox ID="tbFAQ" runat="server" Height="500px" Rows="100" Width="700px"></asp:TextBox>
                <asp:HtmlEditorExtender ID="HtmlEditorExtender2" runat="server" Enabled="True" TargetControlID="tbFAQ"
                    DisplaySourceTab="True">
                    <Toolbar>
                        <asp:Undo />
                        <asp:Redo />
                        <asp:Bold />
                        <asp:Italic />
                        <asp:Underline />
                        <asp:StrikeThrough />
                        <asp:Subscript />
                        <asp:Superscript />
                        <asp:JustifyLeft />
                        <asp:JustifyCenter />
                        <asp:JustifyRight />
                        <asp:JustifyFull />
                        <asp:InsertOrderedList />
                        <asp:InsertUnorderedList />
                        <asp:CreateLink />
                        <asp:UnLink />
                        <asp:RemoveFormat />
                        <asp:SelectAll />
                        <asp:UnSelect />
                        <asp:Delete />
                        <asp:Cut />
                        <asp:Copy />
                        <asp:Paste />
                        <asp:BackgroundColorSelector />
                        <asp:ForeColorSelector />
                        <asp:FontNameSelector />
                        <asp:FontSizeSelector />
                        <asp:Indent />
                        <asp:Outdent />
                        <asp:InsertHorizontalRule />
                        <asp:HorizontalSeparator />
                        <%-- <asp:InsertImage />--%>
                    </Toolbar>
                </asp:HtmlEditorExtender>
            </ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>
    <br />
    <br />
    <asp:Button ID="btnAbout" runat="server" Text="Update" 
    OnClick="btnAbout_Click" TabIndex="1" Height="31px" Width="82px" />
    
</asp:Content>
