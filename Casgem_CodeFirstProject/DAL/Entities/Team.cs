using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fotoğraf")]
        public string ImageUrl { get; set; }
        [DisplayName("Durum")]
        public bool Status { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }

    }
}