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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GuideDBContext guidedbContext = new GuideDBContext();
        void Yukle()
        {
            //chat-gpt used for show category name and this list used few times in search parts
            var list = guidedbContext.Guides
        .Include("Category")
        .Select(g => new
        {
            g.Id,
            g.Name,
            g.Description,
            g.DateofChange,
            Kategori = g.Category.CategoryName
        })
        .ToList();

            dgvGuides.DataSource = list;
            cmbChoseDepartment.DataSource = guidedbContext.Categories.ToList();
            comboCategory.DataSource = guidedbContext.Categories.ToList();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvGuides_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvGuides.CurrentRow.Cells[0].Value.ToString());
            var kayit = guidedbContext.Guides.Find(Id);
            guidedbContext.Guides.Remove(kayit);
            var sonuc = guidedbContext.SaveChanges();
            Yukle();

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvGuides.CurrentRow.Cells[0].Value.ToString());
            var kayit = guidedbContext.Guides.Find(Id);
            kayit.Description = textBox2.Text;
            kayit.Name = textBox1.Text;
            kayit.DateofChange = DateTimeOffset.Now;
            var sonuc = guidedbContext.SaveChanges();
            Yukle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            guidedbContext.Guides.Add(new Guide
            {

                Name = textBox1.Text,
                Description = textBox2.Text,
                DateofChange = DateTimeOffset.Now,
                CategoryId = (int)comboCategory.SelectedValue,
            }
            );
            var sonuc = guidedbContext.SaveChanges();
            Yukle();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        var list = guidedbContext.Guides
        .Include("Category")
        .Where(u => u.Name.Contains(textBox3.Text) || u.Description.Contains(textBox3.Text))
        .Select(g => new
        {
            g.Id,
            g.Name,
            g.Description,
            g.DateofChange,
            Kategori = g.Category.CategoryName
        })
        .ToList();
            dgvGuides.DataSource = list.ToList();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvGuides_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dgvGuides.CurrentRow.Cells[0].Value.ToString());
            var kayit = guidedbContext.Guides.Find(Id);
            textBox1.Text = kayit.Name;
            textBox2.Text = kayit.Description;
            comboCategory.SelectedValue = kayit.CategoryId;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbChoseDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int Id = (Convert.ToInt32(cmbChoseDepartment.SelectedValue));
            var list = guidedbContext.Guides
        .Include("Category")
        .Where(u => u.CategoryId == Id)
        .Select(g => new
        {
            g.Id,
            g.Name,
            g.Description,
            g.DateofChange,
            Kategori = g.Category.CategoryName
        })
        .ToList();
            dgvGuides.DataSource = list.ToList();
        }

        private void cmbChoseDepartment_Click(object sender, EventArgs e)
        {
            
        }
    }
}