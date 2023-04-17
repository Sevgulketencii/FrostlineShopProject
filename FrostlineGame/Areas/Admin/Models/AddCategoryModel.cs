using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Models
{
    public class AddCategoryModel
    {
        [Required(ErrorMessage ="Boş geçilemez")]
        public string CategoryName { get; set; }

    }
}
