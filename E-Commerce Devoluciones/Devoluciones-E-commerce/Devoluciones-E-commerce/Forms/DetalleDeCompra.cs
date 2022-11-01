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

            CompraTieneReclamo();

            if (YaExisteReclamoParaEstaCompra)
            {

                MessageBox.Show("Esta compra ya tiene un reclamo realizado.");
                btnHacerReclamo.Visible = false; 

            }
            else
            {

                FormReclamo formReclamo = new FormReclamo();
                formReclamo.ShowDialog();
                this.Hide();

            }

        }


        private void btnAtras_Click(object sender, EventArgs e)
        {

            MisCompras misCompras = new MisCompras();
            misCompras.ShowDialog();
            this.Hide();

        }


        bool YaExisteReclamoParaEstaCompra = false;
        public bool CompraTieneReclamo()
        {

            int IdCompraParaValidar = Reclamo.IdCompra;

            string consulta = "SELECT * FROM Reclamo WHERE IdCompra = " + IdCompraParaValidar;

            conexion.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count >= 1)
            {

                YaExisteReclamoParaEstaCompra = true;

            }

            conexion.Close();

            return YaExisteReclamoParaEstaCompra;

        }

    }
}
