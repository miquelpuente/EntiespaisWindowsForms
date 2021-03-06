﻿using System;
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
    public partial class EditarActivitatControl : UserControl
    {
        private string defaultTextTipus = "Escull un tipus d'activitat";
        private string defaultTextEspais = "Escull un espai per a l'activitat";
        private string defaultTextEquips = "Escull l'equip que vols que realitzi l'activitat";


        public EditarActivitatControl()
        {
            InitializeComponent();
            comboBoxTipus.Text = defaultTextTipus;
            comboBoxEspais.Text = defaultTextEspais;
            comboBoxEquips.Text = defaultTextEquips;
        }

        private bool noCanvis()
        {
            // comprobamos que no se ha cambiado ninguna combobox de las 3 primeras
            if (!(comboBoxTipus.SelectedIndex == -1) || !(comboBoxEspais.SelectedIndex == -1) || !(comboBoxEquips.SelectedIndex == -1)){
                return true;
            }    

            // comprobamos que no haya habido cambios en los combo de los horarios
            // Dilluns
            if(!(comboBoxHoraMatiIniciDilluns.SelectedIndex == -1) || !(comboBoxHorariMatiTancarDilluns.SelectedIndex == -1) || !(comboBoxHoraTardaiIniciDilluns.SelectedIndex == -1) || !(comboBoxHorariTardaTancarDilluns.SelectedIndex == -1))
            {
                return true;
            }
            // Dimarts
            if(!(comboBoxHoraMatiIniciDimarts.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDimarts.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDimarts.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDimarts.SelectedIndex == -1))
            {
                return true;
            }
            // Dimecres
            if(!(comboBoxHoraMatiIniciDimecres.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDimecres.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDimecres.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDimecres.SelectedIndex == -1))
            {
                return true;
            }
            //  Dijous
            if(!(comboBoxHoraMatiIniciDijous.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDijous.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDijous.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDijous.SelectedIndex == -1))
            {
                return true;
            }
           // Divendres
            if(!(comboBoxHoraMatiIniciDivendres.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDivendres.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDivendres.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDivendres.SelectedIndex == -1))
            {
                return true;
            }
            // DIssabte
            if(!(comboBoxHoraMatiIniciDissabte.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDissabte.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDissabte.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDissabte.SelectedIndex == -1))
            {
                return true;
            }
            // diumenje
            if(!(comboBoxHoraMatiIniciDiumenje.SelectedIndex == -1) || !(comboBoxHoraMatiTancarDiumenje.SelectedIndex == -1) || !(comboBoxHoraTardaIniciDiumenje.SelectedIndex == -1) || !(comboBoxHoraTardaTancarDiumenje.SelectedIndex == -1))
            {
                return true;
            }

            // Si no ha habido cambios
            return false;
        }

        private void tancarFormulari()
        {
            this.Hide();
        }

        private void buttonDesar_Click(object sender, EventArgs e)
        {
            if (totsElsCanvis())
            {
                // guardar en la BD
                MessageBox.Show("S'ha registrat correctament l'Activitat!", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tancarFormulari();
            }
            else
            {
                MessageBox.Show("Has de seleccionar totes les opcions per a poder-ho guardar", "Atenció!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private bool totsElsCanvis()
        {
            int contador = 0;

            // comprobamos que haya cambios en todas las combo
            if (!(comboBoxTipus.SelectedIndex == -1) && !(comboBoxEspais.SelectedIndex == -1) && !(comboBoxEquips.SelectedIndex == -1))
            {
                contador += 3;
            }

            // comprobamos que esten todas las combos seleccionadas
            // Dilluns
            if (!(comboBoxHoraMatiIniciDilluns.SelectedIndex == -1) && !(comboBoxHorariMatiTancarDilluns.SelectedIndex == -1) && !(comboBoxHoraTardaiIniciDilluns.SelectedIndex == -1) && !(comboBoxHorariTardaTancarDilluns.SelectedIndex == -1))
            {
                contador += 4;
            }
            // Dimarts
            if (!(comboBoxHoraMatiIniciDimarts.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDimarts.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDimarts.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDimarts.SelectedIndex == -1))
            {
                contador += 4;
            }
            // Dimecres
            if (!(comboBoxHoraMatiIniciDimecres.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDimecres.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDimecres.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDimecres.SelectedIndex == -1))
            {
                contador += 4;
            }
            //  Dijous
            if (!(comboBoxHoraMatiIniciDijous.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDijous.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDijous.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDijous.SelectedIndex == -1))
            {
                contador += 4;
            }
            // Divendres
            if (!(comboBoxHoraMatiIniciDivendres.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDivendres.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDivendres.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDivendres.SelectedIndex == -1))
            {
                contador += 4;
            }
            // DIssabte
            if (!(comboBoxHoraMatiIniciDissabte.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDissabte.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDissabte.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDissabte.SelectedIndex == -1))
            {
                contador += 4;
            }
            // diumenje
            if (!(comboBoxHoraMatiIniciDiumenje.SelectedIndex == -1) && !(comboBoxHoraMatiTancarDiumenje.SelectedIndex == -1) && !(comboBoxHoraTardaIniciDiumenje.SelectedIndex == -1) && !(comboBoxHoraTardaTancarDiumenje.SelectedIndex == -1))
            {
                contador += 4;
            }

            // Si estan todas devuelve true
            if(contador >= 31)
            {
                return true;
            }
            // Si no estan todas las combo seleccionadas devuelve false
            else
            {
                return false;
            }                        
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            // Nos aseguramos si el usuario ha introducido datos al cerrar
            if (noCanvis())
            {
                // SI ha realizado cambios mostramos un mensaje
                DialogResult resultado;

                resultado = MessageBox.Show("Estas segur de voler tancar el formulari sense guardar?", "Hi ha canvis pendents!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                // Si el usuario ha confirmado que quiere salir cerramos el formulario
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    tancarFormulari();
                }
            }
            // Si el usuario no ha introducido datos
            else
            {
                tancarFormulari();
            }
        }
    }
}
