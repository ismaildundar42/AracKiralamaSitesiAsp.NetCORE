using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class MusteriController : Controller
    {
        private IMusteriRepository _repository;

        public MusteriController(IMusteriRepository repository)
        {
            _repository = repository;
        }

        // 🔍 Arama destekli listeleme
        public IActionResult Index(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var filtreli = _repository.AdaGoreAra(search);
                return View(filtreli);
            }

            return View(_repository.MusteriListesi.ToList());
        }

        [HttpGet]
        public IActionResult MusteriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MusteriEkle(Musteri musteri)
        {
            _repository.musteriEkle(musteri);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MusteriGuncelle(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult MusteriGuncelle(Musteri musteri)
        {
            _repository.musteriGuncelle(musteri);
            return RedirectToAction("Index");
        }

        public IActionResult MusteriSil(int id)
        {
            _repository.musteriSil(id);
            return RedirectToAction("Index");
        }
    }
}
