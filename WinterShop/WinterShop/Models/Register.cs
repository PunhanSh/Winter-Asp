using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public byte Age { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
