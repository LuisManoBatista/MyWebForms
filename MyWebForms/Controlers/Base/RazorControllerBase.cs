using System.Web.Mvc;

namespace MyWebForms.Controlers.Base
{
    public abstract class RazorControllerBase : Controller
    {
        protected RazorControllerBase()
        {
            ViewBag.IsRazorView = false;
            ViewBag.RazorHeadSection = "_PartialSectionHead";
            ViewBag.RazorBodySection = "_PartialSectionBody";
            ViewBag.IsRazorSectionHeadRendered = false;
            ViewBag.IsRazorSectionBodyRendered = false;
        }

        protected ActionResult RazorView()
        {
            return RazorView(GetCurrentViewName(), null);
        }

        protected ActionResult RazorView(string viewName)
        {
            return RazorView(viewName, null);
        }

        protected ActionResult RazorView(object model)
        {
            return RazorView(GetCurrentViewName(), model);
        }

        protected ActionResult RazorView(string viewName, object model)
        {
            ViewBag.ViewName = viewName;
            ViewBag.IsRazorView = true;
            return View(nameof(RazorView), model);
        }

        private string GetCurrentViewName()
        {
            const string actionName = "action";
            var result = $"{Url.RequestContext.RouteData.Values[actionName]}";
            return result;
        }
    }
}