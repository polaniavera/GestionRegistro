using DataModel;
using System;

namespace BusinessEntities
{
    public partial class RegistroEntity
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
