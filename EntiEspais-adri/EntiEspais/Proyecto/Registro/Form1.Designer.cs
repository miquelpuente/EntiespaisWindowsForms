namespace EntiEspais
{
    partial class Registre
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registre));
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxRepetirContrasenya = new System.Windows.Forms.TextBox();
            this.buttonMostrarContrassenyaRep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimizeApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.textBoxAdrecaElect = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonIniciarSessio = new System.Windows.Forms.Button();
            this.buttonMostrarContrassenya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.textBoxNom.ForeColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(172, 328);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(90, 30, 90, 3);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(514, 33);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Click += new System.EventHandler(this.textBoxNom_Click);
            this.textBoxNom.Leave += new System.EventHandler(this.textBoxNom_Leave);
            // 
            // textBoxRepetirContrasenya
            // 
            this.textBoxRepetirContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepetirContrasenya.ForeColor = System.Drawing.Color.White;
            this.textBoxRepetirContrasenya.Location = new System.Drawing.Point(172, 526);
            this.textBoxRepetirContrasenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxRepetirContrasenya.Name = "textBoxRepetirContrasenya";
            this.textBoxRepetirContrasenya.Size = new System.Drawing.Size(456, 33);
            this.textBoxRepetirContrasenya.TabIndex = 4;
            this.textBoxRepetirContrasenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRepetirContrasenya_MouseClick);
            this.textBoxRepetirContrasenya.TextChanged += new System.EventHandler(this.textBoxRepetirContrasenya_TextChanged);
            this.textBoxRepetirContrasenya.Leave += new System.EventHandler(this.textBoxRepetirContrasenya_Leave);
            // 
            // buttonMostrarContrassenyaRep
            // 
            this.buttonMostrarContrassenyaRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMostrarContrassenyaRep.FlatAppearance.BorderSize = 0;
            this.buttonMostrarContrassenyaRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContrassenyaRep.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMostrarContrassenyaRep.Location = new System.Drawing.Point(634, 526);
            this.buttonMostrarContrassenyaRep.Name = "buttonMostrarContrassenyaRep";
            this.buttonMostrarContrassenyaRep.Size = new System.Drawing.Size(52, 33);
            this.buttonMostrarContrassenyaRep.TabIndex = 10;
            this.buttonMostrarContrassenyaRep.UseVisualStyleBackColor = true;
            this.buttonMostrarContrassenyaRep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenyaRep_MouseDown);
            this.buttonMostrarContrassenyaRep.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenyaRep_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(346, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinimizeApp.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizeApp.Location = new System.Drawing.Point(767, 19);
            this.buttonMinimizeApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonMinimizeApp.Name = "buttonMinimizeApp";
            this.buttonMinimizeApp.Size = new System.Drawing.Size(25, 23);
            this.buttonMinimizeApp.TabIndex = 0;
            this.buttonMinimizeApp.UseVisualStyleBackColor = true;
            this.buttonMinimizeApp.Click += new System.EventHandler(this.buttonMinimizeApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Location = new System.Drawing.Point(805, 19);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(25, 23);
            this.buttonCloseApp.TabIndex = 0;
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // textBoxAdrecaElect
            // 
            this.textBoxAdrecaElect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdrecaElect.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdrecaElect.ForeColor = System.Drawing.Color.White;
            this.textBoxAdrecaElect.Location = new System.Drawing.Point(172, 394);
            this.textBoxAdrecaElect.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxAdrecaElect.Name = "textBoxAdrecaElect";
            this.textBoxAdrecaElect.Size = new System.Drawing.Size(514, 33);
            this.textBoxAdrecaElect.TabIndex = 2;
            this.textBoxAdrecaElect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAdrecaElect_MouseClick);
            this.textBoxAdrecaElect.Leave += new System.EventHandler(this.textBoxAdrecaElect_Leave);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenya.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasenya.Location = new System.Drawing.Point(172, 460);
            this.textBoxContrasenya.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(456, 33);
            this.textBoxContrasenya.TabIndex = 3;
            this.textBoxContrasenya.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxContrasenya_MouseClick);
            this.textBoxContrasenya.TextChanged += new System.EventHandler(this.textBoxContrasenya_TextChanged);
            this.textBoxContrasenya.Leave += new System.EventHandler(this.textBoxContrasenya_Leave);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonRegistrarse.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.Location = new System.Drawing.Point(477, 612);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(209, 51);
            this.buttonRegistrarse.TabIndex = 5;
            this.buttonRegistrarse.Text = "Registrar-se";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonIniciarSessio
            // 
            this.buttonIniciarSessio.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Underline);
            this.buttonIniciarSessio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSessio.Location = new System.Drawing.Point(281, 696);
            this.buttonIniciarSessio.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.buttonIniciarSessio.Name = "buttonIniciarSessio";
            this.buttonIniciarSessio.Size = new System.Drawing.Size(286, 46);
            this.buttonIniciarSessio.TabIndex = 6;
            this.buttonIniciarSessio.Text = "Iniciar sessió";
            this.buttonIniciarSessio.UseVisualStyleBackColor = true;
            this.buttonIniciarSessio.Click += new System.EventHandler(this.buttonIniciarSessio_Click);
            // 
            // buttonMostrarContrassenya
            // 
            this.buttonMostrarContrassenya.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMostrarContrassenya.FlatAppearance.BorderSize = 0;
            this.buttonMostrarContrassenya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContrassenya.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMostrarContrassenya.Location = new System.Drawing.Point(634, 460);
            this.buttonMostrarContrassenya.Name = "buttonMostrarContrassenya";
            this.buttonMostrarContrassenya.Size = new System.Drawing.Size(52, 33);
            this.buttonMostrarContrassenya.TabIndex = 9;
            this.buttonMostrarContrassenya.UseVisualStyleBackColor = true;
            this.buttonMostrarContrassenya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenya_MouseDown);
            this.buttonMostrarContrassenya.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMostrarContrassenya_MouseUp);
            // 
            // Registre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(849, 814);
            this.Controls.Add(this.buttonMostrarContrassenyaRep);
            this.Controls.Add(this.buttonMostrarContrassenya);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonIniciarSessio);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.textBoxRepetirContrasenya);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxAdrecaElect);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonMinimizeApp);
            this.Controls.Add(this.buttonCloseApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar-se";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonMinimizeApp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxRepetirContrasenya;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMostrarContrassenyaRep;
        private System.Windows.Forms.TextBox textBoxAdrecaElect;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonIniciarSessio;
        private System.Windows.Forms.Button buttonMostrarContrassenya;
    }
}

