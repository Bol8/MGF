using System;

namespace MGF_WindowsForm.Interfaces
{
    public interface IPanelDocGestor
    {
        void BtnNuevo_Click(object sender, EventArgs e);
        void BtnDuplicar_Click(object sender, EventArgs e);
        void BtnModificar_Click(object sender, EventArgs e);
        void BtnEliminar_Click(object sender, EventArgs e);
    }
}