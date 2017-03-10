using DataModel;
using System;
using System.Collections.Generic;

namespace BusinessEntities
{
    public partial class ItemEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemEntity()
        {
            this.Registro = new HashSet<Registro>();
        }

        public int IdItem { get; set; }
        public string Placa { get; set; }
        public string Informacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdDocumento { get; set; }
        public Nullable<int> IdTipo { get; set; }

        public virtual Documento Documento { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }
    }
}
