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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CategoryDAL categoryDAL = new CategoryDAL();
        private void Form2_Load(object sender, EventArgs e)
        {
            dgvCatagories.DataSource=categoryDAL.GetDataTable();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void dgvCatagories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCatName_Click(object sender, EventArgs e)
        {

        }

        private void txtCatagory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                categoryDAL.Add(new Category
                {
                    CategoryName = txtCatagory.Text,
                }
                );
                dgvCatagories.DataSource = categoryDAL.GetDataTable();
                MessageBox.Show("Yeni Kategori Eklendi");
            }
            catch(Exception)
            {
                MessageBox.Show("Kategori Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                categoryDAL.Delete(Convert.ToInt32(lblId.Text = dgvCatagories.CurrentRow.Cells[0].Value.ToString()));
                dgvCatagories.DataSource = categoryDAL.GetDataTable();
                MessageBox.Show("Kategori Silindi");
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            categoryDAL.Update(new Category
            {
                Id = Convert.ToInt32(lblId.Text),
                CategoryName = txtCatagory.Text,
                
            }
            );
            dgvCatagories.DataSource = categoryDAL.GetDataTable();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void dgvCatagories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvCatagories.CurrentRow.Cells[0].Value.ToString();
            txtCatagory.Text = dgvCatagories.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
