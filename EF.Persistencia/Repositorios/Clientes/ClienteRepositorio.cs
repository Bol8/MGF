using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
using Dominio.ServiciosRepositorios.Clientes;
using GenericRepository.Interfaces;

namespace EF.Persistencia.Repositorios.Clientes
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IGenericRepository<Cliente> _contexto;

        public ClienteRepositorio(IGenericRepository<Cliente> contexto)
        {
            _contexto = contexto;
        }

        public Cliente ObtenerElemento(int id)
        {
            return _contexto.FindBy(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Cliente> ObtenerElementos()
        {
            return _contexto.GetAll();
        }

        public IEnumerable<Cliente> ObtenerElementos(int[] ids)
        {
            return _contexto.FindBy(x => ids.Contains(x.Id));
        }

        public void Añadir(Cliente elemento)
        {
            _contexto.Add(elemento);
        }

        public void Editar(Cliente elemento)
        {
            _contexto.Edit(elemento);
        }

        public void Eliminar(int id)
        {
            var elemento = ObtenerElemento(id);
            if(elemento == null)
                throw new NullReferenceException("El registro que se está intentando eliminar no existe");

           _contexto.Delete(elemento);
        }

        public void Eliminar(Cliente elemento)
        {
            _contexto.Delete(elemento);
        }
    }
}