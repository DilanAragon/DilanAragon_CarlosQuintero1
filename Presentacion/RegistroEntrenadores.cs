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

namespace Presentacion
{
    public partial class RegistroEntrenadores : Form
    {
        readonly ServicioRegistroEntrenadores sistemaRegistroEntrenadores;
        public RegistroEntrenadores()
        {
            InitializeComponent();
            sistemaRegistroEntrenadores = new ServicioRegistroEntrenadores();
        }
        void Guardar()
        {
            var entrenador = new Entrenadores()
            {
                Nombre = (txtNom.Text),
                Correo = txtCorreo.Text,
                Telefono = txtTel.Text,
                CodigoEntrenador=Convert.ToInt32(txtCodigo.Text),
            };
            var msj = sistemaRegistroEntrenadores.Save(entrenador);
            MessageBox.Show(msj);

        }
        private void LimpiarDatos()
        {
            txtNom.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            txtCorreo.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
