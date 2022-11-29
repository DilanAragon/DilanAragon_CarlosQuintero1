namespace PresentacionFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BotonMaxVentana = new System.Windows.Forms.PictureBox();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonMinVentana = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.FlowLayoutPanel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelSubMenuMedios = new System.Windows.Forms.Panel();
            this.BotonSubMenuAñadir = new System.Windows.Forms.Button();
            this.BotonEntrenadores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelSubMedioTrainer = new System.Windows.Forms.Panel();
            this.BotonSubMenuAñadirTrainer = new System.Windows.Forms.Button();
            this.BotonReportes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelSubMedioReporte = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BotonSubMenuReporteIngreso = new System.Windows.Forms.Button();
            this.BotonPagos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaxVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelSubMenuMedios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelSubMedioTrainer.SuspendLayout();
            this.PanelSubMedioReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BarraTitulo.Controls.Add(this.BotonMaxVentana);
            this.BarraTitulo.Controls.Add(this.BotonMinimizar);
            this.BarraTitulo.Controls.Add(this.BotonMinVentana);
            this.BarraTitulo.Controls.Add(this.BotonCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BotonMaxVentana
            // 
            this.BotonMaxVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMaxVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMaxVentana.Image = ((System.Drawing.Image)(resources.GetObject("BotonMaxVentana.Image")));
            this.BotonMaxVentana.Location = new System.Drawing.Point(1232, 7);
            this.BotonMaxVentana.Name = "BotonMaxVentana";
            this.BotonMaxVentana.Size = new System.Drawing.Size(25, 25);
            this.BotonMaxVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonMaxVentana.TabIndex = 2;
            this.BotonMaxVentana.TabStop = false;
            this.BotonMaxVentana.Visible = false;
            this.BotonMaxVentana.Click += new System.EventHandler(this.BotonMaxVentana_Click);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizar.Image")));
            this.BotonMinimizar.Location = new System.Drawing.Point(1201, 7);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonMinimizar.TabIndex = 1;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            // 
            // BotonMinVentana
            // 
            this.BotonMinVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinVentana.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinVentana.Image")));
            this.BotonMinVentana.Location = new System.Drawing.Point(1232, 7);
            this.BotonMinVentana.Name = "BotonMinVentana";
            this.BotonMinVentana.Size = new System.Drawing.Size(25, 25);
            this.BotonMinVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonMinVentana.TabIndex = 1;
            this.BotonMinVentana.TabStop = false;
            this.BotonMinVentana.Click += new System.EventHandler(this.BotonMinVentana_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.Location = new System.Drawing.Point(1263, 7);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.AutoSize = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(68)))), ((int)(((byte)(67)))));
            this.MenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuVertical.Controls.Add(this.PbLogo);
            this.MenuVertical.Controls.Add(this.BotonClientes);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.PanelSubMenuMedios);
            this.MenuVertical.Controls.Add(this.BotonEntrenadores);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.PanelSubMedioTrainer);
            this.MenuVertical.Controls.Add(this.BotonReportes);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.PanelSubMedioReporte);
            this.MenuVertical.Controls.Add(this.BotonPagos);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(226, 612);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // PbLogo
            // 
            this.PbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(3, 3);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(218, 124);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            this.PbLogo.Click += new System.EventHandler(this.PbLogo_Click);
            // 
            // BotonClientes
            // 
            this.BotonClientes.AllowDrop = true;
            this.BotonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonClientes.FlatAppearance.BorderSize = 0;
            this.BotonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonClientes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonClientes.Image = ((System.Drawing.Image)(resources.GetObject("BotonClientes.Image")));
            this.BotonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonClientes.Location = new System.Drawing.Point(30, 133);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonClientes.Size = new System.Drawing.Size(191, 34);
            this.BotonClientes.TabIndex = 1;
            this.BotonClientes.Text = "CLIENTES";
            this.BotonClientes.UseVisualStyleBackColor = true;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel1.Location = new System.Drawing.Point(14, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 2;
            // 
            // PanelSubMenuMedios
            // 
            this.PanelSubMenuMedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelSubMenuMedios.Controls.Add(this.BotonSubMenuAñadir);
            this.PanelSubMenuMedios.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuMedios.Location = new System.Drawing.Point(11, 173);
            this.PanelSubMenuMedios.Name = "PanelSubMenuMedios";
            this.PanelSubMenuMedios.Size = new System.Drawing.Size(210, 45);
            this.PanelSubMenuMedios.TabIndex = 3;
            this.PanelSubMenuMedios.Visible = false;
            // 
            // BotonSubMenuAñadir
            // 
            this.BotonSubMenuAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonSubMenuAñadir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonSubMenuAñadir.FlatAppearance.BorderSize = 0;
            this.BotonSubMenuAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonSubMenuAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSubMenuAñadir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.BotonSubMenuAñadir.Location = new System.Drawing.Point(0, 0);
            this.BotonSubMenuAñadir.Name = "BotonSubMenuAñadir";
            this.BotonSubMenuAñadir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonSubMenuAñadir.Size = new System.Drawing.Size(210, 40);
            this.BotonSubMenuAñadir.TabIndex = 0;
            this.BotonSubMenuAñadir.Text = "AÑADIR";
            this.BotonSubMenuAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonSubMenuAñadir.UseVisualStyleBackColor = true;
            this.BotonSubMenuAñadir.Click += new System.EventHandler(this.BotonSubMenuAñadir_Click);
            // 
            // BotonEntrenadores
            // 
            this.BotonEntrenadores.AllowDrop = true;
            this.BotonEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEntrenadores.FlatAppearance.BorderSize = 0;
            this.BotonEntrenadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEntrenadores.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEntrenadores.Image = ((System.Drawing.Image)(resources.GetObject("BotonEntrenadores.Image")));
            this.BotonEntrenadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonEntrenadores.Location = new System.Drawing.Point(30, 224);
            this.BotonEntrenadores.Name = "BotonEntrenadores";
            this.BotonEntrenadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonEntrenadores.Size = new System.Drawing.Size(191, 34);
            this.BotonEntrenadores.TabIndex = 10;
            this.BotonEntrenadores.Text = "ENTRENADORES";
            this.BotonEntrenadores.UseVisualStyleBackColor = true;
            this.BotonEntrenadores.Click += new System.EventHandler(this.BotonEntrenadores_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(14, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 12;
            // 
            // PanelSubMedioTrainer
            // 
            this.PanelSubMedioTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelSubMedioTrainer.Controls.Add(this.BotonSubMenuAñadirTrainer);
            this.PanelSubMedioTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMedioTrainer.Location = new System.Drawing.Point(11, 264);
            this.PanelSubMedioTrainer.Name = "PanelSubMedioTrainer";
            this.PanelSubMedioTrainer.Size = new System.Drawing.Size(210, 43);
            this.PanelSubMedioTrainer.TabIndex = 12;
            this.PanelSubMedioTrainer.Visible = false;
            // 
            // BotonSubMenuAñadirTrainer
            // 
            this.BotonSubMenuAñadirTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonSubMenuAñadirTrainer.FlatAppearance.BorderSize = 0;
            this.BotonSubMenuAñadirTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonSubMenuAñadirTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSubMenuAñadirTrainer.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.BotonSubMenuAñadirTrainer.Location = new System.Drawing.Point(0, 0);
            this.BotonSubMenuAñadirTrainer.Name = "BotonSubMenuAñadirTrainer";
            this.BotonSubMenuAñadirTrainer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonSubMenuAñadirTrainer.Size = new System.Drawing.Size(210, 40);
            this.BotonSubMenuAñadirTrainer.TabIndex = 0;
            this.BotonSubMenuAñadirTrainer.Text = "AÑADIR";
            this.BotonSubMenuAñadirTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonSubMenuAñadirTrainer.UseVisualStyleBackColor = true;
            this.BotonSubMenuAñadirTrainer.Click += new System.EventHandler(this.BotonSubMenuAñadirTrainer_Click);
            // 
            // BotonReportes
            // 
            this.BotonReportes.AllowDrop = true;
            this.BotonReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonReportes.FlatAppearance.BorderSize = 0;
            this.BotonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReportes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReportes.Image = ((System.Drawing.Image)(resources.GetObject("BotonReportes.Image")));
            this.BotonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonReportes.Location = new System.Drawing.Point(30, 313);
            this.BotonReportes.Name = "BotonReportes";
            this.BotonReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonReportes.Size = new System.Drawing.Size(191, 34);
            this.BotonReportes.TabIndex = 13;
            this.BotonReportes.Text = "REPORTES";
            this.BotonReportes.UseVisualStyleBackColor = true;
            this.BotonReportes.Click += new System.EventHandler(this.BotonReportes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel4.Location = new System.Drawing.Point(14, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 14;
            // 
            // PanelSubMedioReporte
            // 
            this.PanelSubMedioReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PanelSubMedioReporte.Controls.Add(this.button3);
            this.PanelSubMedioReporte.Controls.Add(this.BotonSubMenuReporteIngreso);
            this.PanelSubMedioReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMedioReporte.Location = new System.Drawing.Point(11, 353);
            this.PanelSubMedioReporte.Name = "PanelSubMedioReporte";
            this.PanelSubMedioReporte.Size = new System.Drawing.Size(210, 43);
            this.PanelSubMedioReporte.TabIndex = 15;
            this.PanelSubMedioReporte.Visible = false;
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(25, 219);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(191, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "REPORTES";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BotonSubMenuReporteIngreso
            // 
            this.BotonSubMenuReporteIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonSubMenuReporteIngreso.FlatAppearance.BorderSize = 0;
            this.BotonSubMenuReporteIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonSubMenuReporteIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSubMenuReporteIngreso.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.BotonSubMenuReporteIngreso.Location = new System.Drawing.Point(0, 0);
            this.BotonSubMenuReporteIngreso.Name = "BotonSubMenuReporteIngreso";
            this.BotonSubMenuReporteIngreso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonSubMenuReporteIngreso.Size = new System.Drawing.Size(210, 40);
            this.BotonSubMenuReporteIngreso.TabIndex = 0;
            this.BotonSubMenuReporteIngreso.Text = "REPORTE INGRESO";
            this.BotonSubMenuReporteIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonSubMenuReporteIngreso.UseVisualStyleBackColor = true;
            // 
            // BotonPagos
            // 
            this.BotonPagos.AllowDrop = true;
            this.BotonPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPagos.FlatAppearance.BorderSize = 0;
            this.BotonPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPagos.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPagos.Image = ((System.Drawing.Image)(resources.GetObject("BotonPagos.Image")));
            this.BotonPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonPagos.Location = new System.Drawing.Point(30, 402);
            this.BotonPagos.Name = "BotonPagos";
            this.BotonPagos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonPagos.Size = new System.Drawing.Size(191, 34);
            this.BotonPagos.TabIndex = 16;
            this.BotonPagos.Text = "PAGOS";
            this.BotonPagos.UseVisualStyleBackColor = true;
            this.BotonPagos.Click += new System.EventHandler(this.BotonPagos_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel6.Location = new System.Drawing.Point(14, 402);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(11, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 46);
            this.panel3.TabIndex = 18;
            this.panel3.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "AÑADIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.MinimumSize = new System.Drawing.Size(950, 600);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1300, 650);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaxVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelSubMenuMedios.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelSubMedioTrainer.ResumeLayout(false);
            this.PanelSubMedioReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BotonMaxVentana;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.PictureBox BotonMinVentana;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BotonClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel MenuVertical;
        private System.Windows.Forms.Button BotonEntrenadores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelSubMenuMedios;
        private System.Windows.Forms.Button BotonSubMenuAñadir;
        private System.Windows.Forms.Panel PanelSubMedioTrainer;
        private System.Windows.Forms.Button BotonSubMenuAñadirTrainer;
        private System.Windows.Forms.Button BotonReportes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelSubMedioReporte;
        private System.Windows.Forms.Button BotonSubMenuReporteIngreso;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BotonPagos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

