using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class ControlClientes : Form

    {
        readonly ServicioRegistroClientes sistemaRegistroClientes;
        public ControlClientes()
        {
            InitializeComponent();
            sistemaRegistroClientes = new ServicioRegistroClientes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void Guardar()
        {
            var cliente = new Clientes()
            {
                Nombre = (TxtName.Text),
                AlturaCliente = Convert.ToInt32(TxtAltura.Text),
                PesoCliente = Convert.ToInt32(TxtPeso.Text),
                Id = (TxtId.Text),
                Correo = TxtMail.Text,
                Telefono = TxtPhone.Text,
                Mensualidad=Convert.ToInt32(TxtPay.Text),

            };
            var msj = sistemaRegistroClientes.Save(cliente);
            MessageBox.Show(msj);

        }
        private void LimpiarDatos()
        {
            TxtName.Text = String.Empty;
            TxtId.Text = String.Empty;
            TxtAltura.Text = String.Empty;
            TxtPeso.Text = String.Empty;
            TxtPhone.Text = String.Empty;
            TxtMail.Text = String.Empty;
            TxtPay.Text = String.Empty;
            TxtTrainer.Text = String.Empty;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }
    }
}
