using AracKiralamaSitesiCoreProje.Models;
using System.Collections.Generic;

public class Arac
{
    public int AracId { get; set; }
    public string AracMarka { get; set; }
    public string AracModel { get; set; }
    public string AracPlaka { get; set; }
    public string AracYakit { get; set; }
    public int AracGunlukFiyat { get; set; }
    public bool AracDurum { get; set; } = true;

    public string AracFoto { get; set; }

    public ICollection<Kiralama> Kiralamalar { get; set; }
}
