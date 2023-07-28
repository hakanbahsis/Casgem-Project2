using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        [DisplayName("Müşteri Adı")]
        public string CustomerName { get; set; }
        [DisplayName("Rota")]
        public string Destination { get; set; }
        [DisplayName("Mail Adresi")]
        public string Mail { get; set; }
        [DisplayName("Süre")]
        public string Duratio { get; set; }
        [DisplayName("Rezervasyon Tarihi")]
        public DateTime BookingDate { get; set; }
        [DisplayName("Rezervasyon Durumu")]
        public string BookingStatus { get; set; }
    }
}