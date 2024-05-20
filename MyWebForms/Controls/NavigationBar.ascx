<%@ Import Namespace="MyWebForms.Core.Web" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavigationBar.ascx.cs" Inherits="MyWebForms.Controls.NavigationBar" %>

 <% MvcUtility.RenderAction( "Layout", "navigation", new { }); %>