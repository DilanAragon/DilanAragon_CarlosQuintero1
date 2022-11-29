using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class FrmDetallesClientes : Form
    {
        
        
        public FrmDetallesClientes(Clientes cliente)
        {
         
            InitializeComponent();
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

        }
    }
}
