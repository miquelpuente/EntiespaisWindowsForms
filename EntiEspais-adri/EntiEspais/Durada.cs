//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntiEspais
{
    using System;
    using System.Collections.Generic;
    
    public partial class Durada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Durada()
        {
            this.Horari = new HashSet<Horari>();
        }
    
        public int id { get; set; }
        public System.TimeSpan horaInici { get; set; }
        public System.TimeSpan horaFinalitzacio { get; set; }
        public int id_actividadDemandada { get; set; }
    
        public virtual ActivitatsDemanades ActivitatsDemanades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari> Horari { get; set; }
    }
}
