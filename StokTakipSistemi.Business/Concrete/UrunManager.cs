using System.Collections.Generic;
using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;

namespace StokTakipSistemi.Business.Concrete
{
    public class UrunManager:IUrunService
    {
        private Itbl_urunDal _urunDal;
        public UrunManager(Itbl_urunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public List<tbl_urun> GetAll()
        {
            return _urunDal.GetAll();
        }
    }
}
