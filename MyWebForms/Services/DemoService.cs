using MyWebForms.Core.Persistence.Abstractions;

namespace MyWebForms.Services.Abstractions
{
    public class DemoService : IDemoService
    {
        public DemoService(IAuthenticationRepository options)
        {

        }
        public string GetDemoData()
        {
            return "Demo Data";
        }
    }
}