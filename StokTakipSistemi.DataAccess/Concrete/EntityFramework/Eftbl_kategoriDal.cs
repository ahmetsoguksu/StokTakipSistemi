using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete.EntityFramework
{
    public class Eftbl_kategoriDal : EfEntityRepositoryBase<tbl_kategori, StokTakipSistemiContext>, Itbl_kategoriDal
    {

    }
}
