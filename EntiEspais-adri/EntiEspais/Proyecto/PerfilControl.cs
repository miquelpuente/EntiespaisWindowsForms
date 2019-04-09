using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Plantilla
{
    public partial class PerfilControl : UserControl
         
    {
        public PerfilControl()
        {
            InitializeComponent();
     
        }

        private void PerfilControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarPerfilControl a = new EditarPerfilControl();
            this.Controls.Add(a);
            a.BringToFront();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result;
            //preguntamos si desea cerrar sesión
            result = MessageBox.Show("Desitges tancar sessió?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Cerramos la sesion
                Plantilla.ActiveForm.Close();

                IniciarSesio a = new IniciarSesio();
                a.Show();
            }
        }
    }
}
