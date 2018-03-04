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
using MGF_WindowsForm.Modelos.Clientes;

namespace MGF_WindowsForm.Vistas
{
    public sealed partial class UscClientes : UserControl
    {
        private readonly DataGridViewControlador<mCliente, Cliente> _dtgClienteControlador;

        public UscClientes()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _dtgClienteControlador = new DataGridViewControlador<mCliente, Cliente>(dtgCliente);
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


    }
}
