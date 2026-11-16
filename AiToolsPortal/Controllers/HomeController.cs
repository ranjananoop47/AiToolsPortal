using System;
using System.Linq;
using System.Web.Mvc;
using AiToolsPortal.Models;

namespace AiToolsPortal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index(string tab = "overview", string category = null, string search = null)
        {
            var allTools = AiToolsData.GetAllTools();
            var filtered = allTools.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(category) && !category.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                var q = search.Trim().ToLower();
                filtered = filtered.Where(t => 
                    t.Name.ToLower().Contains(q) ||
                    t.OneParagraphDescription.ToLower().Contains(q) ||
                    t.ShortTagline.ToLower().Contains(q) ||
                    t.Category.ToLower().Contains(q));
            }

            var model = new AiToolsViewModel
            {
                Tools = filtered.ToList(),
                Categories = AiToolsData.GetCategories(),
                ActiveTab = string.IsNullOrWhiteSpace(tab) ? "overview" : tab.ToLower(),
                SearchQuery = search,
                SelectedCategory = category
            };

            return View(model);
        }

        // GET: Home/Detail/notebooklm
        public ActionResult Detail(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return RedirectToAction("Index");
            }

            var tool = AiToolsData.GetToolById(id);
            if (tool == null)
            {
                return HttpNotFound("The requested AI Tool was not found.");
            }

            return View(tool);
        }

        // GET: Home/About
        public ActionResult About()
        {
            ViewBag.TotalTools = AiToolsData.GetAllTools().Count;
            return View();
        }
    }
}
