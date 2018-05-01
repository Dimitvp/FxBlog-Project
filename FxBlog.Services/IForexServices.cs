using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FxBlog.Services.Models;

namespace FxBlog.Services
{
    public interface IForexServices
    {
        Task<IEnumerable<ForexCurrencyServiceModel>>GetAsync();
    }
}
