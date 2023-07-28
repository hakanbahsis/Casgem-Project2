using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        [DisplayName("Sosyal Medya")]
        public string Name { get; set; }
        [DisplayName("Link")]
        public string Url { get; set; }
        [DisplayName("Icon")]
        public string Icon { get; set; }
        [DisplayName("Sahibi")]
        public int? GuideId { get; set; }
        public virtual Guide Guide { get; set; }

        [DisplayName("Takım Üyesi")]
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}