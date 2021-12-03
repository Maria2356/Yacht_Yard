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
    public partial class Redus : Form
    {
        public Model1 db { get; set; }
        public Customer sp { get; set; } = null;
        public Redus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sp == null)
            { // если создан новый объект, то получаем его промеж. объекта
                sp = (Customer)customerBindingSource.Current;
                // сохраняем созданный и заполненный объект в коллекции
                db.Customer.Add(sp);
                

            }
            try
            {
                db.SaveChanges();

                // если задать значение свойству DialogResult, то форма закроется

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // если возникла ошибка, то показываем сообщение
                MessageBox.Show("Ошибка" + ex.Message);
                // если DialogResult значение не задано, форма не закрывается
            }
        }

        private void Redus_Load(object sender, EventArgs e)
        {
            if (sp == null)

            {
                customerBindingSource.AddNew();
                this.Text = "Добавление";
            }
            else
            {
                customerBindingSource.Add(sp);
                this.Text = "Корректировка данных " + sp.FistName;
            }
        }
    }
}
