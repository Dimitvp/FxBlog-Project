using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FxBlog.Data.Models;
using FxBlog.Services;
using FxBlog.Services.Blog;
using Microsoft.AspNetCore.Mvc;
using FxBlog.Web.Models;
using FxBlog.Web.Models.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using static FxBlog.Web.WebConstants;

namespace FxBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogArticleService articles;
        private readonly IForexServices currences;
        private readonly UserManager<User> _userManager;

        public HomeController(
            UserManager<User> userManager,
            IBlogArticleService articles, IForexServices currences)
        {
            _userManager = userManager;
            this.articles = articles;
            this.currences = currences;
        }

        //[HttpGet(ForexUrl)]
        public async Task<IActionResult> Index()
            => View(new HomeIndexViewModel
            {
                Articles = await this.articles.AllAsync(),
                ForexCurrencys = await this.currences.GetAsync()
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

        //[HttpGet(ForexUrl)]
        //[AllowAnonymous]
        //public IActionResult ForexCurrency()
        //{
        //    return 
        //}

    }
}
