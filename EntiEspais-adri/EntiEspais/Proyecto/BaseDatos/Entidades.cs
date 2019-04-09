using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.Proyecto.BaseDatos
{
    public static class Entidades
    {
        public static List<Entitat> selectAllEntidades() {

            List<Entitat> listaEntidades =
                (from entidad in BD.bd.Entitat
                 orderby entidad.nom
                 select entidad
                ).ToList();
            return listaEntidades;
        }
    }
}
