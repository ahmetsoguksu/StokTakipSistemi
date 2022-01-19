using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Concrete;
using StokTakipSistemi.Business.DependencyResolvers.Ninject;
using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using StokTakipSistemi.Entities.Concrete;
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
        //1- ürün servis ve kategori servis erişim için:
        public FormYetkili()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
        }
        public IUrunService _urunService;
        public IKategoriService _kategoriService;
        //-1\\

        //2- form açıldığında combox'lara kategorilerin, datagridview'lere ürünlerin gelmesi için
        //      yazılan fonksiyonların çağrılması
        private void FormYetkili_Load(object sender, EventArgs e)
        {
            LoadProductsYetkili();
            LoadCategoriesYetkili();
        }
        //--2\\

        //3- form açıldığında combox'lara kategorilerin gelmesi için kullanılacak fonksiyon
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

            dgwEditKategoriListesi.DataSource = _kategoriService.GetAll();
        }
        //--3\\

        //4- form açıldığında data grid view'lere ürünlerin gelmesi için kullanılacak fonksiyon
        public void LoadProductsYetkili()
        {
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwAlimUrunListesi.DataSource = _urunService.GetAll();
            dgwStokUrunListesi.DataSource = _urunService.GetAll();
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwEditUrunListesi.DataSource = _urunService.GetAll();
        }
        //--4\\

        //5- tüm sekmelerde kategori seçildiğinde ürünlerin filtrelenmesi ile ilgili event'ler
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
            //try
            //{
            //    dgwEditUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxEditUrunKategori.SelectedValue));
            //}
            //catch
            //{
            //}
        }
        //--5\\

        //6- tüm sekmelerde ilgili textbox'larda ürün adı ile arama yapma
        private void tboxUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdi.Text))
            {
                dgwSatisUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdi.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }
        private void tboxUrunAdiAlim_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdiAlim.Text))
            {
                dgwAlimUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdiAlim.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }
        private void tboxUrunAdiArama_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdiArama.Text))
            {
                dgwStokUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdiArama.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }
        private void tboxEditUrunSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxEditUrunSearch.Text))
            {
                dgwEditUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxEditUrunSearch.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }
        //--6\\

        //7- stok sekmesinde ürün ekle butonuna basıldığında ürün ekleme formunun açılması
        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkleChild formUrunEkleChild = new FormUrunEkleChild();
            formUrunEkleChild.Owner = this;
            formUrunEkleChild.Show();
        }
        //--7\\

        //8- ürün düzenle sekmesinde ürün ekleme butonuna basıldığında yeni ürün eklenmesi
        private void btnEditUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Add(new tbl_urun
                {
                    kategori_id = Convert.ToInt32(cboxEditUrunKategori.SelectedValue),
                    urun_ad = tBoxEditUrunAdi.Text,
                    urun_son_satis_fiyati = Convert.ToDecimal(tboxEditUrunFiyat.Text),
                    urun_birim = tboxEditUrunBirim.Text,
                    urun_stok_miktari = Convert.ToInt32(tboxEditUrunStok.Text),
                    urun_kdv_orani = Convert.ToDecimal(tboxEditUrunKdvOrani.Text)
                });
                MessageBox.Show("Ürün Kaydedildi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //--8\\

        //9- ürün/kategori düzenle sekmesinde ürün ile ilgili işlem yapıldıktan sonra
        //      ilgili textbox'ların temizlenmesi için kullanılan fonksiyon
        private void TboxClear()
        {
            tBoxEditUrunAdi.Text = "";
            tboxEditUrunFiyat.Text = "";
            tboxEditUrunBirim.Text = "";
            tboxEditUrunStok.Text = "";
            tboxEditUrunKdvOrani.Text = "";
            tboxEditKategori.Text = "";
            tboxEditKategoriId.Text = "";
            tboxEditKategoriSearch.Text = "";
        }
        //--9\\

        //10- ürün güncelle butonuna basıldığında veriabanında ürün bilgilerinin güncellenmesi
        private void btnEditUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Update(new tbl_urun
                {
                    urun_id = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[0].Value),
                    urun_ad = tBoxEditUrunAdi.Text,
                    kategori_id = Convert.ToInt32(cboxEditUrunKategori.SelectedValue),
                    urun_birim = tboxEditUrunBirim.Text,
                    urun_kdv_orani = Convert.ToDecimal(tboxEditUrunKdvOrani.Text),
                    urun_son_satis_fiyati = Convert.ToDecimal(tboxEditUrunFiyat.Text),
                    urun_son_alis_fiyati = Convert.ToDecimal(dgwEditUrunListesi.CurrentRow.Cells[6].Value),
                    urun_stok_miktari = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[4].Value)

                });
                MessageBox.Show("Ürün Bilgileri Güncellendi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //--10\\

        //11- ürün sil butonuna basıldığında data grid view'de seçili olan ürünün veri tabanından silinmesi
        private void btnEditUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Delete(new tbl_urun
                {
                    urun_id = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün (" + tBoxEditUrunAdi.Text + ") Silindi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
        //--11\\

        //12- data grid view'de bir hücreye tıklandığında o ürün ile ilgili bilgilerin ilgili yerlere gelmesi
        private void dgwEditUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxEditUrunId.Text = dgwEditUrunListesi.CurrentRow.Cells[0].Value.ToString();
            tBoxEditUrunAdi.Text = dgwEditUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cboxEditUrunKategori.SelectedValue = dgwEditUrunListesi.CurrentRow.Cells[2].Value;
            tboxEditUrunBirim.Text = dgwEditUrunListesi.CurrentRow.Cells[3].Value.ToString();
            tboxEditUrunStok.Text = dgwEditUrunListesi.CurrentRow.Cells[4].Value.ToString();
            tboxEditUrunKdvOrani.Text = dgwEditUrunListesi.CurrentRow.Cells[5].Value.ToString();
            tboxEditUrunFiyat.Text = dgwEditUrunListesi.CurrentRow.Cells[7].Value.ToString();
        }
        private void dgwSatisUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sol kısım
            lblUrunAdi.Text = dgwSatisUrunListesi.CurrentRow.Cells[1].Value.ToString();
            lblKategori.Text = dgwSatisUrunListesi.CurrentRow.Cells[2].Value.ToString();
            lblStokAdeti.Text = dgwSatisUrunListesi.CurrentRow.Cells[4].Value.ToString();
            lblAlisFiyati.Text = dgwSatisUrunListesi.CurrentRow.Cells[6].Value.ToString();
            lblSatisFiyati.Text = dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString();
            lblUrunId.Text = dgwSatisUrunListesi.CurrentRow.Cells[0].Value.ToString();
            //sağ kısım
            tboxUrunId.Text = dgwSatisUrunListesi.CurrentRow.Cells[0].Value.ToString();
            tboxUrunAdi.Text = dgwSatisUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cboxKategori.Text = dgwSatisUrunListesi.CurrentRow.Cells[2].Value.ToString();
            tboxBirimFiyat.Text = dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString();
            tboxAdet.Text = 1.ToString();
            tboxToplamFiyat.Text = ((Convert.ToInt32(dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString()))*(Convert.ToInt32(tboxAdet.Text))).ToString();
        }

        private void dgwAlimUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sol kısım
            lblUrunAdiAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[1].Value.ToString();
            lblKategoriAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[2].Value.ToString();
            lblStokAdetiAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[4].Value.ToString();
            lblAlisFiyatiAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[6].Value.ToString();
            lblSatisFiyatiAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[7].Value.ToString();
            lblUrunIdAlim.Text = dgwAlimUrunListesi.CurrentRow.Cells[0].Value.ToString();
            //sağ kısım
            textBox1.Text = dgwSatisUrunListesi.CurrentRow.Cells[0].Value.ToString();
            tboxUrunAdiAlim.Text = dgwSatisUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cboxKategoriAlim.Text = dgwSatisUrunListesi.CurrentRow.Cells[2].Value.ToString();
            tboxBirimFiyatAlim.Text = dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString();
            tboxAdetAlim.Text = 1.ToString();
            tboxToplamFiyatAlim.Text = ((Convert.ToInt32(dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString())) * (Convert.ToInt32(tboxAdet.Text))).ToString();
        }

        private void dgwStokUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxSatisFiyati.Text = dgwStokUrunListesi.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgwEditKategoriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxEditKategori.Text = dgwEditKategoriListesi.CurrentRow.Cells[1].Value.ToString();
            tboxEditKategoriId.Text = dgwEditKategoriListesi.CurrentRow.Cells[0].Value.ToString();
        }
        //--12\\

        //13- Toplam fiyatı hesaplayıp göstermek için gerekli kodlar
        //Satış için
        private void tboxAdet_TextChanged(object sender, EventArgs e)
        {
            tboxToplamFiyat.Text = ((Convert.ToInt32(dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString())) * (Convert.ToInt32(tboxAdet.Text))).ToString();
        }
        //Alım için
        private void tboxAdetAlim_TextChanged(object sender, EventArgs e)
        {
            tboxToplamFiyatAlim.Text = ((Convert.ToInt32(dgwSatisUrunListesi.CurrentRow.Cells[7].Value.ToString())) * (Convert.ToInt32(tboxAdet.Text))).ToString();
        }
        //--13\\

        //14- Kategori düzenlemede kategori adı ile arama yapma
        private void tboxEditKategoriSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxEditKategoriSearch.Text))
            {
                dgwEditKategoriListesi.DataSource = _kategoriService.GetCategoriesByCategoryName(tboxEditKategoriSearch.Text);
            }
            else
            {
                LoadCategoriesYetkili();
            }
        }
        //--14\\

        //15- kategori düzenle sekmesinde kategori güncelle butonuna basıldığında ilgili kategorinin düzenlenmesi
        private void btnEditKategoriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _kategoriService.Update(new tbl_kategori
                {
                    kategori_id = Convert.ToInt32(tboxEditKategoriId.Text),
                    kategori_ad = tBoxEditUrunAdi.Text
                }) ;
                MessageBox.Show("Kategori Bilgileri Güncellendi!");
                TboxClear();
                LoadCategoriesYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //--15\\

        //16-  Kategori sekmesinde yeni ekle butonuna basıldığında veri tabanına ilgili kategorinin eklenmesi
        private void btnEditKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _kategoriService.Add(new tbl_kategori
                {
                    kategori_id = Convert.ToInt32(tboxEditKategoriId.Text),
                    kategori_ad = tboxEditKategori.Text
                });
                MessageBox.Show("Kategori Kaydedildi!");
                TboxClear();
                LoadCategoriesYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //--16\\
    }
}


