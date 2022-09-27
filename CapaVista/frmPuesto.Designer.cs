namespace CapaVista
{
    partial class frmPuesto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigopuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatuspuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaVista.DataSet1();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.btnInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnHabilitado = new System.Windows.Forms.RadioButton();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.puestoTableAdapter = new CapaVista.DataSet1TableAdapters.puestoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigopuestoDataGridViewTextBoxColumn,
            this.nombrepuestoDataGridViewTextBoxColumn,
            this.estatuspuestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.puestoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(144, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // codigopuestoDataGridViewTextBoxColumn
            // 
            this.codigopuestoDataGridViewTextBoxColumn.DataPropertyName = "codigo_puesto";
            this.codigopuestoDataGridViewTextBoxColumn.HeaderText = "codigo_puesto";
            this.codigopuestoDataGridViewTextBoxColumn.Name = "codigopuestoDataGridViewTextBoxColumn";
            // 
            // nombrepuestoDataGridViewTextBoxColumn
            // 
            this.nombrepuestoDataGridViewTextBoxColumn.DataPropertyName = "nombre_puesto";
            this.nombrepuestoDataGridViewTextBoxColumn.HeaderText = "nombre_puesto";
            this.nombrepuestoDataGridViewTextBoxColumn.Name = "nombrepuestoDataGridViewTextBoxColumn";
            // 
            // estatuspuestoDataGridViewTextBoxColumn
            // 
            this.estatuspuestoDataGridViewTextBoxColumn.DataPropertyName = "estatus_puesto";
            this.estatuspuestoDataGridViewTextBoxColumn.HeaderText = "estatus_puesto";
            this.estatuspuestoDataGridViewTextBoxColumn.Name = "estatuspuestoDataGridViewTextBoxColumn";
            // 
            // puestoBindingSource
            // 
            this.puestoBindingSource.DataMember = "puesto";
            this.puestoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(520, 211);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 59;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(374, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(237, 211);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(726, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 51;
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.gbxEstado.Controls.Add(this.btnInhabilitado);
            this.gbxEstado.Controls.Add(this.btnHabilitado);
            this.gbxEstado.Location = new System.Drawing.Point(520, 34);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(200, 100);
            this.gbxEstado.TabIndex = 55;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado Puesto";
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.Location = new System.Drawing.Point(115, 41);
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.btnInhabilitado.TabIndex = 4;
            this.btnInhabilitado.TabStop = true;
            this.btnInhabilitado.Text = "Inhabilitado";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            this.btnInhabilitado.CheckedChanged += new System.EventHandler(this.btnInhabilitado_CheckedChanged);
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.Location = new System.Drawing.Point(7, 41);
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.btnHabilitado.TabIndex = 3;
            this.btnHabilitado.TabStop = true;
            this.btnHabilitado.Text = "Habilitado";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            this.btnHabilitado.CheckedChanged += new System.EventHandler(this.btnHabilitado_CheckedChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(106, 211);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 52;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 50;
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(132, 90);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(83, 13);
            this.labelNombreaplicacion.TabIndex = 54;
            this.labelNombreaplicacion.Text = "Nombre Puesto:";
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(132, 52);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(40, 13);
            this.labelIdaplicacion.TabIndex = 53;
            this.labelIdaplicacion.Text = "Codigo";
            // 
            // puestoTableAdapter
            // 
            this.puestoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Name = "frmPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPuesto";
            this.Load += new System.EventHandler(this.frmPuesto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton btnInhabilitado;
        private System.Windows.Forms.RadioButton btnHabilitado;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombreaplicacion;
        private System.Windows.Forms.Label labelIdaplicacion;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource puestoBindingSource;
        private DataSet1TableAdapters.puestoTableAdapter puestoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatuspuestoDataGridViewTextBoxColumn;
    }
}