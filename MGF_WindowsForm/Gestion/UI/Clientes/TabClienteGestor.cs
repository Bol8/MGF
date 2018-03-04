using System;
using MGF_WindowsForm.Interfaces;
using MGF_WindowsForm.Vistas;

namespace MGF_WindowsForm.Gestion.UI.Clientes
{
    public class TabClienteGestor : IPanelDocGestor
    {


        public void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmCliente();
            frm.Show();
        }

        public void BtnDuplicar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void BtnModificar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void BtnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}