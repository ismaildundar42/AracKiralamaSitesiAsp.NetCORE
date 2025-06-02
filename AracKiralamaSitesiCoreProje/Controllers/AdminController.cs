using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository _repository;

        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminEkle(Admin admin, string sifre1, string sifre2)
        {
            if (sifre1 != sifre2)
            {
                ViewBag.Hata = "Şifreler uyuşmuyor. Lütfen kontrol edin.";
                return View();
            }

            admin.Sifre = sifre1;
            _repository.AdminEkle(admin);
            TempData["Basari"] = "Yeni admin başarıyla oluşturuldu.";
            return RedirectToAction("Login", "Login");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
