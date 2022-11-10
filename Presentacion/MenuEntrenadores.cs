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
    public partial class MenuEntrenadores : Form
    {
        public MenuEntrenadores()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RegistroEntrenadores = new RegistroEntrenadores();
            this.Hide();
            RegistroEntrenadores.Show();
        }
    }
}
