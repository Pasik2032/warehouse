using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class RegClient : Form
    {
        public RegClient()
        {
            InitializeComponent();
        }
        public string Name
        {
            get
            {
                if (name.Text == null || name.Text == "") throw new ArgumentException("Некорректно введено ФИО");
                return name.Text;
            }
            set
            {
                name.Text = value;
            }
        }
        public string Address
        {
            get
            {
                if (address.Text == null || address.Text == "") throw new ArgumentException("Некорректно введен адресс");
                return address.Text;
            }
            set
            {
                address.Text = value;
            }
        }
        public string Phone
        {
            get
            {
                float a;
                if (!(float.TryParse(phone.Text, out a)) || a < 0 || phone.Text.Length != 11)
                    throw new ArgumentException("Некрректный номер телефона, его надо  вводить через 8 и всего должно быть 11 цифр");
                return phone.Text;
            }
            set
            {
                phone.Text = value.ToString();
            }
        }
        public string Email
        {
            get
            {
                if (email.Text == null || email.Text == "") throw new ArgumentException("Некорректно введен e-mail");
                return email.Text;
            }
            set
            {
                email.Text = value;
            }
        }
        public string Password
        {
            get
            {
                if (password.Text == null || password.Text == "") 
                    throw new ArgumentException("Некорректно введен пароль");
                return password.Text;
            }
            set
            {
                password.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Client.NewClient(Name, Phone, Address, Email, Password))
                Close();
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже существует");
            }
        }
    }
}
