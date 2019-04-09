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
    public partial class SollicitudsControl : UserControl
    {
        public SollicitudsControl()
        {
            InitializeComponent();
        }

        private void SollicitudsControl_Load(object sender, EventArgs e)
        {
            //CAMBIAR EL COLOR A LA GRID -------------------------------------------

            dataGridVieweSollicituds.BorderStyle = BorderStyle.None;
            dataGridVieweSollicituds.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(147, 142, 164);
            dataGridVieweSollicituds.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //CUANDO UNA CELDA ESTE SELECCIONADA, CAMBIARÁ DE COLOR PARA IDENTIFICARLA
            dataGridVieweSollicituds.DefaultCellStyle.SelectionBackColor = Color.FromArgb(117, 222, 213);
            dataGridVieweSollicituds.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridVieweSollicituds.BackgroundColor = Color.White;


            dataGridVieweSollicituds.EnableHeadersVisualStyles = false;
            dataGridVieweSollicituds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridVieweSollicituds.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 99, 113);
            dataGridVieweSollicituds.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridVieweSollicituds.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
        }
        }
}
