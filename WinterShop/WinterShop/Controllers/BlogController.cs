using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinterShop.DataDbContext;

namespace WinterShop.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataDb _datadb;
        public BlogController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
