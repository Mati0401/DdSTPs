using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Devoluciones_E_commerce
{
    public partial class DetalleDeCompra : Form
    {

        public DetalleDeCompra()
        {

            InitializeComponent();

        }

        SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");
        
        private void DetalleDeCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHacerReclamo_Click(object sender, EventArgs e)
        {

            FormReclamo formReclamo = new FormReclamo();
            formReclamo.ShowDialog();
            this.Hide();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            MisCompras misCompras = new MisCompras();
            misCompras.ShowDialog();
            this.Hide();

        }

    }
}
