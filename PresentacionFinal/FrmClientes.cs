namespace PresentacionFinal
{
    using Entidades;
    using Logica;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Security.Principal;
    using System.Windows.Forms;
    public partial class FrmClientes : Form
    {
        readonly ClientService clientService;
        List<Clientes> clientesGlobal = new List<Clientes>();
        public FrmClientes()
        {
            InitializeComponent();
            clientService = new ClientService();
            LoadClients();
        }

        private void LoadClients()
        {
            List<Clientes> clientes = clientService.GetClientes();
            if (clientes.Count() > 0)
            {
                gridClientes.DataSource = PaintClients(clientes);
                clientesGlobal = clientes;
            }
        }

        public DataTable PaintClients(IList<Clientes> clientes)
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdCliente");
            table.Columns.Add("Identificacion");
            table.Columns.Add("Nombre y apellido");
            table.Columns.Add("Telefono");
            table.Columns.Add("Peso");
            table.Columns.Add("Altura");

            foreach (var item in clientes)
            {
                DataRow row = table.NewRow();
                row["IdCliente"] = item.IdClientes;
                row["Identificacion"] = item.Identificacion;
                row["Nombre y apellido"] = item.Nombre + " " + item.Apellido;
                row["Telefono"] = item.Telefono;
                row["Peso"] = item.PesoCliente;
                row["Altura"] = item.AlturaCliente;

                table.Rows.Add(row);
            }
            return table;
        }

        private void btnAddClient_Click(object sender, System.EventArgs e)
        {
            ControlClientes ctrlClients = new ControlClientes();
            ctrlClients.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

            Int32 selectedColumnCount = gridClientes.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedColumnCount != gridClientes.Columns.Count)
            {
                MessageBox.Show("Seleccione una fila", "Error");
                return;
            }
            var id = gridClientes.CurrentRow.Cells[0].Value;
            var cliente = clientService.GetClientById(Convert.ToInt32(id.ToString()));
            FrmDetallesClientes frmDetalles = new FrmDetallesClientes(cliente);
            frmDetalles.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadClients();
            }
            else
            {
                LoadSearch(txtSearch.Text);
            }
        }

        private void LoadSearch(string parametro)
        {
            List<Clientes> filter = clientesGlobal.Where(c => c.Identificacion.ToUpper().Contains(parametro.ToUpper()) || c.Nombre.ToUpper().Contains(parametro.ToUpper()) || c.Apellido.ToUpper().Contains(parametro.ToUpper())).ToList();
            gridClientes.DataSource = PaintClients(filter);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmControlActivos frmPagoCliente= new FrmControlActivos();
            frmPagoCliente.ShowDialog();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
