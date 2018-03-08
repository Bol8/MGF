using System.Collections.Generic;
using Dominio.Entidades;

namespace Dominio.ServiciosRepositorios.Clientes
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerElemento(int id);
        IEnumerable<Cliente> ObtenerElementos();
        IEnumerable<Cliente> ObtenerElementos(int[] ids);
        void Añadir(Cliente elemento);
        void Editar(Cliente elemento);
        void Eliminar(int id);
        void Eliminar(Cliente elemento);
    }
}