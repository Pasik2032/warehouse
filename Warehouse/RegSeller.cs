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
    public partial class RegSeller : Form
    {
        public RegSeller()
        {
            InitializeComponent();
        }
        public string Password
        {
            get
            {
                if (password.Text == null || password.Text == "") throw new ArgumentException("Некорректно введен пароль");
                return password.Text;
            }
            set
            {
                password.Text = value;
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

        private void Reg_Click(object sender, EventArgs e)
        {
            if (Seller.NewSeller(Name,  Email, Password))
                Close();
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже существует");
            }
        }
    }
}
