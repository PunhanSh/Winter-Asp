
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public string ContentFirst { get; set; }
        [MaxLength(2000)]
        public string BlogMessage { get; set; }
        public string ContentSecond { get; set; }
        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [ForeignKey("BlogAuthor")]
        public int BlogAuthorId { get; set; }
        public BlogAuthor BlogAuthor { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<BlogSocial> BlogSocials { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }

    }
}
