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
    public partial class MisCompras : Form
    {
        public MisCompras()
        {

            InitializeComponent();

        }


        // ATRIBUTOS DE COMPRA
        public int IdProducto;
        public string NombreDelProducto;
        public DateTime Fecha;
        public string Estado;
        public double PrecioDelProducto;
        public double PrecioDelEnvio;
        public string MetodoDePago;
        public string Caracteristicas;


        SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");


        private void btnAtras_Click(object sender, EventArgs e)
        {

            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();

        }


        private void MisCompras_Load(object sender, EventArgs e)
        {

            // Fecha, Nombre del Producto, Estado y Precio del Producto
            string consulta = "SELECT * FROM Compras ORDER BY Fecha DESC";  
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCompras.DataSource = dt;

            dgvCompras.Columns[1].Visible = false;
            dgvCompras.Columns[6].Visible = false;
            dgvCompras.Columns[7].Visible = false;
            dgvCompras.Columns[8].Visible = false;

        }


        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Reclamo.IdCompra = Convert.ToInt32(this.dgvCompras.SelectedRows[0].Cells[0].Value);
            IdProducto = Convert.ToInt32(this.dgvCompras.SelectedRows[0].Cells[1].Value);
            Fecha = Convert.ToDateTime(this.dgvCompras.SelectedRows[0].Cells[3].Value);
            NombreDelProducto = Convert.ToString(this.dgvCompras.SelectedRows[0].Cells[2].Value);
            Estado = Convert.ToString(this.dgvCompras.SelectedRows[0].Cells[4].Value);
            PrecioDelProducto = Convert.ToDouble(this.dgvCompras.SelectedRows[0].Cells[5].Value);
            PrecioDelEnvio = Convert.ToDouble(this.dgvCompras.SelectedRows[0].Cells[6].Value);
            MetodoDePago = Convert.ToString(this.dgvCompras.SelectedRows[0].Cells[7].Value);
            Caracteristicas = Convert.ToString(this.dgvCompras.SelectedRows[0].Cells[8].Value);

            DetalleDeCompra detalleDeCompra = new DetalleDeCompra();

            double total = PrecioDelProducto + PrecioDelEnvio;

            detalleDeCompra.txtNombreDelProducto.Text = NombreDelProducto;
            detalleDeCompra.txtFecha.Text = Fecha.ToShortDateString();
            detalleDeCompra.txtPrecioProducto.Text = "$ " + PrecioDelProducto.ToString();
            detalleDeCompra.txtIdCompra.Text = Reclamo.IdCompra.ToString();
            detalleDeCompra.txtEnvio.Text = "$ " + PrecioDelEnvio.ToString();
            detalleDeCompra.txtMetodoDePago.Text = MetodoDePago;
            detalleDeCompra.txtCaracteristicas.Text = Caracteristicas;
            detalleDeCompra.txtEstadoDeLaCompra.Text = Estado;
            detalleDeCompra.txtTotal.Text = "$ " + total;

            detalleDeCompra.Show();
            this.Hide();

        }

    }
}
