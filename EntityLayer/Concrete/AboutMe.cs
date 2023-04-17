using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutMe
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutLocation { get; set; }
        public string AboutPhone { get; set; }
        public string WorkingStatus { get; set; }
        public string AboutMail { get; set; }
        public string LinkedinUrl { get; set; }
        public string GithupUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        
    }
}
