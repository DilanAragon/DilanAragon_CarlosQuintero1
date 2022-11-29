using Entidades;
using Logica;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Xml.Linq;

namespace PresentacionFinal
{
    public partial class FrmDetallesClientes : Form
    {
        readonly EntrenadorService entrenadorService;
        readonly ClientService clientService;
        int idEntrenador = 0;
        public FrmDetallesClientes(Clientes cliente)
        {
         
            InitializeComponent();
            entrenadorService = new EntrenadorService();
            clientService = new ClientService();
            LoadCliente(cliente);
            
        }

        private void LoadCliente(Clientes cliente)
        {
            
            txtIdCliente.Text = cliente.IdClientes.ToString();
            txtFirstName.Text = cliente.Nombre;
            txtLastName.Text = cliente.Apellido;
            txtIdentificacion.Text= cliente.Identificacion;
            txtEmail.Text=cliente.Correo;
            txtTelephone.Text=cliente.Telefono;
            txtPeso.Text = cliente.PesoCliente.ToString();
            cmbEntrenadores.Text = cliente.IdEntrenador.ToString();
            txtAltura.Text=cliente.AlturaCliente.ToString();
            var entrenador = entrenadorService.GetEntrenadorById(cliente.IdEntrenador);
            cmbEntrenadores.Text = entrenador.IdEntrenador + " - " + entrenador.Nombre + " " + entrenador.Apellido;
            var texto = cmbEntrenadores.Text;
            var position = texto.IndexOf('-');
            idEntrenador = Convert.ToInt32(texto.Substring(0, position));
        }


        public void Modificar()
        {
            if (idEntrenador != 0)
            {
                var cliente = new Clientes()
                {
                    Nombre = txtFirstName.Text,
                    Apellido = txtLastName.Text,
                    AlturaCliente = string.IsNullOrEmpty(txtAltura.Text) ? 0 : Convert.ToDecimal(txtAltura.Text),
                    PesoCliente = string.IsNullOrEmpty(txtPeso.Text) ? 0 : Convert.ToDecimal(txtPeso.Text),
                    Correo = txtEmail.Text,
                    Telefono = txtTelephone.Text,
                    IdEntrenador = Convert.ToInt32(idEntrenador),
                    Identificacion = txtIdentificacion.Text,
                    IdClientes = Convert.ToInt32(txtIdCliente.Text),
                };
                var msj = clientService.UpdateClient(cliente);
                MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void cmbEntrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var texto = cmbEntrenadores.Text;
            var position = texto.IndexOf('-');
            idEntrenador = Convert.ToInt32(texto.Substring(0, position));
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
