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
    public partial class InstallacionsControl : UserControl
    {
        public InstallacionsControl()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {          
            AnadirEditarInstalacionesControl a = new AnadirEditarInstalacionesControl();
            this.Controls.Add(a);
            a.BringToFront();
        }

        private void InstallacionsControl_Load(object sender, EventArgs e)
        {
           // dataGridViewInstalacions.DataSource = Proyecto.BaseDatos.Instalaciones.selectAllInstalaciones();
        }

        private void dataGridViewInstalacions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            String mensaje = " ";
            try
            {
                DialogResult result = MessageBox.Show("Estas seguro de que quieres borrar la instalación?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    mensaje = Proyecto.BaseDatos.Instalaciones.deleteInstalacion((Instal_lacio)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);

                    if (!mensaje.Equals(""))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true; //Al cancelar evitamos que se quite el elemento de la gridView.
                    MessageBox.Show("", "Se ha cancelado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
