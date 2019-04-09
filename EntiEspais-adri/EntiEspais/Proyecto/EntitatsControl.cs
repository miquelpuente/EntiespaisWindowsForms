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
    public partial class EntitatsControl : UserControl
    {
        // Texto para el buscardor 
        private String buscador = "       Buscador";
        

        public EntitatsControl()
        {
            InitializeComponent();
            // Treiem el color de fons del textbox
            this.textBoxBuscador.BackColor = this.BackColor;
            // Assignem els noms als textboxs
            textBoxBuscador.Text = buscador;
        }
        //para el buscador
        private void EntitatsControl_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // Seleccionamos como pintar los rectangulos (Boli blanco, 2F de ancho);
            Pen p = new Pen(Color.FromArgb(147, 142, 164));
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;
            // TextBox buscador
            textBoxBuscador.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxBuscador = new Rectangle(textBoxBuscador.Location.X - variance / 2, textBoxBuscador.Location.Y - variance / 2, textBoxBuscador.Width + variance, textBoxBuscador.Height + variance);
            g.DrawRectangle(p, rectTextBoxBuscador);

        }
        //´--------------------------  TEXT BOX  --------------------------

        private void textBoxBuscador_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxBuscador.Text == buscador)
            {
                textBoxBuscador.Text = "";
            }
        }
        private void textBoxBuscador_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox, vuelve a tener texto
            if (textBoxBuscador.Text == "")
            {
                textBoxBuscador.Text = buscador;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        //CAMBIAR EL COLOR A LA GRID -------------------------------------------
        private void EntitatsControl_Load(object sender, EventArgs e)
        {
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
            dataGridVieweEntitats.ColumnHeadersDefaultCellStyle.Font = new Font ("Roboto", 12, FontStyle.Bold);
        }

        private void dataGridVieweEntitats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
