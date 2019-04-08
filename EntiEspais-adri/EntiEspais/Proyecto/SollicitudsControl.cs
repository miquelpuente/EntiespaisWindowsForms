using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntiEspais.Proyecto.agregarSolicitud;

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
            //ataGridVieweSollicituds
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


            //dataGridVieweAgregar

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

        private void dataGridVieweSollicituds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            /*FormsAsignarSolicitudes fa = new FormsAsignarSolicitudes();
           

            fa.Show();

            this.Hide(); */
        }

        private void labelEspais_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNomEspais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEsborrar_Click(object sender, EventArgs e)
        {

        }
    }
}
