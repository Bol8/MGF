namespace MGF_WindowsForm.Vistas
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.TabCliente = new System.Windows.Forms.RibbonTab();
            this.RbPanelMantenimiento = new System.Windows.Forms.RibbonPanel();
            this.BtnGuardarYCerrar = new System.Windows.Forms.RibbonButton();
            this.BtnEliminar = new System.Windows.Forms.RibbonButton();
            this.BtnGuardaYNuevo = new System.Windows.Forms.RibbonButton();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(771, 154);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.TabCliente);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 10, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // TabCliente
            // 
            this.TabCliente.Panels.Add(this.RbPanelMantenimiento);
            this.TabCliente.Text = "Cliente";
            // 
            // RbPanelMantenimiento
            // 
            this.RbPanelMantenimiento.Items.Add(this.BtnGuardarYCerrar);
            this.RbPanelMantenimiento.Items.Add(this.BtnEliminar);
            this.RbPanelMantenimiento.Items.Add(this.BtnGuardaYNuevo);
            this.RbPanelMantenimiento.Text = "Mantenimiento";
            // 
            // BtnGuardarYCerrar
            // 
            this.BtnGuardarYCerrar.Image = global::MGF_WindowsForm.Properties.Resources.Guardar_y_cerrar;
            this.BtnGuardarYCerrar.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarYCerrar.SmallImage")));
            this.BtnGuardarYCerrar.Text = "Guardar y Cerrar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = global::MGF_WindowsForm.Properties.Resources.Borrar;
            this.BtnEliminar.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.SmallImage")));
            this.BtnEliminar.Text = "Eliminar";
            // 
            // BtnGuardaYNuevo
            // 
            this.BtnGuardaYNuevo.Image = global::MGF_WindowsForm.Properties.Resources.Guardar_y_nuevo;
            this.BtnGuardaYNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardaYNuevo.SmallImage")));
            this.BtnGuardaYNuevo.Text = "Guardar y Nuevo";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 154);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(771, 407);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab TabCliente;
        private System.Windows.Forms.RibbonPanel RbPanelMantenimiento;
        private System.Windows.Forms.RibbonButton BtnGuardarYCerrar;
        private System.Windows.Forms.RibbonButton BtnEliminar;
        private System.Windows.Forms.RibbonButton BtnGuardaYNuevo;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}