using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class ListPrd : Form
    {
        Model1 db = new Model1();
        List<string> stringList = new List<string>();
        public ListPrd()
        {
            InitializeComponent();
        }

        private void ListPrd_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Product.ToList();
            productTypeBindingSource.DataSource = db.ProductType.ToList();
            comboBox1.Items.Add("Все элементы");
            foreach (ProductType o in db.ProductType)
            {
                stringList.Add(o.Title);
            }
            stringList.Sort();
            comboBox1.Items.AddRange(stringList.Select(n => n.ToString()).ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product pr = (Product)productBindingSource.Current;
            if (pr.Image == "" || pr.Image == null)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\picture.png");

            }
            else
            {
                pictureBox1.Image = Image.FromFile($@"..\..\{pr.Image}");
            }

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            FormAddEdd Addrm = new FormAddEdd();
            Addrm.pr = null;
            Addrm.db = db;
            DialogResult dr = Addrm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = db.Product.ToList();
            }
        }

        private void butEdd_Click(object sender, EventArgs e)
        {
            Product pr = (Product)productBindingSource.Current;
            FormAddEdd Addrm = new FormAddEdd();
            Addrm.pr = null;
            Addrm.db = db;
            DialogResult dr = Addrm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = db.Product.ToList();
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            Product prd = (Product)productBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить запись" + prd.Title + "'*'?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Product.Remove(prd);
                try
                {
                    db.SaveChanges();
                    productBindingSource.DataSource = db.Product.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                productBindingSource.DataSource = db.Product.ToList();
            }
            else
            {
                string n = (string)comboBox1.SelectedItem;
                productBindingSource.DataSource = db.Product.Where(x => x.ProductType.Title == n).ToList();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Product.Where(p => p.Title.Contains(textBox1.Text) || p.Description.Contains(textBox1.Text)).ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
