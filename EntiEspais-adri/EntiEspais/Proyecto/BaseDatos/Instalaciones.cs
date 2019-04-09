using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.Proyecto.BaseDatos
{    
   public static class Instalaciones
    {
        private static String mensaje = "";

        public static List<Instal_lacio>selectAllInstalaciones(){
            List<Instal_lacio> listaInstalaciones =
                (from instalacion in BD.bd.Instal_lacio
                 orderby instalacion.id
                 select instalacion
                ).ToList();
            return listaInstalaciones;
        }

        /// <summary>
        /// Borramos una instalación y contralamos un posible error pasando este mismo para poder saber de que exception de SQL se trata.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public static String deleteInstalacion(Instal_lacio instal_Lacio) {
            BD.bd.Instal_lacio.Remove(instal_Lacio);
            mensaje = BD.SaveChanges();
            return mensaje;

        }
    }

}
