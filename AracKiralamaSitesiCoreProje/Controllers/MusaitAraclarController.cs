using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AracKiralamaSitesiCoreProje.Controllers
{
    public class MusaitAraclarController : Controller
    {
        private IMusaitAraclarRepository _repository;
        public MusaitAraclarController(IMusaitAraclarRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var musaitAraclar = _repository.AracListesi
                                           .Where(x => x.AracDurum == true)
                                           .ToList();

            return View(musaitAraclar);
        }

    }
}
