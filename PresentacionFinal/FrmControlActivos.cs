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
        int idCliente;
        public FrmControlActivos(Clientes cliente)
        {
            InitializeComponent();
            entrenadorService = new EntrenadorService();
            clientService = new ClientService();
            lblName.Text = cliente.Nombre + " " + cliente.Apellido.Trim();
            string estado = cliente.Activo == true ? "Activo" : "Inanctivo";
            lblEstate.Text = "Estado: " + estado.Trim();
            idCliente = cliente.IdClientes;
        }
        public void ModificarEstado()
        {
            bool estado = false;
            if (cmbEstado.Text.Equals("Activo"))
            {
                estado= true;
            }
            Clientes cliente = new Clientes()
            {
                Activo = estado,
                IdClientes = idCliente
            };
            var msj = clientService.UpdateEstate(cliente);
            MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ModificarEstado();
        }
    }
}
