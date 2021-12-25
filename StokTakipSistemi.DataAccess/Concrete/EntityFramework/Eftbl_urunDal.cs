using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete.EntityFramework
{
    public class Eftbl_urunDal:EfEntityRepositoryBase<tbl_urun,StokTakipSistemiContext>,Itbl_urunDal
    {
    }
}
