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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bVixod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bUser_Click(object sender, EventArgs e)
        {
            User pmf = new User();
            pmf.Show();
            Hide();
        }

        private void bProduct_Click(object sender, EventArgs e)
        {
            Product pmf = new Product();
            pmf.Show();
            Hide();
        }

        private void bCost_Click(object sender, EventArgs e)
        {
            Cost pmf = new Cost();
            pmf.Show();
            Hide();
        }
    }
}
