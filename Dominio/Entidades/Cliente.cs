//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string NIF { get; set; }
        public string Direccion { get; set; }
        public string CP { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Mail { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int IdEstado { get; set; }
    }
}