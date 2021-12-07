using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinterShop.Models;

namespace WinterShop.DataDbContext
{
    public class DataDb : DbContext
    {
        public DataDb(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogAuthor> BlogAuthors { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogSocial> BlogSocials { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<HomeBanner> HomeBanners { get; set; }
        public DbSet<InstagramFilter> InstagramFilters { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PageFree> PageFrees { get; set; }
        public DbSet<PageSocial> PageSocials { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<Track> Tracks{ get; set; }
    }
}
