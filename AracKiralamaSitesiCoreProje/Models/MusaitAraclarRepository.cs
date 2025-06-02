using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class MusaitAraclarRepository : IMusaitAraclarRepository
    {

        private ApplicationDbContext _context;

        public MusaitAraclarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Arac> AracListesi
        {
            get { return _context.aracs.ToList(); }
        }
    }
}
