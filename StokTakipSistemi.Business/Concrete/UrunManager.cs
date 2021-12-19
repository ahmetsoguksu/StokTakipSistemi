using StokTakipSistemi.DataAccess.Concrete;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Concrete
{
    public class UrunManager
    {
        tbl_urunDal _urunDal = new tbl_urunDal();
        public List<tbl_urun> GetAll()
        {
            return _urunDal.GetAll();
        }
    }
}
