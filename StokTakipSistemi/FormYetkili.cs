using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Concrete;
using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormYetkili : Form
    {
        public FormYetkili()
        {
            InitializeComponent();
            _urunService = new UrunManager(new Eftbl_urunDal());

        }
        public IUrunService _urunService;
        private void FormYetkili_Load(object sender, EventArgs e)
        {
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
        }
    }
}


