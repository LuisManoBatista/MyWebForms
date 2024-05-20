using System.Web.Mvc;

namespace MyWebForms.Core.Web
{
    internal class DummyController : Controller
    {
        public ActionResult PartialRender()
        {
            return PartialView();
        }
    }
}
