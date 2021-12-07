using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(100)]
        public string CopyrightLink { get; set; }
    }
}
