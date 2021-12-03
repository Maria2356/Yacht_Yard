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
    public partial class Cost : Form
    {
        Model1 db = new Model1();
        public Cost()
        {
            InitializeComponent();
        }

        public void FullTable()
        {
            invoiceBindingSource1.DataSource = db.Invoice.ToList();//заполняем данные в таблицу из бд
        }
        private void bNazad_Click(object sender, EventArgs e)
        {
            Menu pmf = new Menu(); // возвращение к меню
            pmf.Show();
            Hide();
        }

        private void YachtYard_Cost_Load(object sender, EventArgs e)
        {
            FullTable();
        }
    }
}
