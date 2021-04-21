using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTest.Models
{
    public class DisplayBrugerModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Navnet er for langt")]
        [MinLength(5, ErrorMessage = "Navnet er for kort")]
        public string bruger_navn { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public decimal konto { get; set; }
        [Required]
        public int vaskeri_id { get; set; }
        [Required]
        public DateTime oprettet { get; set; }
    }
}

