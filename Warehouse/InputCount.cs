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
    public partial class InputCount : Form
    {
        public InputCount()
        {
            InitializeComponent();
        }

        public int Count
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int a) && a > 0)
                    return a;
                throw new ArgumentException("Введено некорректноке число");
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }
        public bool isOk = false;
        private void button1_Click(object sender, EventArgs e)
        {
            isOk = true;
            Close();
        }
    }
}
