using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinterShop.Models;

namespace WinterShop.ViewModel
{
    public class VmHome
    {
        public Setting Setting { get; set; }
        public List<PageFree> PageFrees { get; set; }
        public List<InstagramFilter> InstagramFilters { get; set; }
        public HomeBanner HomeBanner { get; set; }
    }
}
