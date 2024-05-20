using MyWebForms.Core.Web.Models;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebForms.Core.Web
{

    public static class MvcUtility
    {
        private static void RenderPartial(string partialViewName, object model)
        {
            var httpContextBase = new HttpContextWrapper(HttpContext.Current);
            var routeData = new RouteData();
            routeData.Values.Add("controller", "Dummy");

            var controllerContext = new ControllerContext(new RequestContext(httpContextBase, routeData), new DummyController());

            var view = FindPartialView(controllerContext, partialViewName);
            var viewContext = new ViewContext(controllerContext, view, new ViewDataDictionary { Model = model }, new TempDataDictionary(), httpContextBase.Response.Output);
            view.Render(viewContext, httpContextBase.Response.Output);
        }

        private static IView FindPartialView(ControllerContext controllerContext, string partialViewName)
        {
            var viewEngineResult = ViewEngines.Engines.FindPartialView(controllerContext, partialViewName);
            if (viewEngineResult.View != null)
            {
                return viewEngineResult.View;
            }

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            foreach (string value in viewEngineResult.SearchedLocations)
            {
                stringBuilder.AppendLine(value);
            }

            throw new InvalidOperationException($"Partial view {partialViewName} not found. Locations Searched: {stringBuilder}");
        }

        public static void RenderAction(string controllerName, string actionName, object routeValues)
        {
            RenderPartial(nameof(DummyController.PartialRender), new RenderActionViewModel() { ControllerName = controllerName, ActionName = actionName, RouteValues = routeValues });
        }
    }
}
