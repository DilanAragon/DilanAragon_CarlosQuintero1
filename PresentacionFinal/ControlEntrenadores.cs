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
    public partial class ControlEntrenadores : Form
    {
        readonly ServicioRegistroEntrenadores sistemaRegistroEntrenadores;
        public ControlEntrenadores()
        {
            InitializeComponent();
            sistemaRegistroEntrenadores = new ServicioRegistroEntrenadores();
        }
        void Guardar()
        {
            var entrenador = new Entrenadores()
            {
                Nombre = (txtNameTrainer.Text),
                Correo = txtMailTrainer.Text,
                Telefono = txtPhoneTrainer.Text,
                CodigoEntrenador = Convert.ToInt32(txtCode.Text),
            };
            var msj = sistemaRegistroEntrenadores.Save(entrenador);
            MessageBox.Show(msj);

        }
        private void LimpiarDatos()
        {
            txtNameTrainer.Text = String.Empty;
            txtPhoneTrainer.Text = String.Empty;
            txtCode.Text = String.Empty;
            txtMailTrainer.Text = String.Empty;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarDatos();
        }
    }
}
