using System.Windows.Forms;
using MGF_WindowsForm.Interfaces;
using MGF_WindowsForm.Vistas;

namespace MGF_WindowsForm.Factorias.Ribbon
{
    public class RibbonPanelFactoria
    {

        public static RibbonPanel ObtenerPanelDocumentos(IPanelDocGestor panelDocGestor)
        {
            var panel = new RibbonPanel("Documentos");

            var btnNuevo = new RibbonButton("Nuevo") {Image = Properties.Resources.Nuevo};
            btnNuevo.Click += panelDocGestor.BtnNuevo_Click;

            var btnDuplicar = new RibbonButton("Duplicar"){Image = Properties.Resources.Duplicar};
            btnDuplicar.Click += panelDocGestor.BtnDuplicar_Click;

            var btnModificar = new RibbonButton("Modificar") { Image = Properties.Resources.Modificar };
            btnModificar.Click += panelDocGestor.BtnModificar_Click;

            var btnEliminar = new RibbonButton("Eliminar") { Image = Properties.Resources.Borrar };
            btnEliminar.Click += panelDocGestor.BtnEliminar_Click;

            panel.Items.Add(btnNuevo);
            panel.Items.Add(btnDuplicar);
            panel.Items.Add(btnModificar);
            panel.Items.Add(btnEliminar);

            return panel;
        }
    }
}