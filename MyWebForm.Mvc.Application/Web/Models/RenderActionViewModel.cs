namespace MyWebForms.Core.Web.Models
{
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; }
    }
}
