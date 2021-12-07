using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WinterShop.Models
{
    public class Checkout
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string CompanyName { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        [MaxLength(100)]
        public string AddressLine2 { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string District { get; set; }
        public byte Zip { get; set; }
        [Column(TypeName = "ntext")]
        public string OrderNotes { get; set; }
        [MaxLength(250)]
        public bool CreateAccount { get; set; }
        public bool DifferentAddress { get; set; }
    }
}
