using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class FrmControlActivos : Form
    {
        readonly EntrenadorService entrenadorService;
        readonly ClientService clientService;
        public FrmControlActivos()
        {
            InitializeComponent();
        }
        public void Modificar()
        {
            var cliente = new Clientes()
            {
                Activo = Convert.ToInt32(txtActivo.Text),
            };
            var msj = clientService.UpdateClient(cliente);
            MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void LoadCliente(Clientes cliente)
        {
            txtActivo.Text = cliente.Activo.ToString();
        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
