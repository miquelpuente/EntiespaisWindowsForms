namespace EntiEspais.Proyecto
{
    partial class SollicitudsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVieweSollicituds = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomActivitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDurada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAsignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIntervalHores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiesSetmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCard = new System.Windows.Forms.Panel();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelRao = new System.Windows.Forms.Label();
            this.labelTelefons = new System.Windows.Forms.Label();
            this.labelAdreçaElectronica = new System.Windows.Forms.Label();
            this.labelNomEntitat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweSollicituds)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVieweSollicituds
            // 
            this.dataGridVieweSollicituds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            this.dataGridVieweSollicituds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieweSollicituds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVieweSollicituds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieweSollicituds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNomActivitat,
            this.ColumnTipus,
            this.ColumnDurada,
            this.ColumnEspai,
            this.ColumnEquip,
            this.ColumnDies,
            this.ColumnAsignada,
            this.ColumnIntervalHores,
            this.ColumnDiesSetmana});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieweSollicituds.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVieweSollicituds.GridColor = System.Drawing.Color.White;
            this.dataGridVieweSollicituds.Location = new System.Drawing.Point(12, 223);
            this.dataGridVieweSollicituds.Name = "dataGridVieweSollicituds";
            this.dataGridVieweSollicituds.Size = new System.Drawing.Size(646, 305);
            this.dataGridVieweSollicituds.TabIndex = 4;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 35;
            // 
            // ColumnNomActivitat
            // 
            this.ColumnNomActivitat.HeaderText = "Nom activitat";
            this.ColumnNomActivitat.Name = "ColumnNomActivitat";
            // 
            // ColumnTipus
            // 
            this.ColumnTipus.HeaderText = "Tipus";
            this.ColumnTipus.Name = "ColumnTipus";
            // 
            // ColumnDurada
            // 
            this.ColumnDurada.HeaderText = "Durada";
            this.ColumnDurada.Name = "ColumnDurada";
            // 
            // ColumnEspai
            // 
            this.ColumnEspai.HeaderText = "Espai";
            this.ColumnEspai.Name = "ColumnEspai";
            // 
            // ColumnEquip
            // 
            this.ColumnEquip.HeaderText = "Equip";
            this.ColumnEquip.Name = "ColumnEquip";
            // 
            // ColumnDies
            // 
            this.ColumnDies.HeaderText = "Dies";
            this.ColumnDies.Name = "ColumnDies";
            // 
            // ColumnAsignada
            // 
            this.ColumnAsignada.HeaderText = "Asignada";
            this.ColumnAsignada.Name = "ColumnAsignada";
            // 
            // ColumnIntervalHores
            // 
            this.ColumnIntervalHores.HeaderText = "Interval d\'hores";
            this.ColumnIntervalHores.Name = "ColumnIntervalHores";
            // 
            // ColumnDiesSetmana
            // 
            this.ColumnDiesSetmana.HeaderText = "Dies de la setmana";
            this.ColumnDiesSetmana.Name = "ColumnDiesSetmana";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(171)))), ((int)(((byte)(164)))));
            this.panelCard.Controls.Add(this.labelNumero);
            this.panelCard.Controls.Add(this.labelRao);
            this.panelCard.Controls.Add(this.labelTelefons);
            this.panelCard.Controls.Add(this.labelAdreçaElectronica);
            this.panelCard.Controls.Add(this.labelNomEntitat);
            this.panelCard.Location = new System.Drawing.Point(23, 49);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(599, 154);
            this.panelCard.TabIndex = 21;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.ForeColor = System.Drawing.Color.White;
            this.labelNumero.Location = new System.Drawing.Point(42, 120);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 8;
            this.labelNumero.Text = "Número:";
            // 
            // labelRao
            // 
            this.labelRao.AutoSize = true;
            this.labelRao.ForeColor = System.Drawing.Color.White;
            this.labelRao.Location = new System.Drawing.Point(43, 102);
            this.labelRao.Name = "labelRao";
            this.labelRao.Size = new System.Drawing.Size(30, 13);
            this.labelRao.TabIndex = 7;
            this.labelRao.Text = "Raò:";
            // 
            // labelTelefons
            // 
            this.labelTelefons.AutoSize = true;
            this.labelTelefons.ForeColor = System.Drawing.Color.White;
            this.labelTelefons.Location = new System.Drawing.Point(22, 80);
            this.labelTelefons.Name = "labelTelefons";
            this.labelTelefons.Size = new System.Drawing.Size(51, 13);
            this.labelTelefons.TabIndex = 6;
            this.labelTelefons.Text = "Telèfons:";
            // 
            // labelAdreçaElectronica
            // 
            this.labelAdreçaElectronica.AutoSize = true;
            this.labelAdreçaElectronica.ForeColor = System.Drawing.Color.White;
            this.labelAdreçaElectronica.Location = new System.Drawing.Point(22, 53);
            this.labelAdreçaElectronica.Name = "labelAdreçaElectronica";
            this.labelAdreçaElectronica.Size = new System.Drawing.Size(99, 13);
            this.labelAdreçaElectronica.TabIndex = 5;
            this.labelAdreçaElectronica.Text = "Adreça elèctronica:";
            // 
            // labelNomEntitat
            // 
            this.labelNomEntitat.AutoSize = true;
            this.labelNomEntitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEntitat.ForeColor = System.Drawing.Color.White;
            this.labelNomEntitat.Location = new System.Drawing.Point(56, 14);
            this.labelNomEntitat.Name = "labelNomEntitat";
            this.labelNomEntitat.Size = new System.Drawing.Size(165, 25);
            this.labelNomEntitat.TabIndex = 0;
            this.labelNomEntitat.Text = "NOM ENTITAT";
            // 
            // SollicitudsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.dataGridVieweSollicituds);
            this.Name = "SollicitudsControl";
            this.Size = new System.Drawing.Size(675, 570);
            this.Load += new System.EventHandler(this.SollicitudsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweSollicituds)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVieweSollicituds;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelRao;
        private System.Windows.Forms.Label labelTelefons;
        private System.Windows.Forms.Label labelAdreçaElectronica;
        private System.Windows.Forms.Label labelNomEntitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomActivitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDurada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIntervalHores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiesSetmana;
    }
}
