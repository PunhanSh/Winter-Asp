using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        [MaxLength(200)]
        public string Subject { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
