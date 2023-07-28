using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Destination
    {
        public int DestinationId { get; set; }
        [DisplayName("Rota")]
        public string DestinationName { get; set; }
        [DisplayName("Süre")]
        public string DayNight { get; set; }
        [DisplayName("Kapasite")]
        public byte Capacity { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Fotoğraf")]
        public string ImageUrl { get; set; }
        [DisplayName("Durum")]
        public bool Status { get; set; }

    }
}