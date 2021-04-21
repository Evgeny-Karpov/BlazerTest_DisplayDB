using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLib.Models
{
    public class BrugerModel
    {
        public string bruger_navn { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public decimal konto { get; set; }
        public int vaskeri_id { get; set; }
        public DateTime oprettet { get; set; }
    }
}
