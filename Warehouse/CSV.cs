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
    /// <summary>
    /// Форма ввода количество остатка на складе для CSV отчета.
    /// </summary>
    public partial class CSV : Form
    {
        public CSV()
        {
            InitializeComponent();
        }
        // false - если закрыли через крестик true - если нажали ОК.
        public bool isOk = false;

        /// <summary>
        /// Минимальный возможный остаток без выгрузки в CSV.
        /// </summary>
        public int Quantity 
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int a) && a >= 0)
                {
                    return a;
                }
                throw new ArgumentException("Некоректные данные");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOk = true;
            Close();
        }
    }
}
