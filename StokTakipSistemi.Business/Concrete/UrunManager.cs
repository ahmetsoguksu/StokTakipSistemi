using System;
using System.Collections.Generic;
using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Utilities;
using StokTakipSistemi.Business.ValidationRules.FluentValidation;
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

        public void Add(tbl_urun tbl_urun)
        {
            ValidationTool.Valdiate(new UrunValidator(), tbl_urun);
            _urunDal.Add(tbl_urun);
        }

        public void Delete(tbl_urun tbl_urun)
        {
            try
            {
                _urunDal.Delete(tbl_urun);
            }
            catch
            {

                throw new Exception("Üzgünüm, silme işlemi başarısız oldu") ;
            }
        }

        public List<tbl_urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        public List<tbl_urun> GetProductsByCategory(int Kategori_id)
        {
            return _urunDal.GetAll(p => p.kategori_id == Kategori_id);
        }

        public List<tbl_urun> GetProductsByProductName(string Urun_ad)
        {
            return _urunDal.GetAll(p => p.urun_ad.ToLower().Contains(Urun_ad.ToLower()));
        }

        public void Update(tbl_urun tbl_urun)
        {
            ValidationTool.Valdiate(new UrunValidator(), tbl_urun);

            _urunDal.Update(tbl_urun);
        }
    }
}
