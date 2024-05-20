using MyWebForms.Controlers.Base;
using MyWebForms.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyWebForms.Controlers
{
    public class ContactsController : RazorControllerBase
    {
        public ContactsController(IDemoService service)
        {

        }

        public async Task<ActionResult> Index()
        {
            await Task.CompletedTask;
            return RazorView();
        }
    }
}

