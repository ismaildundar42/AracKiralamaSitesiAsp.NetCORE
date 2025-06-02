using System;
using System.ComponentModel.DataAnnotations;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class Kiralama
    {
        [Key]
        public int KiraID { get; set; }

        public DateTime KiraBaslangic { get; set; }
        public DateTime KiraBitis { get; set; }

        // FK - Musteri
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        // FK - Arac
        public int AracId { get; set; }
        public Arac Arac { get; set; }


    }
}
