using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class ContactSocialMedia
    {
        public int Id { get; set; }
        [DisplayName("Sosyal Medya")]
        public string Name { get; set; }
        [DisplayName("Url")]
        public string Url { get; set; }
        [DisplayName("İkon")]
        public string Icon { get; set; }
        [DisplayName("Aktif Mi?")]
        public bool Status { get; set; }

    }
}