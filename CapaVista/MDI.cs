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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPuesto forma = new frmPuesto();
            forma.MdiParent = this;

            forma.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado forma = new frmEmpleado();
            forma.MdiParent = this;

            forma.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomina forma = new frmNomina();
            forma.MdiParent = this;

            forma.Show();
        }
    }
}
