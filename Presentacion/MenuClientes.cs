using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RegistroClientes = new RegistroClientes();
            this.Close();
            RegistroClientes.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //beta
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //beta
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //beta
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //beta
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }
    }
}
