using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MyWebForms.Core.Web
{
    public static class RenderHtmlHelperExtensions
    {
        public static bool TryRenderPartial(this HtmlHelper htmlHelper, string partialViewName)
        {
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(htmlHelper.ViewContext, partialViewName);
            if (result.View != null)
            {
                htmlHelper.RenderPartial(partialViewName);
                return true;
            }
            return false;
        }

        public static bool TryRenderPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData)
        {
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(htmlHelper.ViewContext, partialViewName);
            if (result.View != null)
            {
                htmlHelper.RenderPartial(partialViewName, viewData);
                return true;
            }
            return false;
        }

        public static bool TryRenderPartial(this HtmlHelper htmlHelper, string partialViewName, object model)
        {
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(htmlHelper.ViewContext, partialViewName);
            if (result.View != null)
            {
                htmlHelper.RenderPartial(partialViewName, model);
                return true;
            }
            return false;
        }

        public static bool TryRenderPartial(this HtmlHelper htmlHelper, string partialViewName, object model, ViewDataDictionary viewData)
        {
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(htmlHelper.ViewContext, partialViewName);
            if (result.View != null)
            {
                htmlHelper.RenderPartial(partialViewName, model, viewData);
                return true;
            }
            return false;
        }
    }
}
