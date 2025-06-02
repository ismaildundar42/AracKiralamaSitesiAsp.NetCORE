using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class AracController : Controller
    {
        private readonly IAracRepository _repository;
        private readonly string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

        public AracController(IAracRepository repository)
        {
            _repository = repository;

            // uploads klasörü yoksa oluştur
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }
        }

        public IActionResult Index()
        {
            return View(_repository.AracListesi.ToList());
        }

        [HttpGet]
        public IActionResult AracEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AracEkle(Arac arac, IFormFile fotoDosyasi)
        {
            if (fotoDosyasi != null && fotoDosyasi.Length > 0)
            {
                var dosyaAdi = UniqueFileName(fotoDosyasi.FileName);
                var kayitYolu = Path.Combine(uploadsFolder, dosyaAdi);

                using (var stream = new FileStream(kayitYolu, FileMode.Create))
                {
                    fotoDosyasi.CopyTo(stream);
                }

                arac.AracFoto = "/uploads/" + dosyaAdi;
            }

            _repository.aracEkle(arac);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AracGuncelle(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult AracGuncelle(Arac arac, IFormFile yeniFoto)
        {
            var mevcut = _repository.GetById(arac.AracId);
            if (mevcut == null) return NotFound();

            mevcut.AracMarka = arac.AracMarka;
            mevcut.AracModel = arac.AracModel;
            mevcut.AracPlaka = arac.AracPlaka;
            mevcut.AracYakit = arac.AracYakit;
            mevcut.AracGunlukFiyat = arac.AracGunlukFiyat;
            mevcut.AracDurum = arac.AracDurum;

            if (yeniFoto != null && yeniFoto.Length > 0)
            {
                // Eski fotoğrafı sil
                if (!string.IsNullOrEmpty(mevcut.AracFoto))
                {
                    var eskiYol = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", mevcut.AracFoto.TrimStart('/'));
                    if (System.IO.File.Exists(eskiYol))
                    {
                        System.IO.File.Delete(eskiYol);
                    }
                }

                // Yeni fotoğrafı yükle
                var dosyaAdi = UniqueFileName(yeniFoto.FileName);
                var kayitYolu = Path.Combine(uploadsFolder, dosyaAdi);

                using (var stream = new FileStream(kayitYolu, FileMode.Create))
                {
                    yeniFoto.CopyTo(stream);
                }

                mevcut.AracFoto = "/uploads/" + dosyaAdi;
            }

            _repository.aracGuncelle(mevcut);
            return RedirectToAction("Index");
        }

        public IActionResult AracSil(int id)
        {
            var arac = _repository.GetById(id);
            if (arac != null)
            {
                // Fotoğraf varsa sil
                if (!string.IsNullOrEmpty(arac.AracFoto))
                {
                    var fotoYolu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", arac.AracFoto.TrimStart('/'));
                    if (System.IO.File.Exists(fotoYolu))
                    {
                        System.IO.File.Delete(fotoYolu);
                    }
                }

                _repository.aracSil(id);
            }

            return RedirectToAction("Index");
        }

        // 🔧 Yardımcı metod: benzersiz dosya adı üretir
        private string UniqueFileName(string orijinalAd)
        {
            var ad = Path.GetFileNameWithoutExtension(orijinalAd);
            var uzanti = Path.GetExtension(orijinalAd);
            var random = Path.GetRandomFileName().Substring(0, 5);
            return $"{ad}_{random}{uzanti}";
        }
    }
}
