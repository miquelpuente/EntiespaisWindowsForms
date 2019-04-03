﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Plantilla
{
    public partial class Plantilla : Form
    {
        // Atributs per a moure la finestra
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Plantilla()
        {
            InitializeComponent();

            
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimizeApp_Click(object sender, EventArgs e)
        {
            // Botó per a minimitzar la finestra
            this.WindowState = FormWindowState.Minimized;
        }
        private void Plantilla_MouseDown(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (1 - Cuándo haces clic y mantienes) 
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Plantilla_MouseMove(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (2 - Cuándo arrastras el ratón)
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Plantilla_MouseUp(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (3 - Cuando sueltas el botón de clik)
            dragging = false;
        }
    }
}
