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
    public partial class Redacc : Form
    {
        public Model1 db { get; set; }
        public Accessory ac { get; set; } = null;
        public Redacc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pmf = new Product();
            pmf.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ac== null)
            { // если создан новый объект, то получаем его промеж. объекта
                ac= (Accessory)accessoryBindingSource.Current;
                // сохраняем созданный и заполненный объект в коллекции
                db.Accessory.Add(ac);
                

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

        private void Redacc_Load(object sender, EventArgs e)
        {
            if (ac== null)

            {
                accessoryBindingSource.AddNew();
                this.Text = "Добавление";
            }
            else
            {
                accessoryBindingSource.Add(ac);
                this.Text = "Корректировка данных " + ac.AccName;
            }
        }
    }
}
