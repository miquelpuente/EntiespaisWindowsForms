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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCorreu = new System.Windows.Forms.Label();
            buttonCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.Location = new System.Drawing.Point(673, 74);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(164, 41);
            this.buttonEditar.TabIndex = 18;
            this.buttonEditar.Text = " ";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(171)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.labelCorreu);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Location = new System.Drawing.Point(55, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 430);
            this.panel1.TabIndex = 20;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(88, 162);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 22;
            this.labelNom.Text = "Nom";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(88, 115);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 26;
            this.labelId.Text = "ID";
            // 
            // labelCorreu
            // 
            this.labelCorreu.AutoSize = true;
            this.labelCorreu.Location = new System.Drawing.Point(88, 217);
            this.labelCorreu.Name = "labelCorreu";
            this.labelCorreu.Size = new System.Drawing.Size(53, 17);
            this.labelCorreu.TabIndex = 27;
            this.labelCorreu.Text = "Adreça";
            // 
            // PerfilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(buttonCerrarSesion);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerfilControl";
            this.Size = new System.Drawing.Size(900, 702);
            this.Load += new System.EventHandler(this.PerfilControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCorreu;
        private System.Windows.Forms.Label labelId;
    }
}
