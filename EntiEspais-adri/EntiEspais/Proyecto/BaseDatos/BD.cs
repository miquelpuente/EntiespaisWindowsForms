using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Proyecto
{
   public static  class BD
    {
        public static EntiEspaisEntities bd = new EntiEspaisEntities();


        public static void cargarInstalaciones(BindingSource binding) {
            binding.DataSource = BaseDatos.Instalaciones.selectAllInstalaciones();
        }

        public static void cargarEntidades(BindingSource binding) {
            binding.DataSource = BaseDatos.Entidades.selectAllEntidades();
        }
    }
}
