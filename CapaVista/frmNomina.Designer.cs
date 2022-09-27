namespace CapaVista
{
    partial class frmNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.conceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaVista.DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.dateI = new System.Windows.Forms.DateTimePicker();
            this.btnCompletarEncabezado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.codigonominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoconceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valornominaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nominadTableAdapter = new CapaVista.DataSet1TableAdapters.nominadTableAdapter();
            this.empleadoTableAdapter = new CapaVista.DataSet1TableAdapters.empleadoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.conceptoTableAdapter = new CapaVista.DataSet1TableAdapters.conceptoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigonominaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicialnominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinalnominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new CapaVista.DataSet2();
            this.nominaeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominaeTableAdapter = new CapaVista.DataSet1TableAdapters.nominaeTableAdapter();
            this.nominaeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nominaeTableAdapter1 = new CapaVista.DataSet2TableAdapters.nominaeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(554, 232);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 104;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.conceptoBindingSource;
            this.comboBox2.DisplayMember = "nombre_concepto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(601, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 103;
            this.comboBox2.ValueMember = "codigo_concepto";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // conceptoBindingSource
            // 
            this.conceptoBindingSource.DataMember = "concepto";
            this.conceptoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadoBindingSource;
            this.comboBox1.DisplayMember = "nombre_empleado";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(601, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 102;
            this.comboBox1.ValueMember = "codigo_empleado";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.dataSet1;
            // 
            // dateF
            // 
            this.dateF.Location = new System.Drawing.Point(124, 128);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(134, 20);
            this.dateF.TabIndex = 101;
            // 
            // dateI
            // 
            this.dateI.Location = new System.Drawing.Point(124, 99);
            this.dateI.Name = "dateI";
            this.dateI.Size = new System.Drawing.Size(134, 20);
            this.dateI.TabIndex = 100;
            // 
            // btnCompletarEncabezado
            // 
            this.btnCompletarEncabezado.Location = new System.Drawing.Point(52, 186);
            this.btnCompletarEncabezado.Name = "btnCompletarEncabezado";
            this.btnCompletarEncabezado.Size = new System.Drawing.Size(157, 23);
            this.btnCompletarEncabezado.TabIndex = 99;
            this.btnCompletarEncabezado.Text = "Completar Encabezado";
            this.btnCompletarEncabezado.UseVisualStyleBackColor = true;
            this.btnCompletarEncabezado.Click += new System.EventHandler(this.btnCompletarEncabezado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(436, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 98;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigonominaDataGridViewTextBoxColumn,
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.codigoconceptoDataGridViewTextBoxColumn,
            this.valornominaDDataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.nominadBindingSource;
            this.dgProductos.Location = new System.Drawing.Point(541, 277);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(495, 161);
            this.dgProductos.TabIndex = 97;
            // 
            // codigonominaDataGridViewTextBoxColumn
            // 
            this.codigonominaDataGridViewTextBoxColumn.DataPropertyName = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn.HeaderText = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn.Name = "codigonominaDataGridViewTextBoxColumn";
            // 
            // codigoempleadoDataGridViewTextBoxColumn
            // 
            this.codigoempleadoDataGridViewTextBoxColumn.DataPropertyName = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.HeaderText = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.Name = "codigoempleadoDataGridViewTextBoxColumn";
            // 
            // codigoconceptoDataGridViewTextBoxColumn
            // 
            this.codigoconceptoDataGridViewTextBoxColumn.DataPropertyName = "codigo_concepto";
            this.codigoconceptoDataGridViewTextBoxColumn.HeaderText = "codigo_concepto";
            this.codigoconceptoDataGridViewTextBoxColumn.Name = "codigoconceptoDataGridViewTextBoxColumn";
            // 
            // valornominaDDataGridViewTextBoxColumn
            // 
            this.valornominaDDataGridViewTextBoxColumn.DataPropertyName = "valor_nominaD";
            this.valornominaDDataGridViewTextBoxColumn.HeaderText = "valor_nominaD";
            this.valornominaDDataGridViewTextBoxColumn.Name = "valornominaDDataGridViewTextBoxColumn";
            // 
            // nominadBindingSource
            // 
            this.nominadBindingSource.DataMember = "nominad";
            this.nominadBindingSource.DataSource = this.dataSet1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(495, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 29);
            this.label11.TabIndex = 96;
            this.label11.Text = "DETALLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 29);
            this.label10.TabIndex = 95;
            this.label10.Text = "ENCABEZADO";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(601, 176);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(490, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Valor Nomina:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(601, 95);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(490, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Codigo Concepto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(490, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Codigo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(490, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Codigo Nomina";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(124, 151);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(134, 20);
            this.txtStatus.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Fecha Inicial:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(124, 76);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(134, 20);
            this.txtDocumento.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Codigo:";
            // 
            // nominadTableAdapter
            // 
            this.nominadTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(738, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 105;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(738, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 106;
            this.textBox2.Visible = false;
            // 
            // conceptoTableAdapter
            // 
            this.conceptoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigonominaDataGridViewTextBoxColumn1,
            this.fechainicialnominaDataGridViewTextBoxColumn,
            this.fechafinalnominaDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nominaeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 161);
            this.dataGridView1.TabIndex = 107;
            // 
            // codigonominaDataGridViewTextBoxColumn1
            // 
            this.codigonominaDataGridViewTextBoxColumn1.DataPropertyName = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn1.HeaderText = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn1.Name = "codigonominaDataGridViewTextBoxColumn1";
            // 
            // fechainicialnominaDataGridViewTextBoxColumn
            // 
            this.fechainicialnominaDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicial_nomina";
            this.fechainicialnominaDataGridViewTextBoxColumn.HeaderText = "fecha_inicial_nomina";
            this.fechainicialnominaDataGridViewTextBoxColumn.Name = "fechainicialnominaDataGridViewTextBoxColumn";
            // 
            // fechafinalnominaDataGridViewTextBoxColumn
            // 
            this.fechafinalnominaDataGridViewTextBoxColumn.DataPropertyName = "fecha_final_nomina";
            this.fechafinalnominaDataGridViewTextBoxColumn.HeaderText = "fecha_final_nomina";
            this.fechafinalnominaDataGridViewTextBoxColumn.Name = "fechafinalnominaDataGridViewTextBoxColumn";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // nominaeBindingSource2
            // 
            this.nominaeBindingSource2.DataMember = "nominae";
            this.nominaeBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominaeBindingSource
            // 
            this.nominaeBindingSource.DataMember = "nominae";
            this.nominaeBindingSource.DataSource = this.dataSet1;
            // 
            // nominaeTableAdapter
            // 
            this.nominaeTableAdapter.ClearBeforeFill = true;
            // 
            // nominaeBindingSource1
            // 
            this.nominaeBindingSource1.DataMember = "nominae";
            this.nominaeBindingSource1.DataSource = this.dataSet1;
            // 
            // nominaeTableAdapter1
            // 
            this.nominaeTableAdapter1.ClearBeforeFill = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.dateI);
            this.Controls.Add(this.btnCompletarEncabezado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Name = "frmNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNomina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.DateTimePicker dateI;
        private System.Windows.Forms.Button btnCompletarEncabezado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nominadBindingSource;
        private DataSet1TableAdapters.nominadTableAdapter nominadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigonominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoconceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valornominaDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DataSet1TableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource conceptoBindingSource;
        private DataSet1TableAdapters.conceptoTableAdapter conceptoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nominaeBindingSource;
        private DataSet1TableAdapters.nominaeTableAdapter nominaeTableAdapter;
        private System.Windows.Forms.BindingSource nominaeBindingSource1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource nominaeBindingSource2;
        private DataSet2TableAdapters.nominaeTableAdapter nominaeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigonominaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicialnominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalnominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
    }
}