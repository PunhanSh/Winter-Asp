﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Controllers
{
    public class SingleProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}