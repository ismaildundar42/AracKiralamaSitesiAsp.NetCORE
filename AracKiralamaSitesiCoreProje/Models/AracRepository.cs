using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class AracRepository : IAracRepository
    {

        private ApplicationDbContext _context;

        public AracRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<Arac> AracListesi
        {
            get { return _context.aracs.ToList(); }
        }

        public void aracEkle(Arac arac)
        {
            _context.aracs.Add(arac);
            _context.SaveChanges();
        }

        public void aracGuncelle(Arac arac)
        {
            _context.aracs.Update(arac);
            _context.SaveChanges();
        }

        public void aracSil(int id)
        {
            var silinecekArac = GetById(id);
            if (silinecekArac != null)
            {
                _context.Remove(silinecekArac);
                _context.SaveChanges();
            }
        }

        public Arac GetById(int id)
        {
            return _context.aracs.FirstOrDefault(x => x.AracId == id);
        }
    }
}
