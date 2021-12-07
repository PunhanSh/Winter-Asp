using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
