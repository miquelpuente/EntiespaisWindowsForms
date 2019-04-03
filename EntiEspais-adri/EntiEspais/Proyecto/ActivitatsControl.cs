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
    public partial class ActivitatsControl : UserControl
    {
        public ActivitatsControl()
        {
            InitializeComponent();
        }
        //botón editar
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarActivitatControl a = new EditarActivitatControl();
            this.Controls.Add(a);
            a.BringToFront();
        }

        //CAMBIAR EL COLOR A LA GRID -------------------------------------------
        private void ActivitatsControl_Load(object sender, EventArgs e)
        {
            dataGridViewActivitats.BorderStyle = BorderStyle.None;
            dataGridViewActivitats.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(147, 142, 164);
            dataGridViewActivitats.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //CUANDO UNA CELDA ESTE SELECCIONADA, CAMBIARÁ DE COLOR PARA IDENTIFICARLA
            dataGridViewActivitats.DefaultCellStyle.SelectionBackColor = Color.FromArgb(117, 222, 213);
            dataGridViewActivitats.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewActivitats.BackgroundColor = Color.White;


            dataGridViewActivitats.EnableHeadersVisualStyles = false;
            dataGridViewActivitats.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewActivitats.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 99, 113);
            dataGridViewActivitats.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewActivitats.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
        }
    }
}
