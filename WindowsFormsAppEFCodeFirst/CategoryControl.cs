using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class CategoryControl : Form
    {
        public CategoryControl()
        {
            InitializeComponent();
        }
        GuideDBContext dbContext = new GuideDBContext();
        void Yukle()
        {
            dgvCategories.DataSource = dbContext.Categories.ToList();
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {   
            btnUpd.Enabled = false;
            btnDelete.Enabled = false;
            Yukle();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id=Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value);
            var kayit = dbContext.Categories.Find(Id);
            lblId.Text=kayit.Id.ToString();
            txtCategory.Text=kayit.CategoryName.ToString();
            btnDelete.Enabled = true;
            btnUpd.Enabled = true;    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbContext.Categories.Add(new Category
            {
                CategoryName = txtCategory.Text,
            });
            var sonuc=dbContext.SaveChanges();
            Yukle();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value);
            var kayit = dbContext.Categories.Find(Id);
            kayit.CategoryName = txtCategory.Text;
            var sonuc= dbContext.SaveChanges();
            Yukle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value);
            var kayit = dbContext.Categories.Find(Id);
            dbContext.Categories.Remove(kayit);
            dbContext.SaveChanges();
            Yukle();
            btnDelete.Enabled = false;
            btnUpd .Enabled = false;
            txtCategory.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategories.DataSource=dbContext.Categories.Where(u=>u.CategoryName.Contains(txtSearch.Text)).ToList();
        }
    }
}