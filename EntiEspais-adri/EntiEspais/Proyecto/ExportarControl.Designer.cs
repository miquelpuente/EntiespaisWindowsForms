namespace EntiEspais.Proyecto
{
    partial class ExportarControl
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
            this.buttonExpPdf = new System.Windows.Forms.Button();
            this.buttonExpCsv = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExpPdf
            // 
            this.buttonExpPdf.BackColor = System.Drawing.Color.White;
            this.buttonExpPdf.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExpPdf.FlatAppearance.BorderSize = 0;
            this.buttonExpPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonExpPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonExpPdf.Location = new System.Drawing.Point(205, 229);
            this.buttonExpPdf.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.buttonExpPdf.Name = "buttonExpPdf";
            this.buttonExpPdf.Size = new System.Drawing.Size(474, 50);
            this.buttonExpPdf.TabIndex = 27;
            this.buttonExpPdf.Text = "Exportar PDF";
            this.buttonExpPdf.UseVisualStyleBackColor = false;
            // 
            // buttonExpCsv
            // 
            this.buttonExpCsv.BackColor = System.Drawing.Color.White;
            this.buttonExpCsv.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExpCsv.FlatAppearance.BorderSize = 0;
            this.buttonExpCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonExpCsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonExpCsv.Location = new System.Drawing.Point(205, 306);
            this.buttonExpCsv.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.buttonExpCsv.Name = "buttonExpCsv";
            this.buttonExpCsv.Size = new System.Drawing.Size(474, 50);
            this.buttonExpCsv.TabIndex = 28;
            this.buttonExpCsv.Text = "Exportar CSV";
            this.buttonExpCsv.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.White;
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonImprimir.Location = new System.Drawing.Point(205, 386);
            this.buttonImprimir.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(474, 50);
            this.buttonImprimir.TabIndex = 29;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // ExportarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonExpCsv);
            this.Controls.Add(this.buttonExpPdf);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExportarControl";
            this.Size = new System.Drawing.Size(900, 702);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExpPdf;
        private System.Windows.Forms.Button buttonExpCsv;
        private System.Windows.Forms.Button buttonImprimir;
    }
}
