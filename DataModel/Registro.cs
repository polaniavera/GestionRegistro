//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro
    {
        public int IdRegistro { get; set; }
        public Nullable<decimal> Latitud { get; set; }
        public Nullable<decimal> Longitud { get; set; }
        public Nullable<decimal> TanqueConductor { get; set; }
        public Nullable<decimal> TanquePasajero { get; set; }
        public Nullable<bool> BotonPanico { get; set; }
        public Nullable<decimal> Kilometraje { get; set; }
        public Nullable<decimal> Velocidad { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdItem { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
