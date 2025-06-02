using System.Collections.Generic;

namespace AracKiralamaSitesiCoreProje.Models
{
    public interface IMusteriRepository
    {
        List<Musteri> MusteriListesi { get; }
        Musteri GetById(int id);
        void musteriEkle(Musteri musteri);
        void musteriGuncelle(Musteri musteri);
        void musteriSil(int id);

        // 🔍 Yeni eklendi
        List<Musteri> AdaGoreAra(string ad);
    }
}
