using System.Collections.Generic;

namespace MGF_WindowsForm.Interfaces
{
    public interface IUscPrincipal<in TEntity, out TModel>
    {
        TModel ObtenerElemento();
        void CargarElementos(IEnumerable<TEntity> elementos);
        void Actualizar();

    }
}