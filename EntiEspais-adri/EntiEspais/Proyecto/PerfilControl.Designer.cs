namespace EntiEspais.Plantilla
{
    partial class PerfilControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonCerrarSesion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilControl));
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCognoms = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAdreça = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            buttonCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            buttonCerrarSesion.ForeColor = System.Drawing.Color.White;
            buttonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.Image")));
            buttonCerrarSesion.Location = new System.Drawing.Point(845, 5);
            buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new System.Drawing.Size(39, 42);
            buttonCerrarSesion.TabIndex = 19;
            buttonCerrarSesion.Text = " ";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.ForeColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(89, 159);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(723, 33);
            this.textBoxNom.TabIndex = 11;
            this.textBoxNom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNom_MouseClick);
            this.textBoxNom.MouseLeave += new System.EventHandler(this.textBoxNom_MouseLeave);
            // 
            // textBoxCognoms
            // 
            this.textBoxCognoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCognoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognoms.ForeColor = System.Drawing.Color.White;
            this.textBoxCognoms.Location = new System.Drawing.Point(89, 223);
            this.textBoxCognoms.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxCognoms.Name = "textBoxCognoms";
            this.textBoxCognoms.Size = new System.Drawing.Size(723, 33);
            this.textBoxCognoms.TabIndex = 12;
            this.textBoxCognoms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCognoms_MouseClick);
            this.textBoxCognoms.MouseLeave += new System.EventHandler(this.textBoxCognoms_MouseLeave);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(88, 415);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(723, 33);
            this.textBoxID.TabIndex = 13;
            this.textBoxID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxID_MouseClick);
            this.textBoxID.MouseLeave += new System.EventHandler(this.textBoxID_MouseLeave);
            // 
            // textBoxAdreça
            // 
            this.textBoxAdreça.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdreça.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdreça.ForeColor = System.Drawing.Color.White;
            this.textBoxAdreça.Location = new System.Drawing.Point(89, 351);
            this.textBoxAdreça.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxAdreça.Name = "textBoxAdreça";
            this.textBoxAdreça.Size = new System.Drawing.Size(723, 33);
            this.textBoxAdreça.TabIndex = 14;
            this.textBoxAdreça.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAdreça_MouseClick);
            this.textBoxAdreça.MouseLeave += new System.EventHandler(this.textBoxAdreça_MouseLeave);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.ForeColor = System.Drawing.Color.White;
            this.textBoxDNI.Location = new System.Drawing.Point(88, 287);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(723, 33);
            this.textBoxDNI.TabIndex = 15;
            this.textBoxDNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDNI_MouseClick);
            this.textBoxDNI.MouseLeave += new System.EventHandler(this.textBoxDNI_MouseLeave);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenya.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasenya.Location = new System.Drawing.Point(88, 479);
            this.textBoxContrasenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 2);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(723, 33);
            this.textBoxContrasenya.TabIndex = 16;
            this.textBoxContrasenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxContrasenya_MouseClick);
            this.textBoxContrasenya.TextChanged += new System.EventHandler(this.textBoxContrasenya_TextChanged);
            this.textBoxContrasenya.MouseLeave += new System.EventHandler(this.textBoxContrasenya_MouseLeave);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.Location = new System.Drawing.Point(647, 86);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(164, 41);
            this.buttonEditar.TabIndex = 18;
            this.buttonEditar.Text = " ";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // PerfilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(buttonCerrarSesion);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxAdreça);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxCognoms);
            this.Controls.Add(this.textBoxNom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerfilControl";
            this.Size = new System.Drawing.Size(900, 702);
            this.Load += new System.EventHandler(this.PerfilControl_Load);
<<<<<<< HEAD
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
=======
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PerfilControl_Paint);
>>>>>>> 11c7e47c200f05cf716da14474a0398efdf94ec6
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCognoms;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAdreça;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Button buttonEditar;
    }
}
