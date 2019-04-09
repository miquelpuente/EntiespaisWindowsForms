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
    public partial class InstallacionsEspaisControl : UserControl
    {
        public InstallacionsEspaisControl()
        {
            InitializeComponent();
        }

        private void InstallacionsEspaisControl_Load(object sender, EventArgs e)
        {
            //CAMBIAR EL COLOR A LA GRID -------------------------------------------
        
            dataGridVieweEntitats.BorderStyle = BorderStyle.None;
            dataGridVieweEntitats.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(147, 142, 164);
            dataGridVieweEntitats.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //CUANDO UNA CELDA ESTE SELECCIONADA, CAMBIARÁ DE COLOR PARA IDENTIFICARLA
            dataGridVieweEntitats.DefaultCellStyle.SelectionBackColor = Color.FromArgb(117, 222, 213);
            dataGridVieweEntitats.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridVieweEntitats.BackgroundColor = Color.White;


            dataGridVieweEntitats.EnableHeadersVisualStyles = false;
            dataGridVieweEntitats.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridVieweEntitats.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 99, 113);
            dataGridVieweEntitats.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridVieweEntitats.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
        }

        private void buttonDesar_Click(object sender, EventArgs e)
        {

        }
    }
}
