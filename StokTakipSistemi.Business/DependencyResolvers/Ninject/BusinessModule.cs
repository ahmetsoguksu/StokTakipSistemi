using Ninject.Modules;
using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Concrete;
using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.DependencyResolvers.Ninject
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUrunService>().To<UrunManager>().InSingletonScope();
            Bind<Itbl_urunDal>().To<Eftbl_urunDal>().InSingletonScope();

            Bind<IKategoriService>().To<KategoriManager>().InSingletonScope();
            Bind<Itbl_kategoriDal>().To<Eftbl_kategoriDal>().InSingletonScope();
        }
    }
}
