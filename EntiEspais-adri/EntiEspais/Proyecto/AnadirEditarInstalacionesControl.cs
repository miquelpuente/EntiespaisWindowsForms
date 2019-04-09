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
    public partial class AnadirEditarInstalacionesControl : UserControl
    {
        public AnadirEditarInstalacionesControl()
        {
            InitializeComponent();

            
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //this.Hide();


            DialogResult result;
            //preguntamos si desea cancelar los cambios que ha realizado en el formulario editar
            result = MessageBox.Show("Desitges cancel·lar els canvis?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Cerramos el formulario y volvemos al formulario anterior

                this.Parent.Controls.Remove(this);
            }
        }

        
    }
}
