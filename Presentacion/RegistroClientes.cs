using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {
        readonly ServicioRegistroClientes sistemaRegistroClientes;
        public RegistroClientes()
        {
            InitializeComponent();
            sistemaRegistroClientes  = new ServicioRegistroClientes();
        }
        void Guardar()
        {            
            var cliente = new Clientes()
            {
                Nombre = (txtNom.Text),
                AlturaCliente = Convert.ToInt32(txtAltura.Text),
                PesoCliente = Convert.ToInt32(txtPeso.Text),
                Id = (txtId.Text),
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
            };          
            var msj = sistemaRegistroClientes.Save(cliente);
            MessageBox.Show(msj);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            txtNom.Text = String.Empty;
            txtId.Text = String.Empty;
            txtAltura.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCorreo.Text = String.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var MenuClientes = new MenuClientes();
            this.Hide();
            MenuClientes.Show();
        }
    }
}
