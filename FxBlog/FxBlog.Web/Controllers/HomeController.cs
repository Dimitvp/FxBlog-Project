using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FxBlog.Services.Blog;
using Microsoft.AspNetCore.Mvc;
using FxBlog.Web.Models;
using FxBlog.Web.Models.Home;

namespace FxBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogArticleService articles;

        public HomeController(
            IBlogArticleService articles)
        {
            this.articles = articles;
        }

        public async Task<IActionResult> Index()
            => View(new HomeIndexViewModel
            {
                Articles = await this.articles.AllAsync()
            });

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
