using StokTakipSistemi.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Concrete
{
    class KullaniciManager
    {
        tbl_kullaniciDal _kullaniciDal = new tbl_kullaniciDal();
        public bool Login (string ad, string parola)
        {
            return _kullaniciDal.Login(ad,parola);
        }
    }
}
