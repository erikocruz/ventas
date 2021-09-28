namespace Tienda
{
    partial class formmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ropaParaDamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ropaParaCaballeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ropaParaNiñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeErroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ropaParaDamaToolStripMenuItem,
            this.ropaParaCaballeroToolStripMenuItem,
            this.ropaParaNiñoToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.inventarioToolStripMenuItem.Text = " Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // ropaParaDamaToolStripMenuItem
            // 
            this.ropaParaDamaToolStripMenuItem.Name = "ropaParaDamaToolStripMenuItem";
            this.ropaParaDamaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ropaParaDamaToolStripMenuItem.Text = "Ropa para dama";
            this.ropaParaDamaToolStripMenuItem.Click += new System.EventHandler(this.ropaParaDamaToolStripMenuItem_Click);
            // 
            // ropaParaCaballeroToolStripMenuItem
            // 
            this.ropaParaCaballeroToolStripMenuItem.Name = "ropaParaCaballeroToolStripMenuItem";
            this.ropaParaCaballeroToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ropaParaCaballeroToolStripMenuItem.Text = "Ropa para caballero";
            this.ropaParaCaballeroToolStripMenuItem.Click += new System.EventHandler(this.ropaParaCaballeroToolStripMenuItem_Click);
            // 
            // ropaParaNiñoToolStripMenuItem
            // 
            this.ropaParaNiñoToolStripMenuItem.Name = "ropaParaNiñoToolStripMenuItem";
            this.ropaParaNiñoToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ropaParaNiñoToolStripMenuItem.Text = "Ropa para niño ";
            this.ropaParaNiñoToolStripMenuItem.Click += new System.EventHandler(this.ropaParaNiñoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeInventarioToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeInventarioToolStripMenuItem
            // 
            this.reporteDeInventarioToolStripMenuItem.Name = "reporteDeInventarioToolStripMenuItem";
            this.reporteDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.reporteDeInventarioToolStripMenuItem.Text = "Reporte de inventario";
            this.reporteDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.reporteDeInventarioToolStripMenuItem_Click);
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de clientes";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeErroresToolStripMenuItem,
            this.administrarBaseDeDatosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // reporteDeErroresToolStripMenuItem
            // 
            this.reporteDeErroresToolStripMenuItem.Name = "reporteDeErroresToolStripMenuItem";
            this.reporteDeErroresToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.reporteDeErroresToolStripMenuItem.Text = "Reporte de errores";
            this.reporteDeErroresToolStripMenuItem.Click += new System.EventHandler(this.reporteDeErroresToolStripMenuItem_Click);
            // 
            // administrarBaseDeDatosToolStripMenuItem
            // 
            this.administrarBaseDeDatosToolStripMenuItem.Name = "administrarBaseDeDatosToolStripMenuItem";
            this.administrarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.administrarBaseDeDatosToolStripMenuItem.Text = "Administrar base de datos";
            this.administrarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.administrarBaseDeDatosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formmenu";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.formmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ropaParaDamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ropaParaCaballeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ropaParaNiñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeErroresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
    }
}