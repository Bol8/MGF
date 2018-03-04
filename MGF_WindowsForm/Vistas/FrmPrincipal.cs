using System.Windows.Forms;
using MGF_WindowsForm.Factorias.Ribbon;
using MGF_WindowsForm.Gestion.UI.Clientes;

namespace MGF_WindowsForm.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }




        #region Eventos Botones

        private void BtnClientes_Click(object sender, System.EventArgs e)
        {
            var tab = RibbonTabFactoria.ObtenerTab("Clientes", new TabClienteGestor());
            ribbon1.Tabs.Add(tab);
            ribbon1.ActiveTab = tab;
            var uscCliente = new UscClientes();
            PanelPrincipal.Controls.Add(uscCliente);
        }

        #endregion


    }
}
