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
    public partial class User : Form
    {
        Model1 db = new Model1();
        public Customer sp { get; set; }
        public User()
        {
            InitializeComponent();
        }
        public void FullTable()
        {
            customerBindingSource.DataSource = db.Customer.ToList();//заполняем данные в таблицу из бд
        }
        private void bNazad_Click(object sender, EventArgs e)
        {
            Menu pmf = new Menu();
            pmf.Show();
            Hide();
        }

        private void YachtYard_User_Load(object sender, EventArgs e)
        {
            FullTable();
        }

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            Customer sp= (Customer)customerBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить пользователя - {sp.FamilyName.ToString()}?",
                "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Customer.Remove(sp);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Внимание! Пользователь успешно удален!", "Успешное удаление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                customerBindingSource.DataSource = db.Customer.ToList();
            }
        }

        private void changeProdBtn_Click(object sender, EventArgs e)
        {
            Customer sp = (Customer)customerBindingSource.Current;
            Redus frm = new Redus();
            frm.db = db;
            frm.sp = sp;
            this.Hide();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                customerBindingSource.DataSource = null;
                customerBindingSource.DataSource = db.Customer.ToList();
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            Redus frm = new Redus();
            frm.db = db;
            frm.sp = null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                customerBindingSource.DataSource = null;
                customerBindingSource.DataSource = db.Customer.ToList();

            }
        }
    }
}
