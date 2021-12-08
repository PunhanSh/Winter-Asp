using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WinterShop.DataDbContext;
using WinterShop.Models;
using WinterShop.ViewModel;

namespace WinterShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDb _datadb;
        public HomeController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            VmHome vmHome = new VmHome()
            {
                Setting = _datadb.Settings.FirstOrDefault(),
                HomeBanner = _datadb.HomeBanners.FirstOrDefault(),
                PageFrees = _datadb.PageFrees.ToList(),
                InstagramFilters = _datadb.InstagramFilters.ToList()
            };

            return View(vmHome);
        }
    }
}
