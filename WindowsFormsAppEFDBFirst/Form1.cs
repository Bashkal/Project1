using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsAppEFDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblId_Click(object sender, EventArgs e)
        {
        }
        private void lblPrice_Click(object sender, EventArgs e)
        {
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblStock_Click(object sender, EventArgs e)
        {
        }
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        ProjeGelistirmeDBEntities projeGelistirmeDBEntities = new ProjeGelistirmeDBEntities();
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Products.Find(Id);
            lblId.Text = kayit.Id.ToString();
            txtUrunAdi.Text = kayit.Product_Name;
            txtStock.Text = kayit.Product_Stock.ToString();
            txtPrice.Text = kayit.Product_Price.ToString();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                projeGelistirmeDBEntities.Products.Add(new Products
                {
                    Product_Name = txtUrunAdi.Text,
                    Product_Price = Convert.ToDecimal(txtPrice.Text),
                    Product_Stock = Convert.ToInt32(txtStock.Text)
                });
                var sonuc = projeGelistirmeDBEntities.SaveChanges();
                Yukle();
                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün Eklendi");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception add_hata) { MessageBox.Show("Ürün Eklenemedi " + add_hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Products.Find(Id);
            kayit.Product_Name = txtUrunAdi.Text;
            kayit.Product_Price = Convert.ToDecimal(txtPrice.Text);
            kayit.Product_Stock = Convert.ToInt32(txtStock.Text);
            var sonuc = projeGelistirmeDBEntities.SaveChanges();
            Yukle();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Products.Find(Id);
            projeGelistirmeDBEntities.Products.Remove(kayit);
            var sonuc = projeGelistirmeDBEntities.SaveChanges();
            Yukle();
        }
        
        void Yukle()
        {
            dgvProducts.DataSource = projeGelistirmeDBEntities.Products.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = projeGelistirmeDBEntities.Products.Where(u => u.Product_Name.Contains(txtSearch.Text)).ToList();
        }
    }
}
