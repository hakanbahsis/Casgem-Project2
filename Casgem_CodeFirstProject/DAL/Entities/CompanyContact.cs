using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class CompanyContact
    {
        public int Id { get; set; }
        [DisplayName("Adres")]
        public string Address { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Mail")]
        public string Mail { get; set; }

        [DisplayName("Harita Bilgisi")]
        public string MapInfo { get; set; }

    }
}