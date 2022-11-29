using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class ControlClientes : Form

    {
        readonly ClientService clientService;
        readonly EntrenadorService entrenadorService;
        int idEntrenador = 0;
        public ControlClientes()
        {
            InitializeComponent();
            clientService= new ClientService();
            entrenadorService= new EntrenadorService();
            LoadEntrenadores();
        }

        private void LoadEntrenadores()
        {
            var lista = entrenadorService.GetClientes();
            foreach (var item in lista)
            {
                cmbEntrenadores.Items.Add(item.IdEntrenador + " - " +item.Nombre.Trim() + " " + item.Apellido.Trim());
            }
        }
        void Guardar()
        {
            if (idEntrenador != 0)
            {
                var cliente = new Clientes()
                {
                    Nombre = (TxtName.Text),
                    Apellido = txtApellido.Text,
                    AlturaCliente = string.IsNullOrEmpty(TxtAltura.Text) ? 0 : Convert.ToDecimal(TxtAltura.Text),
                    PesoCliente = string.IsNullOrEmpty(TxtPeso.Text) ? 0 : Convert.ToDecimal(TxtPeso.Text),
                    Correo = TxtMail.Text,
                    Telefono = TxtPhone.Text,
                    IdEntrenador = Convert.ToInt32(idEntrenador),
                    Identificacion = TxtId.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    
                };
                var msj = clientService.SaveClient(cliente);
                MessageBox.Show(msj, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Seleccione Un Entrenador Para Continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void LimpiarDatos()
        {
            TxtName.Text = String.Empty;
            TxtId.Text = String.Empty;
            TxtAltura.Text = String.Empty;
            TxtPeso.Text = String.Empty;
            TxtPhone.Text = String.Empty;
            TxtMail.Text = String.Empty;
            txtApellido.Text = String.Empty;
            cmbEntrenadores.Text = String.Empty;
            txtEdad.Text= String.Empty;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEntrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var texto = cmbEntrenadores.Text;
            var position = texto.IndexOf('-');
            idEntrenador = Convert.ToInt32(texto.Substring(0, position));

        }

     
    }
}
