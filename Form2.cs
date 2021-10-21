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
    public partial class FormAddEdd : Form
    {
        public Model1 db { get; set; }

        public Product pr { get; set; }
        public List<string> stringList = new List<string>();
        public FormAddEdd()
        {
            InitializeComponent();
        }

        private void FormAddEdd_Load(object sender, EventArgs e)
        {
            productTypeBindingSource.DataSource = db.ProductType.ToList();
            comboBox1.Items.Add("Все элементы");
            foreach (ProductType o in db.ProductType)
            {
                stringList.Add(o.Title);
            }
            stringList.Sort();
            comboBox1.Items.AddRange(stringList.Select(n => n.ToString()).ToArray());
            if (pr == null)
            {
                productBindingSource.AddNew();
            }
            else
            {
                productBindingSource.Add(pr);

            }

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (pr == null)
            {
                pr = (Product)productBindingSource.Current;
                db.Product.Add(pr);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка "+ex.Message);
            }

        }
        string FileName = "";
        private void butpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото";
            ofd.InitialDirectory = @"...\...\...\...\...\Lopushok\products";
            ofd.Filter = "Файлы JPEG,JPG,GIF,PNG|*.jpeg;*.jpg;*.gif;*.png|Все файлы(*.*)|*.*";
            DialogResult rc = ofd.ShowDialog();
            if (rc == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                FileName = ofd.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
