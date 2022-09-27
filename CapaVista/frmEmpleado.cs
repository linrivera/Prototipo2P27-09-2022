using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmEmpleado : Form
    {
        Controlador con = new Controlador(); 
        public frmEmpleado()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSet1.empleado);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                con.insertarEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, float.Parse(textBox5.Text), textBox6.Text);
                // conPuesto.insertarAplicacion(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), " ");
                MessageBox.Show("Insercion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            actualizarTabla();
        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "0";
        }

        public void actualizarTabla()
        {
            try
            {
                this.empleadoTableAdapter.Fill(this.dataSet1.empleado);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.puesto' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSet1.empleado);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            

            if (textBox6.Text == "1")
            {
                btnHabilitado.Checked = true;
            }
            else if (textBox6.Text == "0")
            {
                btnInhabilitado.Checked = true;
            }
        }

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
            textBox6.Text = "";

        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                con.modificarEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, float.Parse(textBox5.Text), textBox6.Text);
                // conPuesto.insertarAplicacion(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), " ");
                MessageBox.Show("Modificacion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            actualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                con.eliminarEmpleado(textBox1.Text);
                // conPuesto.insertarAplicacion(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), " ");
                MessageBox.Show("Eliminacion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            actualizarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
