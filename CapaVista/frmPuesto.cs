﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;



namespace CapaVista
{
    public partial class frmPuesto : Form
    {

        Controlador con = new Controlador();

        public frmPuesto()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
            textBox3.Text = "";

        }



        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void frmMantenimientoAplicacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.aplicacion' Puede moverla o quitarla según sea necesario.
            //this.aplicacionTableAdapter1.Fill(this.dataSet1.aplicacion);
            // TODO: esta línea de código carga datos en la tabla 'componenteseguridadDataSet.aplicacion' Puede moverla o quitarla según sea necesario.
            try
            {
               this.puestoTableAdapter.Fill(this.dataSet1.puesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (textBox3.Text == "1")
            {
                btnHabilitado.Checked = true;
            }
            else if (textBox3.Text == "0")
            {
                btnInhabilitado.Checked = true;
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               con.modificarPuesto(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                MessageBox.Show("Modificacion realizada");
                funLimpiar();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               con.eliminarPuesto(textBox1.Text);
                MessageBox.Show("Eliminacion realizada");
                funLimpiar();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }


        public void actualizarTabla()
        {
            try
            {
               this.puestoTableAdapter.Fill(this.dataSet1.puesto);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (textBox3.Text == "1")
            {
                btnHabilitado.Checked = true;
            }
            else if (textBox3.Text == "0")
            {
                btnInhabilitado.Checked = true;
            }
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.puesto' Puede moverla o quitarla según sea necesario.
           // this.puestoTableAdapter.Fill(this.dataSet2.puesto);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {

               con.insertarPuesto(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                MessageBox.Show("Insercion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            actualizarTabla();
        }

        private void frmPuesto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.puesto' Puede moverla o quitarla según sea necesario.
            this.puestoTableAdapter.Fill(this.dataSet1.puesto);

        }

        
    }
}
