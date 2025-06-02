using System.Collections.Generic;

namespace AracKiralamaSitesiCoreProje.Models
{
    public interface IAracRepository
    {
        List<Arac> AracListesi { get; }
        Arac GetById(int id);
        void aracEkle(Arac arac);
        void aracGuncelle(Arac arac);
        void aracSil(int id);

    }
}
