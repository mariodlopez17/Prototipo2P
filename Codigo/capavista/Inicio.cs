using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos rep = new Productos();
            rep.MdiParent = this;
            rep.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores rep = new Proveedores();
            rep.MdiParent = this;
            rep.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordcompra rep = new Ordcompra();
            rep.MdiParent = this;
            rep.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vcompras rep = new Vcompras();
            rep.MdiParent = this;
            rep.Show();
        }
    }
}
