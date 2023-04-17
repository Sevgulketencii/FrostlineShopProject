using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        public string DiscountName { get; set; }
        public string DiscountImg { get; set; }
        public int DiscountRate { get; set; }
        public bool DiscountStatus { get; set; }
        public DateTime StartDiscount { get; set; }
        public DateTime EndDiscount { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
