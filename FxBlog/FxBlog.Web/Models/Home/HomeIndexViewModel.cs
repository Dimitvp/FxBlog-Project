namespace FxBlog.Web.Models.Home
{
    using Services.Models;
    using Services.Blog.Models;
    using System.Collections.Generic;
    using ManageModels;

    public class HomeIndexViewModel
    {
        public IEnumerable<BlogArticleListingServiceModel> Articles { get; set; }

        public IEnumerable<ForexCurrencyServiceModel> ForexCurrencys { get; set; }

        public IndexViewModel UserModel { get; set; }
    }
}
