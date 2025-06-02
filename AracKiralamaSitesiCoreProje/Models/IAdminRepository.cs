namespace AracKiralamaSitesiCoreProje.Models
{
    public interface IAdminRepository
    {
        bool AdminKontrol(string kullaniciAdi, string sifre);
        void AdminEkle(Admin admin);
    }
}
