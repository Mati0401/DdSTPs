using Devoluciones_E_commerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devoluciones_E_commerce
{
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }


        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MisCompras miscompras = new MisCompras();
            miscompras.ShowDialog();
            this.Hide();

        }


        private void misReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MisReclamos misreclamos = new MisReclamos();
            misreclamos.ShowDialog();
            this.Hide();

        }
    }
}
