using System;
using MGF_WindowsForm.Interfaces;
using MGF_WindowsForm.Vistas;

namespace MGF_WindowsForm.Gestion.UI.Clientes
{
    public class TabClienteAdaptador<TEntity,TModel> : IPanelDocGestor
    {
        private readonly IUscPrincipal<TEntity,TModel> _uscPrincipal;

        public TabClienteAdaptador(IUscPrincipal<TEntity,TModel> uscPrincipal)
        {
            _uscPrincipal = uscPrincipal;
        }

        public void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmCliente();
            frm.Show();
        }

        public void BtnDuplicar_Click(object sender, EventArgs e)
        {
            var elemento = _uscPrincipal.ObtenerElemento();
        }

        public void BtnModificar_Click(object sender, EventArgs e)
        {
            var elemento = _uscPrincipal.ObtenerElemento();
        }

        public void BtnEliminar_Click(object sender, EventArgs e)
        {
            var elemento = _uscPrincipal.ObtenerElemento();
        }
    }
}