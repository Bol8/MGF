using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewUtilities.Manage;
using Dominio.Entidades;
using MGF_WindowsForm.Interfaces;
using MGF_WindowsForm.Modelos.Clientes;

namespace MGF_WindowsForm.Vistas
{
    public sealed partial class UscClientes<TEntity, TModel> : UserControl, IUscPrincipal<TEntity,TModel> where TModel : new()
    {
        private readonly DataGridViewControlador<TModel, TEntity> _dtgClienteControlador;

        public UscClientes()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _dtgClienteControlador = new DataGridViewControlador<TModel, TEntity>(dtgCliente);
            
        }


        #region Eventos DataGridView

        private void dtgCliente_Resize(object sender, EventArgs e)
        {
            DataGridViewOperations.AutoSizeLastColumn(dtgCliente);
        }

        private void dtgCliente_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridViewOperations.AutoSizeLastColumn(dtgCliente);
        }

        #endregion


        public TModel ObtenerElemento()
        {
          return _dtgClienteControlador.ObtenerElemento();
        }

        public void CargarElementos(IEnumerable<TEntity> elementos)
        {
            _dtgClienteControlador.CargarDatos(elementos);
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }
    }
}
