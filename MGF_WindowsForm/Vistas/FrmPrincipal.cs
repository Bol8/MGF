using System.Windows.Forms;
using Dominio.Entidades;
using MGF_WindowsForm.Factorias.Ribbon;
using MGF_WindowsForm.Gestion.UI.Clientes;
using MGF_WindowsForm.Modelos.Clientes;

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
            var uscCliente = new UscClientes<Cliente, mCliente>();
            var tab = RibbonTabFactoria.ObtenerTab("Clientes", new TabClienteAdaptador<Cliente,mCliente>(uscCliente));
            ribbon1.Tabs.Add(tab);
            ribbon1.ActiveTab = tab;
           
            PanelPrincipal.Controls.Add(uscCliente);
        }

        #endregion


    }
}
