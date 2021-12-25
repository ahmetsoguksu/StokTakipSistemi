using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete
{
    public class tbl_kullaniciDal
    {


        public List<tbl_kullanici> GetAllKullanici()
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //tüm kullanıcıları listele
                return context.Kullanicilar.ToList();
            }
        }
        public tbl_kullanici GetKullanici (int id)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //id'si alınan kullanıcıyı getir
                return context.Kullanicilar.SingleOrDefault(p => p.kullanici_id == id);
            }
        }
        public bool Login(string ad, string parola)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //giriş başarılı mı başarısız mı?
                //başarılıysa hangi ekran (personel/yetkili) açılacak?
                return true;
            }
        }
        public void Register(string ad, string soyad, bool seviye)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //kayıt yap veritabanına ve messagebox ile başarılı de
            }

        }
        public void Update(int id)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //id'si alınan kullanıcının bilgilerini düzenle

            }
        }
        public void Delete(int id)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                //id'si alınan kullanıcıyı veritabanından sil

            }
        }
    }
}
