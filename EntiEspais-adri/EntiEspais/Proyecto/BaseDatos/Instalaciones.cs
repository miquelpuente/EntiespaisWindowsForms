using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.Proyecto.BaseDatos
{
   public static class Instalaciones
    {

        public static List<Instal_lacio>selectAllInstalaciones(){
            List<Instal_lacio> listaInstalaciones =
                (from instalacion in BD.bd.Instal_lacio
                 orderby instalacion.id
                 select instalacion
                ).ToList();
            return listaInstalaciones;
        }
    }
}
