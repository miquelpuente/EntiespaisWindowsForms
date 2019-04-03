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
    public partial class EditarAnadirEntitatControl : UserControl
    {
        // Texto para los textbox
        private String nom = "NOM ENTITAT";
        private String temporada = "TEMPORADA";
        private String adreça = "ADREÇA";
        private String NIF = "NIF";
        private String email = "ADREÇA ELECTRÒNICA";
        private String rao = "RAÓ";
        private String numero = "NÚMERO";


        public EditarAnadirEntitatControl()
        {
            InitializeComponent();
            // Treiem el color de fons del textbox
            this.textBoxNomEntitat.BackColor = this.BackColor;
            this.textBoxTemporada.BackColor = this.BackColor;
            this.textBoxAdreça.BackColor = this.BackColor;
            this.textBoxNIF.BackColor = this.BackColor;
            this.textBoxAdreçaElectronica.BackColor = this.BackColor;
            this.textBoxRao.BackColor = this.BackColor;
            this.textBoxNumero.BackColor = this.BackColor;

            // Assignem els noms als textboxs
            textBoxNomEntitat.Text = nom;

            textBoxTemporada.Text = temporada;

            textBoxAdreça.Text = adreça;

            textBoxNIF.Text = NIF;

            textBoxAdreçaElectronica.Text = email;

            textBoxRao.Text = rao;

            textBoxNumero.Text = numero;

        }

        private void EditarAnadirEntitatControl_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // Seleccionamos como pintar los rectangulos (Boli blanco, 2F de ancho);
            Pen p = new Pen(Color.White);
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;

            // TextBox nom
            textBoxNomEntitat.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxNomEntitat = new Rectangle(textBoxNomEntitat.Location.X - variance / 2, textBoxNomEntitat.Location.Y - variance / 2, textBoxNomEntitat.Width + variance, textBoxNomEntitat.Height + variance);
            g.DrawRectangle(p, rectTextBoxNomEntitat);

            //textbox temporada
            textBoxTemporada.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxTemporada = new Rectangle(textBoxTemporada.Location.X - variance / 2, textBoxTemporada.Location.Y - variance / 2, textBoxTemporada.Width + variance, textBoxTemporada.Height + variance);
            g.DrawRectangle(p, rectTextBoxTemporada);

            //textbox adreça
            textBoxAdreça.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxAdreça = new Rectangle(textBoxAdreça.Location.X - variance / 2, textBoxAdreça.Location.Y - variance / 2, textBoxAdreça.Width + variance, textBoxAdreça.Height + variance);
            g.DrawRectangle(p, rectTextBoxAdreça);


            //textbox NIF
            textBoxNIF.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxNIF = new Rectangle(textBoxNIF.Location.X - variance / 2, textBoxNIF.Location.Y - variance / 2, textBoxNIF.Width + variance, textBoxNIF.Height + variance);
            g.DrawRectangle(p, rectTextBoxNIF);

            //textbox Adreça electronica
            textBoxAdreçaElectronica.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxAdreçaElectronica = new Rectangle(textBoxAdreçaElectronica.Location.X - variance / 2, textBoxAdreçaElectronica.Location.Y - variance / 2, textBoxAdreçaElectronica.Width + variance, textBoxAdreçaElectronica.Height + variance);
            g.DrawRectangle(p, rectTextBoxAdreçaElectronica);


            //textbox rao
            textBoxRao.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxRao = new Rectangle(textBoxRao.Location.X - variance / 2, textBoxRao.Location.Y - variance / 2, textBoxRao.Width + variance, textBoxRao.Height + variance);
            g.DrawRectangle(p, rectTextBoxRao);

            //textbox numero
            textBoxNumero.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxNumero = new Rectangle(textBoxNumero.Location.X - variance / 2, textBoxNumero.Location.Y - variance / 2, textBoxNumero.Width + variance, textBoxNumero.Height + variance);
            g.DrawRectangle(p, rectTextBoxNumero);

        }
        //--------------------------  TEXT BOX  --------------------------













        //textBox Nom Etitat

        private void textBoxNomEntitat_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxNomEntitat.Text == nom)
            {
                textBoxNomEntitat.Text = "";
            }
        }

        private void textBoxNomEntitat_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxNomEntitat.Text == "")
            {
                textBoxNomEntitat.Text = nom;
            }
        }
        //textbox temporada
        private void textBoxTemporada_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxTemporada.Text == temporada)
            {
                textBoxTemporada.Text = "";
            }
        }

        private void textBoxTemporada_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxTemporada.Text == "")
            {
                textBoxTemporada.Text = temporada;
            }
        }

        //texbox adreça
        private void textBoxAdreça_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxAdreça.Text == adreça)
            {
                textBoxAdreça.Text = "";
            }
        }

        private void textBoxAdreça_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxAdreça.Text == "")
            {
                textBoxAdreça.Text = adreça;
            }
        }
        //texbox NIF
        private void textBoxNIF_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxNIF.Text == NIF)
            {
                textBoxNIF.Text = "";
            }
        }

        private void textBoxNIF_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxNIF.Text == "")
            {
                textBoxNIF.Text = NIF;
            }
        }
        //texbox Adreça Elèctronica
        private void textBoxAdreçaElectronica_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxAdreçaElectronica.Text == email)
            {
                textBoxAdreçaElectronica.Text = "";
            }
        }

        private void textBoxAdreçaElectronica_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxAdreçaElectronica.Text == "")
            {
                textBoxAdreçaElectronica.Text = email;
            }
        }
        //textbox rao
        private void textBoxRao_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxRao.Text == rao)
            {
                textBoxRao.Text = "";
            }
        }

        private void textBoxRao_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxRao.Text == "")
            {
                textBoxRao.Text = rao;
            }
        }
        //textbox numero
        private void textBoxNumero_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxNumero.Text == numero)
            {
                textBoxNumero.Text = "";
            }
        }

        private void textBoxNumero_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxNumero.Text == "")
            {
                textBoxNumero.Text = numero;
            }
        }
    }
}


