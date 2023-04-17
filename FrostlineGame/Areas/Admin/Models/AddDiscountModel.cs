using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Models
{
    public class AddDiscountModel
    {
        [Required(ErrorMessage ="Boş geçilemez")]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public int Rate { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public DateTime Start { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public DateTime End { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public int CategoryDiscount { get; set; }
    }
}
