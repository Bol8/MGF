using System.Data.Entity;
using Dominio.Entidades;
using Dominio.ServiciosRepositorios.Clientes;
using EF.Persistencia.Contexto;
using EF.Persistencia.Repositorios.Clientes;
using GenericRepository;
using GenericRepository.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace MGF_WindowsForm.Gestion.Inyectores
{
    public static class Contenedor
    {
        private static readonly Container _container;

        static Contenedor()
        {
            _container = new Container();

            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            //cargamos el Contexto
            _container.Register<DbContext,MGFEntities>(Lifestyle.Scoped);

           

            _container.Register<IGenericRepository<Cliente>, GenericRepository<Cliente>>(Lifestyle.Scoped);
            _container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Scoped);


            _container.Verify();
        }


        public static TService ObtenerInstancia<TService>() where TService : class
        {
            return _container.GetInstance<TService>();
        }
    }
}