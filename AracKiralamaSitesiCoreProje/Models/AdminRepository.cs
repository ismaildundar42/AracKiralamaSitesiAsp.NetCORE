using System.Linq;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AdminKontrol(string kullaniciAdi, string sifre)
        {
            return _context.admins.Any(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);
        }

        public void AdminEkle(Admin admin)
        {
            _context.admins.Add(admin);
            _context.SaveChanges();
        }
    }
}
