using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntiEspais.Plantilla
{
    public partial class Perfil : EntiEspais.Plantilla.Plantilla
    {
        public Perfil()
        {
            InitializeComponent();
            PerfilControl pf = new PerfilControl();
            selectorPanel.Height = buttonPerfil.Height;
            selectorPanel.Top = buttonPerfil.Top;

            pf.BringToFront();

        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void buttonInstallacions_Click(object sender, EventArgs e)
        {
          
            selectorPanel.Height = buttonInstallacions.Height;
            selectorPanel.Top = buttonInstallacions.Top;
            installacionsControl.BringToFront();
            //BringToFront();


        }

        

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
          
          

            selectorPanel.Height = buttonPerfil.Height;
            selectorPanel.Top = buttonPerfil.Top;
            perfilControl.BringToFront();

        }

        private void buttonEntitats_Click_1(object sender, EventArgs e)
        {
            

            selectorPanel.Height = buttonEntitats.Height;
            selectorPanel.Top = buttonEntitats.Top;
            
            entitatsControl.BringToFront();

        }

        private void buttonActivitats_Click(object sender, EventArgs e)
        {
            selectorPanel.Height = buttonActivitats.Height;
            selectorPanel.Top = buttonActivitats.Top;

            activitatsControl.BringToFront();
        }

        
        private void buttonSollicituds_Click(object sender, EventArgs e)
        {
            selectorPanel.Height = buttonSollicituds.Height;
            selectorPanel.Top = buttonSollicituds.Top;

            sollicitudsControl.BringToFront();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            selectorPanel.Height = buttonExportar.Height;
            selectorPanel.Top = buttonExportar.Top;

            exportarControl.BringToFront();
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            selectorPanel.Height = buttonAjuda.Height;
            selectorPanel.Top = buttonAjuda.Top;
            ajudaControl.BringToFront();
        }
    }
}
