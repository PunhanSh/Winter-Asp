using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WinterShop.Models;
using System;
using WinterShop.DataDbContext;

namespace WinterShop.ViewComponents
{
    public class VcPageFree : ViewComponent
    {
        private readonly DataDb _context;

        public VcPageFree(DataDb context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<PageFree> model = _context.PageFrees.ToList();
            return View(model);
        }
    }
}
