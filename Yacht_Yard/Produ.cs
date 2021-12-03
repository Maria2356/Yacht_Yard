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
    public partial class Produ : Form
    {
        Model1 db = new Model1();
        public Produ()
        {
            InitializeComponent();
        }

        private void bNazad_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void Produ_Load(object sender, EventArgs e)
        {
            accessoryBindingSource.DataSource = db.Accessory.ToList();
        }
    }
}
