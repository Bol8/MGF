namespace MGF_WindowsForm.Vistas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.TabVentas = new System.Windows.Forms.RibbonTab();
            this.RbPanelDocVentas = new System.Windows.Forms.RibbonPanel();
            this.BtnPresupuestos = new System.Windows.Forms.RibbonButton();
            this.BtnAlbaranesCli = new System.Windows.Forms.RibbonButton();
            this.BtnFacturasCli = new System.Windows.Forms.RibbonButton();
            this.RbPanelClientesVentas = new System.Windows.Forms.RibbonPanel();
            this.BtnClientes = new System.Windows.Forms.RibbonButton();
            this.RbPanelComercialVentas = new System.Windows.Forms.RibbonPanel();
            this.BtnAgentes = new System.Windows.Forms.RibbonButton();
            this.TabCompras = new System.Windows.Forms.RibbonTab();
            this.RbPanelDocCompras = new System.Windows.Forms.RibbonPanel();
            this.BtnPedidosProveedor = new System.Windows.Forms.RibbonButton();
            this.BtnEntradas = new System.Windows.Forms.RibbonButton();
            this.BtnFacturas = new System.Windows.Forms.RibbonButton();
            this.BtnDevoluciones = new System.Windows.Forms.RibbonButton();
            this.RbPanelProveedores = new System.Windows.Forms.RibbonPanel();
            this.BtnProveedores = new System.Windows.Forms.RibbonButton();
            this.BtnRepresentantes = new System.Windows.Forms.RibbonButton();
            this.TabAlmacen = new System.Windows.Forms.RibbonTab();
            this.RbPanelArticulos = new System.Windows.Forms.RibbonPanel();
            this.BtnArticulos = new System.Windows.Forms.RibbonButton();
            this.RbExistencias = new System.Windows.Forms.RibbonPanel();
            this.BtnEntradasSalidas = new System.Windows.Forms.RibbonButton();
            this.TabAdministracion = new System.Windows.Forms.RibbonTab();
            this.TabInformes = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.BtnAlbaranes = new System.Windows.Forms.RibbonButton();
            this.BtnPedidosCli = new System.Windows.Forms.RibbonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = null;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = null;
            // 
            // TabVentas
            // 
            this.TabVentas.Panels.Add(this.RbPanelDocVentas);
            this.TabVentas.Panels.Add(this.RbPanelClientesVentas);
            this.TabVentas.Panels.Add(this.RbPanelComercialVentas);
            this.TabVentas.Text = "Ventas";
            // 
            // RbPanelDocVentas
            // 
            this.RbPanelDocVentas.Items.Add(this.BtnPresupuestos);
            this.RbPanelDocVentas.Items.Add(this.BtnPedidosCli);
            this.RbPanelDocVentas.Items.Add(this.BtnAlbaranesCli);
            this.RbPanelDocVentas.Items.Add(this.BtnFacturasCli);
            this.RbPanelDocVentas.Text = "Documentos";
            // 
            // BtnPresupuestos
            // 
            this.BtnPresupuestos.Image = global::MGF_WindowsForm.Properties.Resources.Presupuesto;
            this.BtnPresupuestos.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnPresupuestos.SmallImage")));
            this.BtnPresupuestos.Text = "Presupuestos";
            // 
            // BtnAlbaranesCli
            // 
            this.BtnAlbaranesCli.Image = global::MGF_WindowsForm.Properties.Resources.Albarán;
            this.BtnAlbaranesCli.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnAlbaranesCli.SmallImage")));
            this.BtnAlbaranesCli.Text = "Albaranes";
            // 
            // BtnFacturasCli
            // 
            this.BtnFacturasCli.Image = global::MGF_WindowsForm.Properties.Resources.Factura_emitida;
            this.BtnFacturasCli.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnFacturasCli.SmallImage")));
            this.BtnFacturasCli.Text = "Facturas";
            // 
            // RbPanelClientesVentas
            // 
            this.RbPanelClientesVentas.Items.Add(this.BtnClientes);
            this.RbPanelClientesVentas.Text = "Clientes";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Image = global::MGF_WindowsForm.Properties.Resources.Clientes;
            this.BtnClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnClientes.SmallImage")));
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // RbPanelComercialVentas
            // 
            this.RbPanelComercialVentas.Items.Add(this.BtnAgentes);
            this.RbPanelComercialVentas.Text = "Comercial";
            // 
            // BtnAgentes
            // 
            this.BtnAgentes.Image = global::MGF_WindowsForm.Properties.Resources.Usuario;
            this.BtnAgentes.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnAgentes.SmallImage")));
            this.BtnAgentes.Text = "Agentes";
            // 
            // TabCompras
            // 
            this.TabCompras.Panels.Add(this.RbPanelDocCompras);
            this.TabCompras.Panels.Add(this.RbPanelProveedores);
            this.TabCompras.Text = "Compras";
            // 
            // RbPanelDocCompras
            // 
            this.RbPanelDocCompras.Items.Add(this.BtnPedidosProveedor);
            this.RbPanelDocCompras.Items.Add(this.BtnEntradas);
            this.RbPanelDocCompras.Items.Add(this.BtnFacturas);
            this.RbPanelDocCompras.Items.Add(this.BtnDevoluciones);
            this.RbPanelDocCompras.Text = "Documentos";
            // 
            // BtnPedidosProveedor
            // 
            this.BtnPedidosProveedor.Image = global::MGF_WindowsForm.Properties.Resources.Pedido_a_proveedores;
            this.BtnPedidosProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnPedidosProveedor.SmallImage")));
            this.BtnPedidosProveedor.Text = "Pedidos a Proveedores";
            // 
            // BtnEntradas
            // 
            this.BtnEntradas.Image = global::MGF_WindowsForm.Properties.Resources.Entrada_de_mercancía;
            this.BtnEntradas.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEntradas.SmallImage")));
            this.BtnEntradas.Text = "Entradas";
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.Image = global::MGF_WindowsForm.Properties.Resources.Factura_recibida;
            this.BtnFacturas.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnFacturas.SmallImage")));
            this.BtnFacturas.Text = "Facturas";
            // 
            // BtnDevoluciones
            // 
            this.BtnDevoluciones.Image = global::MGF_WindowsForm.Properties.Resources.Devolución;
            this.BtnDevoluciones.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnDevoluciones.SmallImage")));
            this.BtnDevoluciones.Text = "Devoluciones";
            // 
            // RbPanelProveedores
            // 
            this.RbPanelProveedores.Items.Add(this.BtnProveedores);
            this.RbPanelProveedores.Items.Add(this.BtnRepresentantes);
            this.RbPanelProveedores.Text = "Proveedores";
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Image = global::MGF_WindowsForm.Properties.Resources.Proveedor;
            this.BtnProveedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnProveedores.SmallImage")));
            this.BtnProveedores.Text = "Proveedores";
            // 
            // BtnRepresentantes
            // 
            this.BtnRepresentantes.Image = global::MGF_WindowsForm.Properties.Resources.Representantes;
            this.BtnRepresentantes.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnRepresentantes.SmallImage")));
            this.BtnRepresentantes.Text = "Representantes";
            // 
            // TabAlmacen
            // 
            this.TabAlmacen.Panels.Add(this.RbPanelArticulos);
            this.TabAlmacen.Panels.Add(this.RbExistencias);
            this.TabAlmacen.Text = "Almacén";
            // 
            // RbPanelArticulos
            // 
            this.RbPanelArticulos.Items.Add(this.BtnArticulos);
            this.RbPanelArticulos.Text = "Articulos";
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Image = global::MGF_WindowsForm.Properties.Resources.Artículos;
            this.BtnArticulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnArticulos.SmallImage")));
            this.BtnArticulos.Text = "Articulos";
            // 
            // RbExistencias
            // 
            this.RbExistencias.Items.Add(this.BtnEntradasSalidas);
            this.RbExistencias.Text = "Existencias";
            // 
            // BtnEntradasSalidas
            // 
            this.BtnEntradasSalidas.Image = global::MGF_WindowsForm.Properties.Resources.Entradas_y_salidas_de_artículos;
            this.BtnEntradasSalidas.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEntradasSalidas.SmallImage")));
            this.BtnEntradasSalidas.Text = "Entradas y salidas";
            // 
            // TabAdministracion
            // 
            this.TabAdministracion.Text = "Administracion";
            // 
            // TabInformes
            // 
            this.TabInformes.Text = "Informes";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Text = null;
            // 
            // ribbon1
            // 
            this.ribbon1.AllowDrop = true;
            this.ribbon1.BackColor = System.Drawing.SystemColors.Window;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Archivo";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1260, 163);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.TabVentas);
            this.ribbon1.Tabs.Add(this.TabCompras);
            this.ribbon1.Tabs.Add(this.TabAlmacen);
            this.ribbon1.Tabs.Add(this.TabAdministracion);
            this.ribbon1.Tabs.Add(this.TabInformes);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PanelPrincipal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1260, 543);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // BtnAlbaranes
            // 
            this.BtnAlbaranes.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlbaranes.Image")));
            this.BtnAlbaranes.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnAlbaranes.SmallImage")));
            this.BtnAlbaranes.Text = "Albaranes";
            // 
            // BtnPedidosCli
            // 
            this.BtnPedidosCli.Image = global::MGF_WindowsForm.Properties.Resources.Pedido_de_clientes;
            this.BtnPedidosCli.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnPedidosCli.SmallImage")));
            this.BtnPedidosCli.Text = "Pedidos de Clientes";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab TabVentas;
        private System.Windows.Forms.RibbonTab TabCompras;
        private System.Windows.Forms.RibbonTab TabAlmacen;
        private System.Windows.Forms.RibbonTab TabAdministracion;
        private System.Windows.Forms.RibbonTab TabInformes;
        private System.Windows.Forms.RibbonPanel RbPanelDocVentas;
        private System.Windows.Forms.RibbonButton BtnPresupuestos;
        private System.Windows.Forms.RibbonPanel RbPanelClientesVentas;
        private System.Windows.Forms.RibbonButton BtnClientes;
        private System.Windows.Forms.RibbonPanel RbPanelComercialVentas;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton BtnAlbaranes;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton BtnAlbaranesCli;
        private System.Windows.Forms.RibbonButton BtnFacturasCli;
        private System.Windows.Forms.RibbonButton BtnAgentes;
        private System.Windows.Forms.RibbonPanel RbPanelDocCompras;
        private System.Windows.Forms.RibbonPanel RbPanelProveedores;
        private System.Windows.Forms.RibbonButton BtnPedidosProveedor;
        private System.Windows.Forms.RibbonButton BtnEntradas;
        private System.Windows.Forms.RibbonButton BtnFacturas;
        private System.Windows.Forms.RibbonButton BtnDevoluciones;
        private System.Windows.Forms.RibbonButton BtnProveedores;
        private System.Windows.Forms.RibbonButton BtnRepresentantes;
        private System.Windows.Forms.RibbonPanel RbPanelArticulos;
        private System.Windows.Forms.RibbonPanel RbExistencias;
        private System.Windows.Forms.RibbonButton BtnArticulos;
        private System.Windows.Forms.RibbonButton BtnEntradasSalidas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.RibbonButton BtnPedidosCli;
    }
}

