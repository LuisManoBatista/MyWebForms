using Microsoft.Extensions.DependencyInjection;
using MyWebForms.Services;
using System;
using System.Web.UI;

namespace MyWebForms
{
#pragma warning disable S101 // Types should be named in PascalCase
    public partial class _Default : Page
    {
        protected override void OnInit(EventArgs e)
        {
            _ = Startup.ServiceProvider.GetRequiredService<IDemoService>();
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Later Add code here
        }
    }
#pragma warning restore S101 // Types should be named in PascalCase
}