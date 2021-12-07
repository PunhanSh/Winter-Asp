using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }

    }
}
