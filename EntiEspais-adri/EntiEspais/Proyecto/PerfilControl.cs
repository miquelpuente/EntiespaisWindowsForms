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
    public partial class PerfilControl : UserControl
         
    {
        // Texto para los textbox
        private String nom = "NOM";
        private String cognoms = "COGNOMS";
        private String dni = "DNI";
        private String email = " ADREÇA ELECTRÒNICA";
        private String id = "ID";
        private String contrasenya = " CONTRASENYA";


        public PerfilControl()
        {
            InitializeComponent();
            // Treiem el color de fons del textbox
            this.textBoxNom.BackColor = this.BackColor;
            this.textBoxCognoms.BackColor = this.BackColor;
            this.textBoxDNI.BackColor = this.BackColor;
            this.textBoxAdreça.BackColor = this.BackColor;
            this.textBoxID.BackColor = this.BackColor;
            this.textBoxContrasenya.BackColor = this.BackColor;


            // Assignem els noms als textboxs
            textBoxNom.Text = nom;
            
            textBoxCognoms.Text = cognoms;

            textBoxDNI.Text = dni;

            textBoxAdreça.Text = email;

            textBoxID.Text = id;

            textBoxContrasenya.Text = contrasenya;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PerfilControl_Load(object sender, EventArgs e)
        {

        }

        private void PerfilControl_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // Seleccionamos como pintar los rectangulos (Boli blanco, 2F de ancho);
            Pen p = new Pen(Color.White);
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;

            // TextBox nom
            textBoxNom.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxNom = new Rectangle(textBoxNom.Location.X - variance / 2, textBoxNom.Location.Y - variance / 2, textBoxNom.Width + variance, textBoxNom.Height + variance);
            g.DrawRectangle(p, rectTextBoxNom);

            //textbox  cognoms
            textBoxCognoms.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxCognoms = new Rectangle(textBoxCognoms.Location.X - variance / 2, textBoxCognoms.Location.Y - variance / 2, textBoxCognoms.Width + variance, textBoxCognoms.Height + variance);
            g.DrawRectangle(p, rectTextBoxCognoms);

            //textbox  dni
            textBoxDNI.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxDNI = new Rectangle(textBoxDNI.Location.X - variance / 2, textBoxDNI.Location.Y - variance / 2, textBoxDNI.Width + variance, textBoxDNI.Height + variance);
            g.DrawRectangle(p, rectTextBoxDNI);

            //textbox  email
            textBoxAdreça.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxAdreça = new Rectangle(textBoxAdreça.Location.X - variance / 2, textBoxAdreça.Location.Y - variance / 2, textBoxAdreça.Width + variance, textBoxAdreça.Height + variance);
            g.DrawRectangle(p, rectTextBoxAdreça);

            //textbox  id
            textBoxID.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxID = new Rectangle(textBoxID.Location.X - variance / 2, textBoxID.Location.Y - variance / 2, textBoxID.Width + variance, textBoxID.Height + variance);
            g.DrawRectangle(p, rectTextBoxID);

            //textbox  contrasenya 
            
            textBoxContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxContrasenya = new Rectangle(textBoxContrasenya.Location.X - variance / 2, textBoxContrasenya.Location.Y - variance / 2, textBoxContrasenya.Width + variance, textBoxContrasenya.Height + variance);
            g.DrawRectangle(p, rectTextBoxContrasenya);

        }

        //´--------------------------  TEXT BOX  --------------------------

        //textBox Nom
        private void textBoxNom_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxNom.Text == nom)
            {
                textBoxNom.Text = "";
            }
        }

        private void textBoxNom_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxNom.Text == "")
            {
                textBoxNom.Text = nom;
            }

        }

        //textbox  cognoms

     

       

        private void textBoxCognoms_MouseClick(object sender, MouseEventArgs e)
        {

            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxCognoms.Text == cognoms)
            {
                textBoxCognoms.Text = "";
            }


        }
        private void textBoxCognoms_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxCognoms.Text == "")
            {
                textBoxCognoms.Text = cognoms;
            }

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }


        //textbox  dni
        private void textBoxDNI_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxDNI.Text == dni)
            {
                textBoxDNI.Text = "";
            }
        }

        private void textBoxDNI_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxDNI.Text == "")
            {
                textBoxDNI.Text = dni;
            }

        }



        //textbox  email
        private void textBoxAdreça_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxAdreça.Text == email)
            {
                textBoxAdreça.Text = "";
            }
        }

        private void textBoxAdreça_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxAdreça.Text == "")
            {
                textBoxAdreça.Text = email;
            }

        }
        //textbox  id
        private void textBoxID_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxID.Text == id)
            {
                textBoxID.Text = "";
            }

        }

        private void textBoxID_MouseLeave(object sender, EventArgs e)
        {
            
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxID.Text == "")
            {
                textBoxID.Text = id;
            }
        }




        //textbox  contrasenya

        private void textBoxContrasenya_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuándo se hace clik en el textbox y esta el texto por defecto se borra el texto
            if (textBoxContrasenya.Text == contrasenya)
            {
                textBoxContrasenya.Text = "";
            }
        }

        private void textBoxContrasenya_MouseLeave(object sender, EventArgs e)
        {
            // si no esta en el textbox de nom, vuelve a tener texto
            if (textBoxContrasenya.Text == "")
            {
                textBoxContrasenya.Text = contrasenya;
            }
        }
        private void textBoxContrasenya_TextChanged(object sender, EventArgs e)
        {
            // Si cambia el texto del textbox contrasenya se muestra como carácteres "Seguros"
            if ((textBoxContrasenya.Text != contrasenya) && (textBoxContrasenya.Text != null))
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            }
        }

       

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarPerfilControl a = new EditarPerfilControl();
            this.Controls.Add(a);
            a.BringToFront();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            


            DialogResult result;
            //preguntamos si desea cerrar sesión
            result = MessageBox.Show("Desitges tancar sessió?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Cerramos la sesion

                Application.Exit();
            }
        }
    }
}
