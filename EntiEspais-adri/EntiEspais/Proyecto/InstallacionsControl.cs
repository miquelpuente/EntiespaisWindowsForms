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

            // Datos provisionales
            dataGridViewInstalacions.Rows.Add();
            dataGridViewInstalacions.Rows[0].Cells[0].Value = "Instalacio 1";
            dataGridViewInstalacions.Rows[0].Cells[1].Value = "Carrer Llacuna num 2";

            dataGridViewInstalacions.Rows.Add();
            dataGridViewInstalacions.Rows[1].Cells[0].Value = "Instalacio 2";
            dataGridViewInstalacions.Rows[1].Cells[1].Value = "Carrer Marina numero 12";

            dataGridViewInstalacions.Rows.Add();
            dataGridViewInstalacions.Rows[2].Cells[0].Value = "Instalacio 3";
            dataGridViewInstalacions.Rows[2].Cells[1].Value = "Carrer Murcia numero 12";

            dataGridViewInstalacions.Rows.Add();
            dataGridViewInstalacions.Rows[3].Cells[0].Value = "Instalacio 4";
            dataGridViewInstalacions.Rows[3].Cells[1].Value = "Carrer Cinca numero 12";

            
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {          
            AnadirEditarInstalacionesControl a = new AnadirEditarInstalacionesControl();
            this.Controls.Add(a);
            a.BringToFront();
        }

        private void InstallacionsControl_Load(object sender, EventArgs e)
        {
            
        }
      }
}
