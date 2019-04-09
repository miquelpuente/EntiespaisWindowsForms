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
      }
}
