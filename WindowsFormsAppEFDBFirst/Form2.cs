using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFDBFirst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ProjeGelistirmeDBEntities projeGelistirmeDBEntities = new ProjeGelistirmeDBEntities();
        void Yukle()
        {
            dataGridView1.DataSource = projeGelistirmeDBEntities.Categories.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //ıd
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Categories.Find(Id);
            projeGelistirmeDBEntities.Categories.Remove(kayit);
            var sonuc = projeGelistirmeDBEntities.SaveChanges();
            Yukle();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Categories.Find(Id);
            kayit.CategoryName = textBox1.Text;
            var sonuc = projeGelistirmeDBEntities.SaveChanges();
            Yukle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                projeGelistirmeDBEntities.Categories.Add(new Categories
                {
                    CategoryName = textBox1.Text,
                   
                });
                var sonuc = projeGelistirmeDBEntities.SaveChanges();
                Yukle();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kategori Eklendi");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception add_hata) { MessageBox.Show("Kategori Eklenemedi " + add_hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = projeGelistirmeDBEntities.Categories.Find(Id);
            label2.Text = kayit.Id.ToString();
            textBox1.Text = kayit.CategoryName;

        }
    }
}
