<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddReplyForm.aspx.cs" Inherits="WAknowledgebase.AddReplyForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="Бөлімді таңдаңыз:"></asp:Label>
    <asp:DropDownList runat="server" ID="ddlSection" ToolTip="Бөлімді таңдаңыз" />
</asp:Content>
