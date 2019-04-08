using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Proyecto
{
    public partial class AsignacioSollicitudsControl : UserControl
    {
        public AsignacioSollicitudsControl()
        {
            InitializeComponent();
        }

        private void AsignacioSollicitudsControl_Load(object sender, EventArgs e)
        {
            //CAMBIAR EL COLOR A LA GRID -------------------------------------------

            dataGridVieweAgregar.BorderStyle = BorderStyle.None;
            dataGridVieweAgregar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(147, 142, 164);
            dataGridVieweAgregar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //CUANDO UNA CELDA ESTE SELECCIONADA, CAMBIARÁ DE COLOR PARA IDENTIFICARLA
            dataGridVieweAgregar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(117, 222, 213);
            dataGridVieweAgregar.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridVieweAgregar.BackgroundColor = Color.White;


            dataGridVieweAgregar.EnableHeadersVisualStyles = false;
            dataGridVieweAgregar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridVieweAgregar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 99, 113);
            dataGridVieweAgregar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridVieweAgregar.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
        }
    }
    
}
