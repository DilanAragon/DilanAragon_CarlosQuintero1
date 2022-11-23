using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
            BotonMinVentana.Visible = false;
            BotonMaxVentana.Visible = true;
        }

        private void BotonMaxVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotonMaxVentana.Visible = false;
            BotonMinVentana.Visible = true;

        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelSubMenuReporte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonReportes_Click(object sender, EventArgs e)
        {
            PanelSubMenuReporte.Visible = true;    
        }

        private void BotonReporteMensualidad_Click(object sender, EventArgs e)
        {
            PanelSubMenuReporte.Visible = false;
        }

        private void BotonReporteCliente_Click(object sender, EventArgs e)
        {
            PanelSubMenuReporte.Visible = false;
        }
        private void AbrirFormularioHijo(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
            
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ControlClientes());
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Inicio());
        }
    }
}
