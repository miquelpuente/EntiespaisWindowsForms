using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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


        /// <summary>
        /// Método el cuál nos ayuda a conocer nuestra Excepción con un mensaje, esto nos obliga a que nuestros métodos que no devolvian nada 
        /// ahora devuelvan un String con el mensaje correspondiente a la Excepción.
        /// </summary>
        /// <param name="sqlex"></param>
        /// <returns></returns>
        public static String mensajesExceptions(SqlException sqlex)
        {

            string mensaje;
            switch (sqlex.Number)
            {
                case -1:
                    mensaje = "Error de conexión con el servidor";
                    break;
                case 547:
                    mensaje = "Tienes datos relacionados";
                    break;
                case 2601:
                    mensaje = "Datos duplicados";
                    break;
                case 2627:
                    mensaje = "Datos duplicados";
                    break;
                case 4060:
                    mensaje = "No se encuentra la base de datos";
                    break;
                case 18456:
                    mensaje = "Usuario o contraseña incorrectos";
                    break;
                default:
                    mensaje = sqlex.Number + " - " + sqlex.Message;
                    break;
            }
            return mensaje;
        }

        /// <summary>
        /// Este método hace un "revert" de los cambios que hayamos podido realizar a la hora de ejecutar cualquier instrucción CRUD.
        /// </summary>
        public static void rejectChanges()
        {

            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {

                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        break;
                    default:
                        break;
                }
            }
        }


        /// <summary>
        /// Guarda los cambios que hayamos podido realizar en la BD llamando así mismo a la funcion SaveChanges().
        /// </summary>
        /// <returns></returns>
        public static String SaveChanges()
        {

            String mensaje = "";
            try
            {
                BD.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                rejectChanges();
                SqlException sqlexc = (SqlException)ex.InnerException.InnerException;
                mensaje = mensajesExceptions(sqlexc);
            }
            return mensaje;
        }
    }
}
