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
    
    public partial class Dia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dia()
        {
            this.Horari_activitat = new HashSet<Horari_activitat>();
            this.Horari_ActivitatDemanda = new HashSet<Horari_ActivitatDemanda>();
            this.Horari = new HashSet<Horari>();
            this.Horari_Instal_lacio = new HashSet<Horari_Instal_lacio>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public int id_actividadDemandada { get; set; }
    
        public virtual ActivitatsDemanades ActivitatsDemanades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari_activitat> Horari_activitat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari_ActivitatDemanda> Horari_ActivitatDemanda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari> Horari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari_Instal_lacio> Horari_Instal_lacio { get; set; }
    }
}
