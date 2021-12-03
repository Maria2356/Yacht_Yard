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
    public partial class Login : Form
    {
        public static Regi US { get; set; }
        Model1 db = new Model1();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Нужно задать логин, пароль и роль!");
                return;
            }
            Regi usr = db.Regi.Find(loginTextBox.Text);
            if ((usr != null) && (usr.Password == passwordTextBox.Text))
            {
                US = usr;
                if (usr.Role == "Пользователь")
                {
                    Product frm = new Product();
                    frm.Show();
                    this.Hide();
                    //  schert = 3;  // одновление счетчика
                    // erorrM.Text = "";  // очистка поля ошибки, ведь логин пароль верны
                }
                else
                if (usr.Role == "Администратор")
                {
                    User frm = new User();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли {usr.Role} в системе нет!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr frm = new Registr();
            frm.Show();
            this.Hide();
        }
    }
}
