using MyWebForms.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyWebForms.Controlers
{
    public class AboutsController : Controller
    {
        public AboutsController(IDemoService service)
        {

        }

        public async Task<ActionResult> Index()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}

