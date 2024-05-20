<%@ Import Namespace="MyWebForms.Core.Web" %>
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Mvc.Master" CodeBehind="RazorView.aspx.cs" Inherits="MyWebForms.Views.Shared.RazorView" %>

<asp:Content ID="RazorHead" ContentPlaceHolderID="head" runat="server">
    <% 
        Html.TryRenderPartial((string)ViewBag.RazorHeadSection);
        ViewBag.IsRazorSectionHeadRendered = true;
    %>
</asp:Content>

<asp:Content ID="RazorBodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <% Html.TryRenderPartial((String)ViewBag.ViewName); %>
</asp:Content>

<asp:Content ID="RazorBodyScripts" ContentPlaceHolderID="MainScripts" runat="server">
    <% Html.TryRenderPartial((String)ViewBag.RazorBodySection); %>
</asp:Content>
