using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class ControlEntrenadores : Form
    {
        readonly EntrenadorService entrenadorService;
        readonly ClientService clientService;
        public ControlEntrenadores()
        {
            InitializeComponent();
            clientService = new ClientService();
            entrenadorService = new EntrenadorService();
        }
        void Guardar()
        {
            var entrenador = new Entrenadores()
            {
                Nombre = (txtNameTrainer.Text),
                Apellido = txtLastName.Text,
                Telefono = txtPhoneTrainer.Text,
                Identificacion = txtIdentification.Text,
                Correo = txtMailTrainer.Text
            };
            var msj = entrenadorService.SaveEntrenador(entrenador);
            MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        private void LimpiarDatos()
        {
            txtNameTrainer.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhoneTrainer.Text = String.Empty;
            txtIdentification.Text = String.Empty;
            txtMailTrainer.Text = String.Empty;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }
    }
}
