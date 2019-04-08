using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais
{
    public partial class Registre : System.Windows.Forms.Form
    {
        // Atributs per a moure la finestra
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Atributs per als texts dels textviews
        private String nom = "Nom";
        private String email = "Adreça electrònica";
        private String contrasenya = "Contrasenya";
        private String repetirContrasenya = "Repetir contrasenya";

        public Registre()
        {
            InitializeComponent();

            // Para quitar el fondo de los textBox
            textBoxNom.BackColor = this.BackColor;
            textBoxAdrecaElect.BackColor = this.BackColor;
            textBoxContrasenya.BackColor = this.BackColor;
            textBoxRepetirContrasenya.BackColor = this.BackColor;

            // Asignamos los textos por defecto de los textBox
            textBoxNom.Text = nom;
            textBoxAdrecaElect.Text = email;
            textBoxContrasenya.Text = contrasenya;
            textBoxRepetirContrasenya.Text = repetirContrasenya;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            // Botó per a tancar l'aplicació
            Application.Exit();

            // Botó per a tancar només la finestra (Comentar el métode d'adalt)
            //this.Close();
        }

        private void buttonMinimizeApp_Click(object sender, EventArgs e)
        {
            // Botó per a minimitzar la finestra
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (1 - Cuándo haces clic y mantienes) 
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (2 - Cuándo arrastras el ratón)
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Sirve para mover la ventana (3 - Cuando sueltas el botón de clik)
            dragging = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos en los textbox. 
            // TextBox nom
            textBoxNom.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.White);
            p.Width = 2.0F;
            Graphics g = e.Graphics;
            int variance = 8;
            Rectangle rectTextBoxNom = new Rectangle(textBoxNom.Location.X - variance/2, textBoxNom.Location.Y - variance/2, textBoxNom.Width + variance, textBoxNom.Height + variance);
            g.DrawRectangle(p, rectTextBoxNom);

            // TextBox email
            textBoxAdrecaElect.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxEmail = new Rectangle(textBoxAdrecaElect.Location.X - variance/2, textBoxAdrecaElect.Location.Y - variance/2, textBoxAdrecaElect.Width + variance, textBoxAdrecaElect.Height + variance);
            g.DrawRectangle(p, rectTextBoxEmail);

            // Textbox Contrassenya (Cojemos la altura y la anchura del textbox email (por el botón de mostrar contraseña))
            textBoxContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxContrassenya = new Rectangle(textBoxContrasenya.Location.X - variance/2, textBoxContrasenya.Location.Y - variance/2, textBoxAdrecaElect.Width + variance, textBoxAdrecaElect.Height + variance);
            g.DrawRectangle(p, rectTextBoxContrassenya);

            // TextBox Repetir Contrassenya (Cojemos la altura y la anchura del textbox email (por el botón de mostrar contraseña))
            textBoxRepetirContrasenya.BorderStyle = BorderStyle.None;
            Rectangle rectTextBoxRepetirContrassenya = new Rectangle(textBoxRepetirContrasenya.Location.X - variance/2, textBoxRepetirContrasenya.Location.Y - variance/2, textBoxAdrecaElect.Width + variance, textBoxAdrecaElect.Height + variance);
            g.DrawRectangle(p, rectTextBoxRepetirContrassenya);
        }

        private void textBoxNom_Click(object sender, EventArgs e)
        {
            // Cuando hacemos click en el textBoxNom y está el valor por defecto, se borra el texto por defecto
            if (textBoxNom.Text == nom)
            {
                textBoxNom.Text = "";
            }
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textboxNom, si no se ha añadido ningún texto vuelve al texto por defecto
            if(textBoxNom.Text == "")
            {
                textBoxNom.Text = nom;
            }
        }

        private void textBoxAdrecaElect_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxEmail y está el valor por defecto, se borra el texto por defecto
            if (textBoxAdrecaElect.Text == email)
            {
                textBoxAdrecaElect.Text = "";
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

        private void textBoxContrasenya_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxContrassenya y está el valor por defecto, se borra el texto por defecto
            if (textBoxContrasenya.Text == contrasenya)
            {
                textBoxContrasenya.Text = "";
            }
        }

        private void textBoxAdrecaElect_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textBoxEmail, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxAdrecaElect.Text == "")
            {
                textBoxAdrecaElect.Text = email;
            }
        }

        private void textBoxContrasenya_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textBoxContrassenya, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxContrasenya.Text == "")
            {
                textBoxContrasenya.Text = contrasenya;
            }
        }

        private void buttonMostrarContrassenya_MouseDown(object sender, MouseEventArgs e)
        {
            // Si se hace clik en mostrar pw, se muestra la pw
            if (textBoxContrasenya.Text != contrasenya)
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void buttonMostrarContrassenya_MouseUp(object sender, MouseEventArgs e)
        {
            // Cuando se deja de pulsar el botón de mostrar pw se vuelve a "esconder" la pw
            if (textBoxContrasenya.Text != contrasenya)
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
        }

        private void textBoxRepetirContrasenya_MouseClick(object sender, MouseEventArgs e)
        {
            // Cuando hacemos click en el textBoxRepetirContrasenya y está el valor por defecto, se borra el texto por defecto
            if (textBoxRepetirContrasenya.Text == repetirContrasenya)
            {
                textBoxRepetirContrasenya.Text = "";
            }
        }

        private void textBoxRepetirContrasenya_Leave(object sender, EventArgs e)
        {
            // Cuando no está el focus en el textBoxContrassenya, si no se ha añadido ningún texto vuelve al texto por defecto
            if (textBoxRepetirContrasenya.Text == "")
            {
                textBoxRepetirContrasenya.Text = repetirContrasenya;
            }
        }

        private void textBoxRepetirContrasenya_TextChanged(object sender, EventArgs e)
        {
            // Si cambia el texto del textbox contrasenya se muestra como carácteres "Seguros"
            if ((textBoxRepetirContrasenya.Text != repetirContrasenya) && (textBoxRepetirContrasenya.Text != null))
            {
                textBoxRepetirContrasenya.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxRepetirContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void buttonMostrarContrassenyaRep_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxRepetirContrasenya.Text != repetirContrasenya)
            {
                textBoxRepetirContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void buttonMostrarContrassenyaRep_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBoxRepetirContrasenya.Text != repetirContrasenya)
            {
                textBoxRepetirContrasenya.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            // Comprobamos que el textBox Nom no está con el texto por defecto o null (por si acaso)
            if (textBoxNom.Text != nom && textBoxNom.Text != "")
            {
                // Comprobamos que el textBox email no está con el texto por defecto o null (por si acaso)
                if (textBoxAdrecaElect.Text != email && textBoxAdrecaElect.Text != "")
                {
                    // Comprobamos que el email es válido
                    if (textBoxAdrecaElect.Text.Contains("@") && textBoxAdrecaElect.Text.Contains("."))
                    {
                        // Comprobamos que el textBox contrassenya no está con el texto por defecto o null (por si acaso)
                        if (textBoxContrasenya.Text != contrasenya && textBoxContrasenya.Text != "")
                        {
                            // Comprobamos que el textBox contrassenya no está con el texto por defecto o null (por si acaso)
                            if (textBoxRepetirContrasenya.Text != repetirContrasenya && textBoxRepetirContrasenya.Text != "")
                            {
                                // Comprobamos que las dos contraseñas coinciden
                                if (textBoxContrasenya.Text == textBoxRepetirContrasenya.Text)
                                {
                                    /*
                                     * Agregar el usuario a la BD
                                     */
                                    Plantilla.Perfil a = new Plantilla.Perfil();
                                    a.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Les contrassenyes no coincideixen", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBoxContrasenya.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introdueix una contrassenya vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxRepetirContrasenya.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introdueix una contrassenya vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxContrasenya.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introdueix una adreça electrònica vàlida", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxAdrecaElect.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Introdueix una adreça electrònica", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxAdrecaElect.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introdueix un nom d'usuari", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNom.Focus();
            }
        }

        private void buttonIniciarSessio_Click(object sender, EventArgs e)
        {
            // Obrim el formulari
           IniciarSesio a = new IniciarSesio();
           a.Show();

            // Amaguem el formulari
            this.Hide();
        }        
    }
}
