using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        [DisplayName("Gönderen Adı")]
        public string Name { get; set; }
        [DisplayName("Mail")]
        public string Mail { get; set; }
        [DisplayName("Konu")]
        public string Subject { get; set; }
        [DisplayName("Mesaj")]
        public string Content { get; set; }
        [DisplayName("Okundu mu?")]
        public bool Status { get; set; }
    }
}