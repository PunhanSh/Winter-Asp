﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class PageFree
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
    }
}
