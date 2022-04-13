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
    public partial class CreateSelection : Form
    {
        public CreateSelection()
        {
            InitializeComponent();
            isOk = false;
        }
        public string Input { get; set; }
        public bool isOk { get; set; }

        private void Create_Click(object sender, EventArgs e)
        {

            Input = textBox1.Text.Trim(' ');
            //if (Input == null || Input.Trim(' ') == "") 
            if (Input == null || Input == "")
            {
                MessageBox.Show("Некорректные данные");
            }
            else
            {
                isOk = true;
                Close();
            }

        }
    }
}
