using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Models
{
    public class AddProductModel
    {
        
        [Required(ErrorMessage ="Boş geçilemez")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string ProductImageCover { get; set; }

        public string ProductImage { get; set; }

        public string ProductImage2 { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public int ProductPrice { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public int ProductStock { get; set; }
       
        [Required(ErrorMessage = "Boş geçilemez")]
        public int CategoryID { get; set; }

    }
}
