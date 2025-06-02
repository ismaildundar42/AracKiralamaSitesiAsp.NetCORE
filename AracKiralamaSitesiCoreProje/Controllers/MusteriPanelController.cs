using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class MusteriPanelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusteriPanelController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (TempData["MusteriId"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

            int musteriId = (int)TempData["MusteriId"];


            // sql sorgusu yerine LİNQ Sorgusu kullanılır
            var kiralama = _context.kiralamas
                                   .Include(k => k.Arac) // 👈 Arac bilgilerini de dahil et
                                   .FirstOrDefault(k => k.MusteriId == musteriId);

            if (kiralama == null)
            {
                ViewBag.Mesaj = "Henüz bir kiralama işleminiz yok.";
                return View();
            }

            return View(kiralama);
        }
    }
}
