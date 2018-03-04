using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridViewUtilities.Attributes;
using DataGridViewUtilities.Attributes.Enums;

namespace MGF_WindowsForm.Modelos.Clientes
{
    public class mCliente
    {
        [Display(Name = @"Id")]
        [CustomFilterable(false)]
        [CustomVisible(false)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public int Id { get; set; }

        [Display(Name = @"Nombre Fiscal")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string RazonSocial { get; set; }

        [Display(Name = @"Nombre Comercial")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string NombreComercial { get; set; }

        [Display(Name = @"NIF")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string NIF { get; set; }

        [Display(Name = @"Dirección")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Direccion { get; set; }

        [Display(Name = @"CP")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string CP { get; set; }

        [Display(Name = @"Población")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Poblacion { get; set; }

        [Display(Name = @"Provincia")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Provincia { get; set; }

        [Display(Name = @"País")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Pais { get; set; }

        [Display(Name = @"Teléfono")]
        [CustomFilterable(false)]
        [CustomVisible(false)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Telefono { get; set; }

        [Display(Name = @"Móvil")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Movil { get; set; }

        [Display(Name = @"Mail")]
        [CustomFilterable(true)]
        [CustomVisible(true)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Mail { get; set; }

        [Display(Name = @"Observaciones")]
        [CustomFilterable(false)]
        [CustomVisible(false)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public string Observaciones { get; set; }

        [Display(Name = @"Fecha Alta")]
        [CustomFilterable(false)]
        [CustomVisible(false)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public DateTime FechaAlta { get; set; }

        [Display(Name = @"Estado")]
        [CustomFilterable(false)]
        [CustomVisible(false)]
        [CustomDataGridViewColumType(DataGridViewColumnEnum.DataGridViewTextBoxColumn)]
        public int IdEstado { get; set; }
    }
}
