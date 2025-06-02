using System.Collections.Generic;

namespace AracKiralamaSitesiCoreProje.Models
{
    public interface IMusaitAraclarRepository
    {
        List<Arac> AracListesi { get; }
    }
}
