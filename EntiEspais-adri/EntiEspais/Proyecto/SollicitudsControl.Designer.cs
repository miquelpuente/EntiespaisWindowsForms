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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ColumnIntervalHores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiesSetmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAsignada = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelCard = new System.Windows.Forms.Panel();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelRao = new System.Windows.Forms.Label();
            this.labelTelefons = new System.Windows.Forms.Label();
            this.labelAdreçaElectronica = new System.Windows.Forms.Label();
            this.labelNomEntitat = new System.Windows.Forms.Label();
            this.comboBoxNomInstallacions = new System.Windows.Forms.ComboBox();
            this.comboBoxNomEspais = new System.Windows.Forms.ComboBox();
            this.labelInstallacions = new System.Windows.Forms.Label();
            this.labelEspais = new System.Windows.Forms.Label();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.labelHoraris = new System.Windows.Forms.Label();
            this.comboBoxHoraris = new System.Windows.Forms.ComboBox();
            this.dataGridVieweAgregar = new System.Windows.Forms.DataGridView();
            this.ColumnHores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEsborrar = new System.Windows.Forms.Button();
            this.buttonDesar = new System.Windows.Forms.Button();
            this.labelDies = new System.Windows.Forms.Label();
            this.comboBoxDies = new System.Windows.Forms.ComboBox();
            this.bindingSourceActividadesDemandadas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweSollicituds)).BeginInit();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividadesDemandadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVieweSollicituds
            // 
            this.dataGridVieweSollicituds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            this.dataGridVieweSollicituds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieweSollicituds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVieweSollicituds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieweSollicituds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNomActivitat,
            this.ColumnTipus,
            this.ColumnDurada,
            this.ColumnEspai,
            this.ColumnEquip,
            this.ColumnDies,
            this.ColumnIntervalHores,
            this.ColumnDiesSetmana,
            this.ColumnAsignada});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieweSollicituds.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVieweSollicituds.GridColor = System.Drawing.Color.White;
            this.dataGridVieweSollicituds.Location = new System.Drawing.Point(12, 192);
            this.dataGridVieweSollicituds.Name = "dataGridVieweSollicituds";
            this.dataGridVieweSollicituds.Size = new System.Drawing.Size(660, 179);
            this.dataGridVieweSollicituds.TabIndex = 4;
            this.dataGridVieweSollicituds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieweSollicituds_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 35;
            // 
            // ColumnNomActivitat
            // 
            this.ColumnNomActivitat.HeaderText = "Activitat";
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
            // ColumnIntervalHores
            // 
            this.ColumnIntervalHores.HeaderText = "hores";
            this.ColumnIntervalHores.Name = "ColumnIntervalHores";
            // 
            // ColumnDiesSetmana
            // 
            this.ColumnDiesSetmana.HeaderText = "Dia";
            this.ColumnDiesSetmana.Name = "ColumnDiesSetmana";
            // 
            // ColumnAsignada
            // 
            this.ColumnAsignada.HeaderText = "Asignada";
            this.ColumnAsignada.Name = "ColumnAsignada";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(171)))), ((int)(((byte)(164)))));
            this.panelCard.Controls.Add(this.labelNumero);
            this.panelCard.Controls.Add(this.labelRao);
            this.panelCard.Controls.Add(this.labelTelefons);
            this.panelCard.Controls.Add(this.labelAdreçaElectronica);
            this.panelCard.Controls.Add(this.labelNomEntitat);
            this.panelCard.Location = new System.Drawing.Point(12, 6);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(342, 167);
            this.panelCard.TabIndex = 21;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.Color.White;
            this.labelNumero.Location = new System.Drawing.Point(42, 128);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(66, 18);
            this.labelNumero.TabIndex = 8;
            this.labelNumero.Text = "Número:";
            // 
            // labelRao
            // 
            this.labelRao.AutoSize = true;
            this.labelRao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRao.ForeColor = System.Drawing.Color.White;
            this.labelRao.Location = new System.Drawing.Point(43, 104);
            this.labelRao.Name = "labelRao";
            this.labelRao.Size = new System.Drawing.Size(40, 18);
            this.labelRao.TabIndex = 7;
            this.labelRao.Text = "Raò:";
            // 
            // labelTelefons
            // 
            this.labelTelefons.AutoSize = true;
            this.labelTelefons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefons.ForeColor = System.Drawing.Color.White;
            this.labelTelefons.Location = new System.Drawing.Point(22, 80);
            this.labelTelefons.Name = "labelTelefons";
            this.labelTelefons.Size = new System.Drawing.Size(69, 18);
            this.labelTelefons.TabIndex = 6;
            this.labelTelefons.Text = "Telèfons:";
            // 
            // labelAdreçaElectronica
            // 
            this.labelAdreçaElectronica.AutoSize = true;
            this.labelAdreçaElectronica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdreçaElectronica.ForeColor = System.Drawing.Color.White;
            this.labelAdreçaElectronica.Location = new System.Drawing.Point(22, 53);
            this.labelAdreçaElectronica.Name = "labelAdreçaElectronica";
            this.labelAdreçaElectronica.Size = new System.Drawing.Size(134, 18);
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
            // comboBoxNomInstallacions
            // 
            this.comboBoxNomInstallacions.FormattingEnabled = true;
            this.comboBoxNomInstallacions.Location = new System.Drawing.Point(370, 33);
            this.comboBoxNomInstallacions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNomInstallacions.Name = "comboBoxNomInstallacions";
            this.comboBoxNomInstallacions.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNomInstallacions.TabIndex = 22;
            // 
            // comboBoxNomEspais
            // 
            this.comboBoxNomEspais.FormattingEnabled = true;
            this.comboBoxNomEspais.Location = new System.Drawing.Point(370, 81);
            this.comboBoxNomEspais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNomEspais.Name = "comboBoxNomEspais";
            this.comboBoxNomEspais.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNomEspais.TabIndex = 23;
            this.comboBoxNomEspais.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomEspais_SelectedIndexChanged);
            // 
            // labelInstallacions
            // 
            this.labelInstallacions.AutoSize = true;
            this.labelInstallacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallacions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInstallacions.Location = new System.Drawing.Point(372, 7);
            this.labelInstallacions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstallacions.Name = "labelInstallacions";
            this.labelInstallacions.Size = new System.Drawing.Size(116, 24);
            this.labelInstallacions.TabIndex = 24;
            this.labelInstallacions.Text = "Instal·lacions";
            // 
            // labelEspais
            // 
            this.labelEspais.AutoSize = true;
            this.labelEspais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEspais.Location = new System.Drawing.Point(372, 55);
            this.labelEspais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEspais.Name = "labelEspais";
            this.labelEspais.Size = new System.Drawing.Size(66, 24);
            this.labelEspais.TabIndex = 25;
            this.labelEspais.Text = "Espais";
            this.labelEspais.Click += new System.EventHandler(this.labelEspais_Click);
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonAsignar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAsignar.FlatAppearance.BorderSize = 0;
            this.buttonAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonAsignar.ForeColor = System.Drawing.Color.White;
            this.buttonAsignar.Location = new System.Drawing.Point(499, 154);
            this.buttonAsignar.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(159, 33);
            this.buttonAsignar.TabIndex = 26;
            this.buttonAsignar.Text = "ASSIGNAR";
            this.buttonAsignar.UseVisualStyleBackColor = false;
            this.buttonAsignar.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // labelHoraris
            // 
            this.labelHoraris.AutoSize = true;
            this.labelHoraris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHoraris.Location = new System.Drawing.Point(372, 106);
            this.labelHoraris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoraris.Name = "labelHoraris";
            this.labelHoraris.Size = new System.Drawing.Size(70, 24);
            this.labelHoraris.TabIndex = 28;
            this.labelHoraris.Text = "Horaris";
            this.labelHoraris.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxHoraris
            // 
            this.comboBoxHoraris.FormattingEnabled = true;
            this.comboBoxHoraris.Location = new System.Drawing.Point(370, 130);
            this.comboBoxHoraris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHoraris.Name = "comboBoxHoraris";
            this.comboBoxHoraris.Size = new System.Drawing.Size(102, 21);
            this.comboBoxHoraris.TabIndex = 27;
            this.comboBoxHoraris.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridVieweAgregar
            // 
            this.dataGridVieweAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            this.dataGridVieweAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVieweAgregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(142)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVieweAgregar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVieweAgregar.GridColor = System.Drawing.Color.White;
            this.dataGridVieweAgregar.Location = new System.Drawing.Point(12, 384);
            this.dataGridVieweAgregar.Name = "dataGridVieweAgregar";
            this.dataGridVieweAgregar.Size = new System.Drawing.Size(646, 202);
            this.dataGridVieweAgregar.TabIndex = 29;
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
            // buttonEsborrar
            // 
            this.buttonEsborrar.BackColor = System.Drawing.Color.White;
            this.buttonEsborrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEsborrar.FlatAppearance.BorderSize = 0;
            this.buttonEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEsborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonEsborrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonEsborrar.Location = new System.Drawing.Point(315, 597);
            this.buttonEsborrar.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.buttonEsborrar.Name = "buttonEsborrar";
            this.buttonEsborrar.Size = new System.Drawing.Size(157, 41);
            this.buttonEsborrar.TabIndex = 31;
            this.buttonEsborrar.Text = "Esborrar";
            this.buttonEsborrar.UseVisualStyleBackColor = false;
            this.buttonEsborrar.Click += new System.EventHandler(this.buttonEsborrar_Click);
            // 
            // buttonDesar
            // 
            this.buttonDesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.buttonDesar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDesar.FlatAppearance.BorderSize = 0;
            this.buttonDesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F);
            this.buttonDesar.ForeColor = System.Drawing.Color.White;
            this.buttonDesar.Location = new System.Drawing.Point(501, 597);
            this.buttonDesar.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.buttonDesar.Name = "buttonDesar";
            this.buttonDesar.Size = new System.Drawing.Size(157, 41);
            this.buttonDesar.TabIndex = 30;
            this.buttonDesar.Text = "Desar";
            this.buttonDesar.UseVisualStyleBackColor = false;
            // 
            // labelDies
            // 
            this.labelDies.AutoSize = true;
            this.labelDies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDies.Location = new System.Drawing.Point(493, 106);
            this.labelDies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDies.Name = "labelDies";
            this.labelDies.Size = new System.Drawing.Size(47, 24);
            this.labelDies.TabIndex = 33;
            this.labelDies.Text = "Dies";
            // 
            // comboBoxDies
            // 
            this.comboBoxDies.FormattingEnabled = true;
            this.comboBoxDies.Location = new System.Drawing.Point(491, 130);
            this.comboBoxDies.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDies.Name = "comboBoxDies";
            this.comboBoxDies.Size = new System.Drawing.Size(167, 21);
            this.comboBoxDies.TabIndex = 32;
            // 
            // SollicitudsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.labelDies);
            this.Controls.Add(this.comboBoxDies);
            this.Controls.Add(this.buttonEsborrar);
            this.Controls.Add(this.buttonDesar);
            this.Controls.Add(this.dataGridVieweAgregar);
            this.Controls.Add(this.labelHoraris);
            this.Controls.Add(this.comboBoxHoraris);
            this.Controls.Add(this.buttonAsignar);
            this.Controls.Add(this.labelEspais);
            this.Controls.Add(this.labelInstallacions);
            this.Controls.Add(this.comboBoxNomEspais);
            this.Controls.Add(this.comboBoxNomInstallacions);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.dataGridVieweSollicituds);
            this.Name = "SollicitudsControl";
            this.Size = new System.Drawing.Size(675, 653);
            this.Load += new System.EventHandler(this.SollicitudsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweSollicituds)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieweAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividadesDemandadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVieweSollicituds;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelRao;
        private System.Windows.Forms.Label labelTelefons;
        private System.Windows.Forms.Label labelAdreçaElectronica;
        private System.Windows.Forms.Label labelNomEntitat;
        private System.Windows.Forms.ComboBox comboBoxNomInstallacions;
        private System.Windows.Forms.ComboBox comboBoxNomEspais;
        private System.Windows.Forms.Label labelInstallacions;
        private System.Windows.Forms.Label labelEspais;
        private System.Windows.Forms.Button buttonAsignar;
        private System.Windows.Forms.Label labelHoraris;
        private System.Windows.Forms.ComboBox comboBoxHoraris;
        private System.Windows.Forms.DataGridView dataGridVieweAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDomingo;
        private System.Windows.Forms.Button buttonEsborrar;
        private System.Windows.Forms.Button buttonDesar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomActivitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDurada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIntervalHores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiesSetmana;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnAsignada;
        private System.Windows.Forms.Label labelDies;
        private System.Windows.Forms.ComboBox comboBoxDies;
        private System.Windows.Forms.BindingSource bindingSourceActividadesDemandadas;
    }
}
