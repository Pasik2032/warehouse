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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство отвечает за обращение к имени продукта.
        /// </summary>
        public string NameProd
        {
            get
            { 
                if(Name.Text.Trim()  == "" || Name.Text == null)
                {
                    throw new ArgumentException("Неверно введено имя товара");
                }

                return Name.Text.Trim();
            }
            set
            {
                Name.Text = value;
            } 
        }

        /// <summary>
        /// Свойство отвечает за обращение к артиклу продукта.
        /// </summary>
        public string CodProd
        {
            get
            {
                if (cod.Text.Trim() == "" || cod.Text == null)
                {
                    throw new ArgumentException("Неверно введен арикул");
                }

                return cod.Text.Trim();
            }
            set
            {
                cod.Text = value;
            }
        }

        /// <summary>
        /// Свойства отвечает за обращение к цене продукты.
        /// </summary>
        public double ValuableProd
        {
            get
            {
                double a;
                if (double.TryParse(valuable.Text, out a)  && a >= 0 )
                {
                    return a;
                }

                throw new ArgumentException("Неверно введена ценна");
            }
            set
            {
                valuable.Text = value.ToString();
            }
        }

        /// <summary>
        /// Свойство отвечает за обращение к кол-ву продукта.
        /// </summary>
        public int QuantityProd
        {
            get
            {
                int a;
                if (int.TryParse(quantity.Text, out a) && a >= 0)
                {
                    return a;
                }

                throw new ArgumentException("Неверно введено кол-во");
            }
            set
            {
                quantity.Text = value.ToString();
            }
        }

        /// <summary>
        /// Свойство отвечает за обращение к описанию продукта.
        /// </summary>
        public string DescriptionProd
        {
            get
            {
                if (textBox1.Text.Trim() == "" || textBox1.Text == null)
                {
                    return "";
                }

                return textBox1.Text.Trim();
            }
            set
            {
                textBox1.Text = value;
            }
        }
        // false - если закрыли через крестик true - если нажали ОК.
        public bool isOk = false;

        private void button1_Click(object sender, EventArgs e)
        {
            isOk = true;
            Close();
        }
    }
}
