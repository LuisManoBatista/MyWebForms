<%@ Import Namespace="MyWebForms.Core.Web" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainContentFooter.ascx.cs" Inherits="MyWebForms.Controls.MainContentFooter" %>

 <% MvcUtility.RenderAction( "layout", "footer", new { }); %>
