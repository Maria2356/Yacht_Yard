using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yacht_Yard
{
    public partial class Product : Form
    {
        Model1 db = new Model1();
        public Accessory ac { get; set; }
        public Product()
        {
            InitializeComponent();
        }
        public void FullTable()
        {
            accessoryBindingSource.DataSource = db.Accessory.ToList();//заполняем данные в таблицу из бд
        }

        private void bNazad_Click(object sender, EventArgs e)
        {
            Menu pmf = new Menu();
            pmf.Show();
            Hide();
        }

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            Accessory prod = (Accessory)accessoryBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить продукцию - {prod.AccName.ToString()}?",
                "Удаление продукции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Accessory.Remove(prod);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Внимание! Продукция успешно удалена!", "Успешное удаление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                accessoryBindingSource.DataSource = db.Customer.ToList();
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            accessoryBindingSource.DataSource = db.Accessory.ToList();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            Redacc frm = new Redacc();
            frm.db = db;
            frm.ac= null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                accessoryBindingSource.DataSource = null;
                accessoryBindingSource.DataSource = db.Accessory.ToList();

            }
        }

        private void changeProdBtn_Click(object sender, EventArgs e)
        {
            Redacc frm = new Redacc();
            frm.db = db;
            frm.ac= ac;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                accessoryBindingSource.DataSource = null;
                accessoryBindingSource.DataSource = db.Accessory.ToList();

            }
        }
    }
}
