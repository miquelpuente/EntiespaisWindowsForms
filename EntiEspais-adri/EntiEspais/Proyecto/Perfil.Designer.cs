namespace EntiEspais.Plantilla
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectorPanel = new System.Windows.Forms.Panel();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonInstallacions = new System.Windows.Forms.Button();
            this.buttonActivitats = new System.Windows.Forms.Button();
            this.buttonEntitats = new System.Windows.Forms.Button();
            this.buttonSollicituds = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.entitatsControl = new EntiEspais.Plantilla.EntitatsControl();
            this.editarPerfilControl = new EntiEspais.Plantilla.EditarPerfilControl();
            this.perfilControl = new EntiEspais.Plantilla.PerfilControl();
            this.installacionsControl = new EntiEspais.Plantilla.InstallacionsControl();
            this.activitatsControl = new EntiEspais.Proyecto.ActivitatsControl();
            this.sollicitudsControl = new EntiEspais.Proyecto.SollicitudsControl();
            this.exportarControl = new EntiEspais.Proyecto.ExportarControl();
            this.ajudaControl = new EntiEspais.AjudaControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectorPanel);
            this.panel1.Controls.Add(this.buttonAjuda);
            this.panel1.Controls.Add(this.buttonExportar);
            this.panel1.Controls.Add(this.buttonPerfil);
            this.panel1.Controls.Add(this.buttonInstallacions);
            this.panel1.Controls.Add(this.buttonActivitats);
            this.panel1.Controls.Add(this.buttonEntitats);
            this.panel1.Controls.Add(this.buttonSollicituds);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 849);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // selectorPanel
            // 
            this.selectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.selectorPanel.Location = new System.Drawing.Point(0, 457);
            this.selectorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectorPanel.Name = "selectorPanel";
            this.selectorPanel.Size = new System.Drawing.Size(19, 85);
            this.selectorPanel.TabIndex = 8;
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonAjuda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjuda.Image")));
            this.buttonAjuda.Location = new System.Drawing.Point(0, 629);
            this.buttonAjuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(216, 86);
            this.buttonAjuda.TabIndex = 7;
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonExportar.Image = ((System.Drawing.Image)(resources.GetObject("buttonExportar.Image")));
            this.buttonExportar.Location = new System.Drawing.Point(0, 543);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(216, 86);
            this.buttonExportar.TabIndex = 6;
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonPerfil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPerfil.Image")));
            this.buttonPerfil.Location = new System.Drawing.Point(0, 457);
            this.buttonPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(216, 86);
            this.buttonPerfil.TabIndex = 5;
            this.buttonPerfil.UseVisualStyleBackColor = true;
            this.buttonPerfil.Click += new System.EventHandler(this.buttonPerfil_Click);
            // 
            // buttonInstallacions
            // 
            this.buttonInstallacions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallacions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonInstallacions.Image = ((System.Drawing.Image)(resources.GetObject("buttonInstallacions.Image")));
            this.buttonInstallacions.Location = new System.Drawing.Point(0, 370);
            this.buttonInstallacions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInstallacions.Name = "buttonInstallacions";
            this.buttonInstallacions.Size = new System.Drawing.Size(216, 86);
            this.buttonInstallacions.TabIndex = 4;
            this.buttonInstallacions.UseVisualStyleBackColor = true;
            this.buttonInstallacions.Click += new System.EventHandler(this.buttonInstallacions_Click);
            // 
            // buttonActivitats
            // 
            this.buttonActivitats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivitats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonActivitats.Image = ((System.Drawing.Image)(resources.GetObject("buttonActivitats.Image")));
            this.buttonActivitats.Location = new System.Drawing.Point(0, 284);
            this.buttonActivitats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonActivitats.Name = "buttonActivitats";
            this.buttonActivitats.Size = new System.Drawing.Size(216, 86);
            this.buttonActivitats.TabIndex = 3;
            this.buttonActivitats.UseVisualStyleBackColor = true;
            this.buttonActivitats.Click += new System.EventHandler(this.buttonActivitats_Click);
            // 
            // buttonEntitats
            // 
            this.buttonEntitats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntitats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonEntitats.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntitats.Image")));
            this.buttonEntitats.Location = new System.Drawing.Point(0, 198);
            this.buttonEntitats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEntitats.Name = "buttonEntitats";
            this.buttonEntitats.Size = new System.Drawing.Size(216, 86);
            this.buttonEntitats.TabIndex = 2;
            this.buttonEntitats.UseVisualStyleBackColor = true;
            this.buttonEntitats.Click += new System.EventHandler(this.buttonEntitats_Click_1);
            // 
            // buttonSollicituds
            // 
            this.buttonSollicituds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSollicituds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.buttonSollicituds.Image = ((System.Drawing.Image)(resources.GetObject("buttonSollicituds.Image")));
            this.buttonSollicituds.Location = new System.Drawing.Point(0, 112);
            this.buttonSollicituds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSollicituds.Name = "buttonSollicituds";
            this.buttonSollicituds.Size = new System.Drawing.Size(216, 86);
            this.buttonSollicituds.TabIndex = 1;
            this.buttonSollicituds.UseVisualStyleBackColor = true;
            this.buttonSollicituds.Click += new System.EventHandler(this.buttonSollicituds_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 112);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // entitatsControl
            // 
            this.entitatsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.entitatsControl.Location = new System.Drawing.Point(215, 41);
            this.entitatsControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.entitatsControl.Name = "entitatsControl";
            this.entitatsControl.Size = new System.Drawing.Size(900, 702);
            this.entitatsControl.TabIndex = 11;
            // 
            // editarPerfilControl
            // 
            this.editarPerfilControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.editarPerfilControl.Location = new System.Drawing.Point(215, 41);
            this.editarPerfilControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editarPerfilControl.Name = "editarPerfilControl";
            this.editarPerfilControl.Size = new System.Drawing.Size(900, 702);
            this.editarPerfilControl.TabIndex = 13;
            // 
            // perfilControl
            // 
            this.perfilControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.perfilControl.Location = new System.Drawing.Point(219, 54);
            this.perfilControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.perfilControl.Name = "perfilControl";
            this.perfilControl.Size = new System.Drawing.Size(900, 702);
            this.perfilControl.TabIndex = 14;
            // 
            // installacionsControl
            // 
            this.installacionsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.installacionsControl.Location = new System.Drawing.Point(219, 50);
            this.installacionsControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.installacionsControl.Name = "installacionsControl";
            this.installacionsControl.Size = new System.Drawing.Size(979, 702);
            this.installacionsControl.TabIndex = 15;
            // 
            // activitatsControl
            // 
            this.activitatsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.activitatsControl.Location = new System.Drawing.Point(219, 53);
            this.activitatsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activitatsControl.Name = "activitatsControl";
            this.activitatsControl.Size = new System.Drawing.Size(900, 702);
            this.activitatsControl.TabIndex = 16;
            // 
            // sollicitudsControl
            // 
            this.sollicitudsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.sollicitudsControl.Location = new System.Drawing.Point(219, 54);
            this.sollicitudsControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sollicitudsControl.Name = "sollicitudsControl";
            this.sollicitudsControl.Size = new System.Drawing.Size(900, 702);
            this.sollicitudsControl.TabIndex = 17;
            // 
            // exportarControl
            // 
            this.exportarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.exportarControl.Location = new System.Drawing.Point(219, 50);
            this.exportarControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.exportarControl.Name = "exportarControl";
            this.exportarControl.Size = new System.Drawing.Size(900, 702);
            this.exportarControl.TabIndex = 18;
            // 
            // ajudaControl
            // 
            this.ajudaControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.ajudaControl.Location = new System.Drawing.Point(215, 54);
            this.ajudaControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ajudaControl.Name = "ajudaControl";
            this.ajudaControl.Size = new System.Drawing.Size(900, 702);
            this.ajudaControl.TabIndex = 19;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1228, 849);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.perfilControl);
            this.Controls.Add(this.editarPerfilControl);
            this.Controls.Add(this.entitatsControl);
            this.Controls.Add(this.installacionsControl);
            this.Controls.Add(this.activitatsControl);
            this.Controls.Add(this.sollicitudsControl);
            this.Controls.Add(this.exportarControl);
            this.Controls.Add(this.ajudaControl);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Perfil";
            this.Controls.SetChildIndex(this.ajudaControl, 0);
            this.Controls.SetChildIndex(this.exportarControl, 0);
            this.Controls.SetChildIndex(this.sollicitudsControl, 0);
            this.Controls.SetChildIndex(this.activitatsControl, 0);
            this.Controls.SetChildIndex(this.installacionsControl, 0);
            this.Controls.SetChildIndex(this.entitatsControl, 0);
            this.Controls.SetChildIndex(this.editarPerfilControl, 0);
            this.Controls.SetChildIndex(this.perfilControl, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSollicituds;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button buttonInstallacions;
        private System.Windows.Forms.Button buttonActivitats;
        private System.Windows.Forms.Button buttonEntitats;
        private System.Windows.Forms.Button buttonAjuda;
        private System.Windows.Forms.Panel selectorPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private EntitatsControl entitatsControl;
        private EditarPerfilControl editarPerfilControl;
        private PerfilControl perfilControl;
        private InstallacionsControl installacionsControl;
        private Proyecto.ActivitatsControl activitatsControl;
        private Proyecto.SollicitudsControl sollicitudsControl;
        private Proyecto.ExportarControl exportarControl;
        private AjudaControl ajudaControl;
    }
}
