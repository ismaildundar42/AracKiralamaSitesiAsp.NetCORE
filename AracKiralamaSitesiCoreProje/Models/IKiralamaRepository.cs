using System.Collections.Generic;

namespace AracKiralamaSitesiCoreProje.Models
{
    public interface IKiralamaRepository
    {
        List<Kiralama> KiraListesi { get; }
        void KiraEkle(Kiralama kira);

        void KiraIptal(int id);
        Kiralama GetById(int id);
        void KiralamaIptalEt(int kiraId);

    }
}
