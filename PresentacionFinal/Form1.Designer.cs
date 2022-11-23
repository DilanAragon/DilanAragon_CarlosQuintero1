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
            this.BotonEntrenadores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonReportes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelSubMenuReporte = new System.Windows.Forms.Panel();
            this.BotonReporteMensualidad = new System.Windows.Forms.Button();
            this.BotonReporteCliente = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaxVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelSubMenuReporte.SuspendLayout();
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
            this.MenuVertical.AutoSize = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(68)))), ((int)(((byte)(67)))));
            this.MenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuVertical.Controls.Add(this.PbLogo);
            this.MenuVertical.Controls.Add(this.BotonClientes);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.BotonEntrenadores);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.BotonReportes);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.PanelSubMenuReporte);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(226, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // PbLogo
            // 
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
            this.BotonEntrenadores.Location = new System.Drawing.Point(30, 173);
            this.BotonEntrenadores.Name = "BotonEntrenadores";
            this.BotonEntrenadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonEntrenadores.Size = new System.Drawing.Size(191, 34);
            this.BotonEntrenadores.TabIndex = 3;
            this.BotonEntrenadores.Text = "ENTRENADORES";
            this.BotonEntrenadores.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel2.Location = new System.Drawing.Point(14, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 4;
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
            this.BotonReportes.Location = new System.Drawing.Point(30, 213);
            this.BotonReportes.Name = "BotonReportes";
            this.BotonReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonReportes.Size = new System.Drawing.Size(191, 34);
            this.BotonReportes.TabIndex = 5;
            this.BotonReportes.Text = "REPORTES";
            this.BotonReportes.UseVisualStyleBackColor = true;
            this.BotonReportes.Click += new System.EventHandler(this.BotonReportes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel3.Location = new System.Drawing.Point(14, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 6;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1300, 650);
            this.PanelContenedor.TabIndex = 2;
            // 
            // PanelSubMenuReporte
            // 
            this.PanelSubMenuReporte.Controls.Add(this.panel6);
            this.PanelSubMenuReporte.Controls.Add(this.BotonReporteCliente);
            this.PanelSubMenuReporte.Controls.Add(this.BotonReporteMensualidad);
            this.PanelSubMenuReporte.Controls.Add(this.panel5);
            this.PanelSubMenuReporte.Location = new System.Drawing.Point(51, 253);
            this.PanelSubMenuReporte.Name = "PanelSubMenuReporte";
            this.PanelSubMenuReporte.Size = new System.Drawing.Size(170, 82);
            this.PanelSubMenuReporte.TabIndex = 7;
            this.PanelSubMenuReporte.Visible = false;
            this.PanelSubMenuReporte.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSubMenuReporte_Paint);
            // 
            // BotonReporteMensualidad
            // 
            this.BotonReporteMensualidad.AllowDrop = true;
            this.BotonReporteMensualidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonReporteMensualidad.FlatAppearance.BorderSize = 0;
            this.BotonReporteMensualidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonReporteMensualidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReporteMensualidad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReporteMensualidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonReporteMensualidad.Location = new System.Drawing.Point(19, 8);
            this.BotonReporteMensualidad.Name = "BotonReporteMensualidad";
            this.BotonReporteMensualidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonReporteMensualidad.Size = new System.Drawing.Size(148, 31);
            this.BotonReporteMensualidad.TabIndex = 8;
            this.BotonReporteMensualidad.Text = "REPORTE INGRESOS";
            this.BotonReporteMensualidad.UseVisualStyleBackColor = true;
            this.BotonReporteMensualidad.Click += new System.EventHandler(this.BotonReporteMensualidad_Click);
            // 
            // BotonReporteCliente
            // 
            this.BotonReporteCliente.AllowDrop = true;
            this.BotonReporteCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonReporteCliente.FlatAppearance.BorderSize = 0;
            this.BotonReporteCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.BotonReporteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReporteCliente.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReporteCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonReporteCliente.Location = new System.Drawing.Point(19, 45);
            this.BotonReporteCliente.Name = "BotonReporteCliente";
            this.BotonReporteCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonReporteCliente.Size = new System.Drawing.Size(148, 31);
            this.BotonReporteCliente.TabIndex = 9;
            this.BotonReporteCliente.Text = "REPORTE CLIENTE";
            this.BotonReporteCliente.UseVisualStyleBackColor = true;
            this.BotonReporteCliente.Click += new System.EventHandler(this.BotonReporteCliente_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel5.Location = new System.Drawing.Point(3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(132)))), ((int)(((byte)(146)))));
            this.panel6.Location = new System.Drawing.Point(3, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 9;
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
            this.PanelSubMenuReporte.ResumeLayout(false);
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
        private System.Windows.Forms.Button BotonEntrenadores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonReportes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel MenuVertical;
        private System.Windows.Forms.Panel PanelSubMenuReporte;
        private System.Windows.Forms.Button BotonReporteCliente;
        private System.Windows.Forms.Button BotonReporteMensualidad;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

