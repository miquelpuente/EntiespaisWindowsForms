namespace EntiEspais.Proyecto
{
    partial class AsignacioSollicitudsControl
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
            this.dataGridVieweAgregar = new System.Windows.Forms.DataGridView();
            this.ColumnHores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAgregarActividad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVieweAgregar
            // 
            this.dataGridVieweAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            this.dataGridVieweAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieweAgregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVieweAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieweAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHores,
            this.ColumnLunes,
            this.ColumnMartes,
            this.ColumnMiercoles,
            this.ColumnJueves,
            this.ColumnViernes,
            this.ColumnSabado,
            this.ColumnDomingo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieweAgregar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVieweAgregar.GridColor = System.Drawing.Color.White;
            this.dataGridVieweAgregar.Location = new System.Drawing.Point(4, 135);
            this.dataGridVieweAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVieweAgregar.Name = "dataGridVieweAgregar";
            this.dataGridVieweAgregar.Size = new System.Drawing.Size(844, 346);
            this.dataGridVieweAgregar.TabIndex = 5;
            // 
            // ColumnHores
            // 
            this.ColumnHores.HeaderText = "Hores";
            this.ColumnHores.Name = "ColumnHores";
            // 
            // ColumnLunes
            // 
            this.ColumnLunes.HeaderText = "dl";
            this.ColumnLunes.Name = "ColumnLunes";
            // 
            // ColumnMartes
            // 
            this.ColumnMartes.HeaderText = "dt";
            this.ColumnMartes.Name = "ColumnMartes";
            // 
            // ColumnMiercoles
            // 
            this.ColumnMiercoles.HeaderText = "dc";
            this.ColumnMiercoles.Name = "ColumnMiercoles";
            // 
            // ColumnJueves
            // 
            this.ColumnJueves.HeaderText = "dj";
            this.ColumnJueves.Name = "ColumnJueves";
            // 
            // ColumnViernes
            // 
            this.ColumnViernes.HeaderText = "dv";
            this.ColumnViernes.Name = "ColumnViernes";
            // 
            // ColumnSabado
            // 
            this.ColumnSabado.HeaderText = "ds";
            this.ColumnSabado.Name = "ColumnSabado";
            // 
            // ColumnDomingo
            // 
            this.ColumnDomingo.HeaderText = "dg";
            this.ColumnDomingo.Name = "ColumnDomingo";
            // 
            // labelAgregarActividad
            // 
            this.labelAgregarActividad.AutoSize = true;
            this.labelAgregarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarActividad.ForeColor = System.Drawing.Color.White;
            this.labelAgregarActividad.Location = new System.Drawing.Point(48, 49);
            this.labelAgregarActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgregarActividad.Name = "labelAgregarActividad";
            this.labelAgregarActividad.Size = new System.Drawing.Size(315, 31);
            this.labelAgregarActividad.TabIndex = 6;
            this.labelAgregarActividad.Text = "AGREGAR ACTIVITAT";
            // 
            // AsignacioSollicitudsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.labelAgregarActividad);
            this.Controls.Add(this.dataGridVieweAgregar);
            this.Name = "AsignacioSollicitudsControl";
            this.Size = new System.Drawing.Size(900, 702);
            this.Load += new System.EventHandler(this.AsignacioSollicitudsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVieweAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDomingo;
        private System.Windows.Forms.Label labelAgregarActividad;
    }
}
