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
    public partial class Registr : Form
    {
        Model1 db = new Model1();
        public static Form Form1 = null;
        public Registr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == " " ||
             textBox3.Text == " " || maskedTextBox1.Text == " " ||
             comboBox1.Text == " "  || textBox13.Text == " " || textBox4.Text == " ")
            {
                MessageBox.Show(" Нужно задать все данные!");
                return;
            }
            if (textBox13.Text != textBox4.Text)
            {
                MessageBox.Show(" Значения паролей не совпадают!");
                return;
            }
            if ((comboBox1.Text != "Пользователь") && (comboBox1.Text != "Администратор"))
            {
                MessageBox.Show(" Задана неверная роль! ");
                return;
            }
            Regi usr = db.Regi.Find(textBox2.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь уже есть!");
                return;
            }

            usr = new Regi();
            usr.LastName = textBox3.Text;
            usr.Name = textBox2.Text;
            usr.Phone = maskedTextBox1.Text;
            usr.Role = comboBox1.Text;
            usr.Login = textBox1.Text;
            usr.Password = textBox13.Text;



            db.Regi.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(" Пользователь " + usr.LastName + " зарегистрирован! ");
            Login frm = new Login();
            this.Hide();
            frm.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
