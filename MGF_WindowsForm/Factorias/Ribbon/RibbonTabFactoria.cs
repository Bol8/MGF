using System.Windows.Forms;
using MGF_WindowsForm.Interfaces;

namespace MGF_WindowsForm.Factorias.Ribbon
{
    public class RibbonTabFactoria
    {
        public static RibbonTab ObtenerTab(string nombre,IPanelDocGestor panelDocGestor)
        {
            var panel = RibbonPanelFactoria.ObtenerPanelDocumentos(panelDocGestor);
            var tab = new RibbonTab(nombre);

            tab.Panels.Add(panel);
           
            return tab;
        }
    }
}