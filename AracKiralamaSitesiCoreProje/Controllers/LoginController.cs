using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string kullaniciAdi, string sifre)
        {
            // Linq sorgusuyla kontrol işlemi yapılıyor 
            // 1. Admin kontrol
            var admin = _context.admins.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);
            if (admin != null)
            {
                TempData["Rol"] = "admin";
                return RedirectToAction("Index", "Arac");
            }

            TempData.Keep("MusteriId"); // ❗ TempData verisi silinmesin diye 

            // 2. Müşteri kontrol
            var musteri = _context.musteris.FirstOrDefault(m => m.MusteriTc == kullaniciAdi && m.MusteriSifre == sifre);
            if (musteri != null)
            {
                TempData["Rol"] = "musteri";
                TempData["MusteriId"] = musteri.MusteriId;
                return RedirectToAction("Index", "MusteriPanel");
            }

            ViewBag.Hata = "Geçersiz kullanıcı adı veya şifre!";
            return View();
        }
    }
}
