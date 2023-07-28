using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Specification
    {
        public int SpecificationId { get; set; }
        [DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fotoğraf")]
        public string ImageUrl { get; set; }
        [DisplayName("Büyük Çerçeve")]
        public bool IsMain { get; set; }
    }
}