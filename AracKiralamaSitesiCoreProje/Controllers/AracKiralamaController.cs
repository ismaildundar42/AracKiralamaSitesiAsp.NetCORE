using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class AracKiralamaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IKiralamaRepository _repository;

        public AracKiralamaController(IKiralamaRepository repository, ApplicationDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_repository.KiraListesi);
        }

        [HttpGet]
        public IActionResult KiraYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KiraYap(Kiralama kira)
        {
            var musteri = _context.musteris.FirstOrDefault(m => m.MusteriId == kira.MusteriId);
            var arac = _context.aracs.FirstOrDefault(a => a.AracId == kira.AracId);

            if (musteri == null || arac == null)
            {
                ViewBag.Hata = "Geçersiz müşteri ID veya araç ID!";
                return View();
            }

            if (!arac.AracDurum)
            {
                ViewBag.Hata = "Bu araç zaten kirada!";
                return View();
            }

            // Kira işlemi yapılabilir
            _repository.KiraEkle(kira);
            return RedirectToAction("Index");
        }

        public IActionResult KiralamaIptalEt(int id)
        {
            _repository.KiralamaIptalEt(id);
            return RedirectToAction("Index");
        }
    }
}
