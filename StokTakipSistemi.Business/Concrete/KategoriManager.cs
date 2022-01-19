using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Utilities;
using StokTakipSistemi.Business.ValidationRules.FluentValidation;
using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private Itbl_kategoriDal _KategoriDal;
        public KategoriManager(Itbl_kategoriDal kategoriDal)
        {
            _KategoriDal = kategoriDal;
        }

        public void Add(tbl_kategori tbl_kategori)
        {
            ValidationTool.Valdiate(new KategoriValidator(), tbl_kategori);
            _KategoriDal.Add(tbl_kategori);
        }

        public List<tbl_kategori> GetAll()
        {
            return _KategoriDal.GetAll();
        }

        public List<tbl_kategori> GetCategoriesByCategoryName(string Kategori_ad)
        {
            return _KategoriDal.GetAll(p => p.kategori_ad.ToLower().Contains(Kategori_ad.ToLower()));
        }

        public void Update(tbl_kategori tbl_Kategori)
        {
            ValidationTool.Valdiate(new KategoriValidator(), tbl_Kategori);

            _KategoriDal.Update(tbl_Kategori);
        }
    }
    }

