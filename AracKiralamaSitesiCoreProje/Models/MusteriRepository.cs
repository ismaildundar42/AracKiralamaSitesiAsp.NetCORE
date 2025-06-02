using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class MusteriRepository : IMusteriRepository
    {
        private ApplicationDbContext _context;

        public MusteriRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Musteri> MusteriListesi
        {
            get { return _context.musteris.ToList(); }
        }

        public Musteri GetById(int id)
        {
            return _context.musteris.FirstOrDefault(x => x.MusteriId == id);
        }

        public void musteriEkle(Musteri musteri)
        {
            _context.musteris.Add(musteri);
            _context.SaveChanges();
        }

        public void musteriGuncelle(Musteri musteri)
        {
            _context.musteris.Update(musteri);
            _context.SaveChanges();
        }

        public void musteriSil(int id)
        {
            var silinecekMusteri = GetById(id);
            if (silinecekMusteri != null)
            {
                _context.Remove(silinecekMusteri);
                _context.SaveChanges();
            }
        }

        // 🔍 Yeni: Ada göre filtreleme
        public List<Musteri> AdaGoreAra(string ad)
        {
            return _context.musteris
                .Where(m => m.MusteriAdSoyad.Contains(ad))
                .ToList();
        }
    }
}
