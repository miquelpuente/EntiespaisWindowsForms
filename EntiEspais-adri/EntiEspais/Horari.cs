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
    
    public partial class Horari
    {
        public int id { get; set; }
        public int id_dia { get; set; }
        public int id_durada { get; set; }
        public int id_activitat_concedida { get; set; }
    
        public virtual ActivitatsConcedides ActivitatsConcedides { get; set; }
        public virtual Dia Dia { get; set; }
        public virtual Durada Durada { get; set; }
    }
}
