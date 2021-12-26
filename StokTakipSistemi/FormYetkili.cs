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
            _kategoriService = new KategoriManager(new Eftbl_kategoriDal());
        }
        public IUrunService _urunService;
        public IKategoriService _kategoriService;
        private void FormYetkili_Load(object sender, EventArgs e)
        {
            LoadProductsYetkili();
            LoadCategoriesYetkili();
        }

        private void LoadCategoriesYetkili()
        {
            cboxKategori.DataSource = _kategoriService.GetAll();
            cboxKategori.DisplayMember = "kategori_ad";
            cboxKategori.ValueMember = "kategori_id";

            cboxKategoriAlim.DataSource = _kategoriService.GetAll();
            cboxKategoriAlim.DisplayMember = "kategori_ad";
            cboxKategoriAlim.ValueMember = "kategori_id";

            cboxKategoriStok.DataSource = _kategoriService.GetAll();
            cboxKategoriStok.DisplayMember = "kategori_ad";
            cboxKategoriStok.ValueMember = "kategori_id";

            cboxEditUrunKategori.DataSource = _kategoriService.GetAll();
            cboxEditUrunKategori.DisplayMember = "kategori_ad";
            cboxEditUrunKategori.ValueMember = "kategori_id";
        }

        private void LoadProductsYetkili()
        {
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwAlimUrunListesi.DataSource = _urunService.GetAll();
            dgwStokUrunListesi.DataSource = _urunService.GetAll();
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwEditUrunListesi.DataSource = _urunService.GetAll();
        }

        private void cboxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwSatisUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategori.SelectedValue));
            }
            catch
            {
            }        
        }

        private void cboxKategoriAlim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwAlimUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategoriAlim.SelectedValue));
            }
            catch
            {
            }
        }

        private void cboxKategoriStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwStokUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategoriStok.SelectedValue));
            }
            catch
            {
            }
        }

        private void cboxEditUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwEditUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxEditUrunKategori.SelectedValue));
            }
            catch
            {
            }
        }
    }
}


