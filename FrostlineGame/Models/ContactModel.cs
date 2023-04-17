using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="Adınız Boş Geçilemez")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Mail Boş Geçilemez")]
        public string ContactMail { get; set; }

        public string ContactDescription { get; set; }
    }
}
