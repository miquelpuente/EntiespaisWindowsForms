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
    
    public partial class ActivitatsDemanades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivitatsDemanades()
        {
            this.Dia = new HashSet<Dia>();
            this.Durada = new HashSet<Durada>();
            this.Horari_ActivitatDemanda = new HashSet<Horari_ActivitatDemanda>();
        }
    
        public int id { get; set; }
        public byte competicio { get; set; }
        public byte asignada { get; set; }
        public int id_espai { get; set; }
        public int id_equip { get; set; }
        public System.TimeSpan intervalHores { get; set; }
        public System.DateTime diesSetmanaAdients { get; set; }
    
        public virtual ActivitatsConcedides ActivitatsConcedides { get; set; }
        public virtual Equip Equip { get; set; }
        public virtual Espai Espai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dia> Dia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Durada> Durada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horari_ActivitatDemanda> Horari_ActivitatDemanda { get; set; }
    }
}
