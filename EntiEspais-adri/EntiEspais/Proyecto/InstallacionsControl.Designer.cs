namespace EntiEspais.Plantilla
{
    partial class InstallacionsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInstalacions = new System.Windows.Forms.DataGridView();
            this.ColumnNomInst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalacions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInstalacions
            // 
            this.dataGridViewInstalacions.AllowUserToAddRows = false;
            this.dataGridViewInstalacions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstalacions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInstalacions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.dataGridViewInstalacions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInstalacions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstalacions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewInstalacions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstalacions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomInst,
            this.ColumnDireccio});
            this.dataGridViewInstalacions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewInstalacions.Location = new System.Drawing.Point(81, 115);
            this.dataGridViewInstalacions.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInstalacions.Name = "dataGridViewInstalacions";
            this.dataGridViewInstalacions.ReadOnly = true;
            this.dataGridViewInstalacions.RowHeadersVisible = false;
            this.dataGridViewInstalacions.RowTemplate.Height = 24;
            this.dataGridViewInstalacions.Size = new System.Drawing.Size(622, 453);
            this.dataGridViewInstalacions.TabIndex = 0;
            // 
            // ColumnNomInst
            // 
            this.ColumnNomInst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ColumnNomInst.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnNomInst.DividerWidth = 2;
            this.ColumnNomInst.HeaderText = "Nom instalació";
            this.ColumnNomInst.Name = "ColumnNomInst";
            this.ColumnNomInst.ReadOnly = true;
            this.ColumnNomInst.Width = 164;
            // 
            // ColumnDireccio
            // 
            this.ColumnDireccio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnDireccio.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDireccio.HeaderText = "Adreça";
            this.ColumnDireccio.Name = "ColumnDireccio";
            this.ColumnDireccio.ReadOnly = true;
            this.ColumnDireccio.Width = 105;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonAfegir.FlatAppearance.BorderSize = 0;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonAfegir.ForeColor = System.Drawing.Color.White;
            this.buttonAfegir.Location = new System.Drawing.Point(401, 57);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(119, 35);
            this.buttonAfegir.TabIndex = 1;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(525, 57);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(119, 35);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // InstallacionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.dataGridViewInstalacions);
            this.Name = "InstallacionsControl";
            this.Size = new System.Drawing.Size(734, 570);
            this.Load += new System.EventHandler(this.InstallacionsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalacions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInstalacions;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomInst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccio;
    }
}
