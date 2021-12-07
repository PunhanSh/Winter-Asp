using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class HomeBanner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string UpTitle { get; set; }
        [MaxLength(300)]
        public string Title { get; set; }
    }
}
