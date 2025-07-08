using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL productDAL = new ProductDAL();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvUrunler.DataSource = productDAL.GetDataTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                productDAL.Add(new Product
                {
                    Name = txtUrunAdi.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                }
                );
                dgvUrunler.DataSource = productDAL.GetDataTable();
                MessageBox.Show("Yeni Ürün Eklendi");
            }
            catch(Exception hata) {
                MessageBox.Show("Ürün Eklenemedi "+ hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            productDAL.Update(new Product
            {
                Id = Convert.ToInt32(lblId.Text),
                Name = txtUrunAdi.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Stock = Convert.ToInt32(txtStock.Text),
            }
            );
            dgvUrunler.DataSource = productDAL.GetDataTable();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            lblId.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                productDAL.Delete(Convert.ToInt32(lblId.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString()));
                
                
                dgvUrunler.DataSource = productDAL.GetDataTable();
                MessageBox.Show("Ürün Silindi");

            }
        }
    }
}

