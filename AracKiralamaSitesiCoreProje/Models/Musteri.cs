using System.Collections.Generic;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriTc { get; set; }
        public string MusteriSifre { get; set; }

        // Navigation: Bu müşteri kaç araç kiraladı
        public ICollection<Kiralama> Kiralamalar { get; set; }
    }
}
  