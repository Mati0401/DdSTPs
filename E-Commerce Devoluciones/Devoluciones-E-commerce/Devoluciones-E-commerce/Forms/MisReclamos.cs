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
    public partial class MisReclamos : Form
    {
        public MisReclamos()
        {

            InitializeComponent();

        }


        SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");


        private void btnAtras_Click(object sender, EventArgs e)
        {

            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();

        }


        private void MisReclamos_Load(object sender, EventArgs e)
        {

            string consulta = "SELECT * FROM Reclamo ORDER BY Fecha DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvReclamos.DataSource = dt;

            dgvReclamos.Columns[7].Visible = false;
            dgvReclamos.Columns[8].Visible = false;
            dgvReclamos.Columns[9].Visible = false;

        }


        public static string EstadoDelTicketL;
        public static DateTime FechaDeAperturaL;
        public static int IdReclamoL;
        public static DateTime FechaDeCierreL;
        public static DateTime FechaDeUltimaActualizacionL;
        public static string DescripcionDelCierreL;
        public static string TipoL;
        private void dgvReclamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IdReclamoL = Convert.ToInt32(this.dgvReclamos.SelectedRows[0].Cells[0].Value);
            FechaDeAperturaL = Convert.ToDateTime(this.dgvReclamos.SelectedRows[0].Cells[1].Value);
            EstadoDelTicketL = Convert.ToString(this.dgvReclamos.SelectedRows[0].Cells[6].Value);
            TipoL = Convert.ToString(this.dgvReclamos.SelectedRows[0].Cells[3].Value);
            FechaDeUltimaActualizacionL = Convert.ToDateTime(this.dgvReclamos.SelectedRows[0].Cells[7].Value);
            FechaDeCierreL = Convert.ToDateTime(this.dgvReclamos.SelectedRows[0].Cells[8].Value);
            DescripcionDelCierreL = Convert.ToString(this.dgvReclamos.SelectedRows[0].Cells[9].Value);

            FormTicket formTicket = new FormTicket();
            formTicket.Show();
            this.Hide();

        }

    }
}
