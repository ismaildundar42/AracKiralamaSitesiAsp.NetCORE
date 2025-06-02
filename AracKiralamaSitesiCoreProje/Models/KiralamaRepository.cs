using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class KiralamaRepository : IKiralamaRepository
    {

        private ApplicationDbContext _context;

        public KiralamaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Kiralama> KiraListesi
        {
            get { return _context.kiralamas.ToList(); }
        }

        public Kiralama GetById(int id)
        {
            return _context.kiralamas.FirstOrDefault(x => x.KiraID == id);
        }

        public void KiraEkle(Kiralama kira)
        {
            _context.kiralamas.Add(kira);

            var arac = _context.aracs.FirstOrDefault(a => a.AracId == kira.AracId);
            if (arac != null)
            {
                arac.AracDurum = false;
                _context.aracs.Update(arac);
            }

            _context.SaveChanges();
        }

        public void KiraIptal(int id)
        {
            throw new System.NotImplementedException();
        }

        public void KiralamaIptalEt(int kiraId)
        {
            var kira = _context.kiralamas.FirstOrDefault(k => k.KiraID == kiraId);
            if (kira != null)
            {
                // Aracın durumunu true yap
                var arac = _context.aracs.FirstOrDefault(a => a.AracId == kira.AracId);
                if (arac != null)
                {
                    arac.AracDurum = true;
                    _context.aracs.Update(arac);
                }

                // Kiralamayı sil
                _context.kiralamas.Remove(kira);
                _context.SaveChanges();
            }
        }

    }
}
