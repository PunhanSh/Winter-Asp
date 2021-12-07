using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class ContactAddress
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string WorkHours { get; set; }
        [MaxLength(100)]
        public string SupportMail{ get; set; }
        [MaxLength(200)]
        public string AddressLink { get; set; }
    }
}
