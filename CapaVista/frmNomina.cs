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
    public partial class frmNomina : Form
    {
        Controlador con = new Controlador();
        public frmNomina()
        {
            InitializeComponent();
            actualizarTabla();
            CenterToScreen();
        }

        private void btnCompletarEncabezado_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaI = dateI.Value.ToString("yyyy-MM-dd");
                string fechaF = dateF.Value.ToString("yyyy-MM-dd");

                txtCodigo.Text = txtDocumento.Text;

                con.insertarEncabezado(txtDocumento.Text, fechaI, fechaF, int.Parse(txtStatus.Text));
                MessageBox.Show("Encabezado guardado con éxito");

                txtDocumento.Enabled = false;
                dateI.Enabled = false;
                dateF.Enabled = false;
                txtStatus.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.nominae' Puede moverla o quitarla según sea necesario.
            this.nominaeTableAdapter1.Fill(this.dataSet2.nominae);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.nominae' Puede moverla o quitarla según sea necesario.
            this.nominaeTableAdapter.Fill(this.dataSet1.nominae);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.concepto' Puede moverla o quitarla según sea necesario.
            this.conceptoTableAdapter.Fill(this.dataSet1.concepto);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSet1.empleado);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.nominad' Puede moverla o quitarla según sea necesario.
            this.nominadTableAdapter.Fill(this.dataSet1.nominad);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue.ToString() == null)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = comboBox2.SelectedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedValue.ToString() == null)
                {
                    textBox2.Text = "";
                }
                else
                {
                    textBox2.Text = comboBox2.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
              
                con.insertarDetalle(txtCodigo.Text, textBox1.Text, textBox2.Text, float.Parse(txtValor.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            MessageBox.Show("Detalle guardado correctamente");
            actualizarTabla();

            
            txtValor.Text = "";
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
        }

        public void actualizarTabla()
        {
            try
            {
                this.nominadTableAdapter.Fill(this.dataSet1.nominad);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        public void actualizarTabla2()
        {
            try
            {
                this.nominaeTableAdapter1.Fill(this.dataSet2.nominae);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            txtDocumento.Enabled = true;
            dateI.Enabled = true;
            dateF.Enabled = true;
            txtStatus.Enabled = true;

            txtDocumento.Text = "";
            txtStatus.Text = "";
            txtCodigo.Text = "";
            MessageBox.Show("Nomina Finalizada con Éxito");
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
