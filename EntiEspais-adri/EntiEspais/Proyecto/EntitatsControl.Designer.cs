namespace EntiEspais.Plantilla
{
    partial class EntitatsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitatsControl));
            this.dataGridVieweEntitats = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomEntitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonIniciarSessio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweEntitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVieweEntitats
            // 
            this.dataGridVieweEntitats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            this.dataGridVieweEntitats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieweEntitats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVieweEntitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieweEntitats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNomEntitat,
            this.ColumnNIF});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieweEntitats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVieweEntitats.GridColor = System.Drawing.Color.White;
            this.dataGridVieweEntitats.Location = new System.Drawing.Point(68, 118);
            this.dataGridVieweEntitats.Name = "dataGridVieweEntitats";
            this.dataGridVieweEntitats.Size = new System.Drawing.Size(542, 224);
            this.dataGridVieweEntitats.TabIndex = 3;
            this.dataGridVieweEntitats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieweEntitats_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 150;
            // 
            // ColumnNomEntitat
            // 
            this.ColumnNomEntitat.HeaderText = "Nom Entitat";
            this.ColumnNomEntitat.Name = "ColumnNomEntitat";
            this.ColumnNomEntitat.Width = 200;
            // 
            // ColumnNIF
            // 
            this.ColumnNIF.HeaderText = "NIF";
            this.ColumnNIF.Name = "ColumnNIF";
            this.ColumnNIF.Width = 150;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.textBoxBuscador.Location = new System.Drawing.Point(155, 25);
            this.textBoxBuscador.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(279, 26);
            this.textBoxBuscador.TabIndex = 12;
            this.textBoxBuscador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscador_MouseClick);
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            this.textBoxBuscador.MouseLeave += new System.EventHandler(this.textBoxBuscador_MouseLeave);
            // 
            // buttonIniciarSessio
            // 
            this.buttonIniciarSessio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonIniciarSessio.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonIniciarSessio.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSessio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSessio.Location = new System.Drawing.Point(444, 22);
            this.buttonIniciarSessio.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.buttonIniciarSessio.Name = "buttonIniciarSessio";
            this.buttonIniciarSessio.Size = new System.Drawing.Size(95, 33);
            this.buttonIniciarSessio.TabIndex = 19;
            this.buttonIniciarSessio.Text = " Buscar";
            this.buttonIniciarSessio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EntitatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.buttonIniciarSessio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.dataGridVieweEntitats);
            this.Name = "EntitatsControl";
            this.Size = new System.Drawing.Size(675, 570);
            this.Load += new System.EventHandler(this.EntitatsControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EntitatsControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweEntitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridVieweEntitats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomEntitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNIF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonIniciarSessio;
    }
}
