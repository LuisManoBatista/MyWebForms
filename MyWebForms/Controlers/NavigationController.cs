using MyWebForms.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyWebForms.Controlers
{
    public class LayoutController : Controller
    {
        public async Task<ActionResult> Navigation()
        {
            await Task.CompletedTask;
            return PartialView("_NavigationBar", GetNavigationItems());
        }

        public async Task<ActionResult> Footer()
        {
            await Task.CompletedTask;
            return PartialView("_Footer");
        }

        private IEnumerable<NavigationItem> GetNavigationItems()
        {
            var items = new List<NavigationItem>
            {
                new NavigationItem { Text = "Home", Url = Url.Content("~/") },
                new NavigationItem { Text = "About", Url = Url.Content("~/About.aspx") },
                new NavigationItem { Text = "Contact", Url = Url.Action("Index", "Contacts") }
            };

            var selectedItem = items.Find(t => t.Url == Request.Path);
            if (selectedItem is null)
            {
                selectedItem = items[0];
            }

            selectedItem.Selected = true;
            return items;
        }
    }
}

