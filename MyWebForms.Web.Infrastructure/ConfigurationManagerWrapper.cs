using System.Configuration;

namespace MyWebForms.Web.Infrastructure
{
    public static class ConfigurationManagerWrapper
    {
        public static string GetConnectionString(string name = "DefaultConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
