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
    public partial class FormTicket : Form
    {
        public FormTicket()
        {

            InitializeComponent();

        }


        SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");


        private void btnCerrar_Click(object sender, EventArgs e)
        {

            MisReclamos misReclamos = new MisReclamos();
            misReclamos.Show();
            this.Hide();

        }


        int IdReclamoLocal;
        string EstadoReclamoLocal;
        DateTime fechaDeUltimaActualizacion;
        string DescripcionDeCierreLocal;
        DateTime FechaDeCierreLocal;
        string TipoLocal;
        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {

            MisReclamos misReclamos = new MisReclamos();
            Reclamo reclamo = new Reclamo();

            IdReclamoLocal = MisReclamos.IdReclamoL;
            TipoLocal = MisReclamos.TipoL;
            
            EstadoReclamoLocal = reclamo.NuevoEstadoDeReclamo();
            DescripcionDeCierreLocal = reclamo.DescripcionDeCierreCorrespondiente(EstadoReclamoLocal, TipoLocal);

            if (EstadoReclamoLocal == "aprobado" || EstadoReclamoLocal == "desaprobado")
            {

                fechaDeUltimaActualizacion = DateTime.Now;
                FechaDeCierreLocal = DateTime.Now;

                txtFechaDeUltimaActualizacion.Text = fechaDeUltimaActualizacion.ToString();
                txtFechaDeCierre.Text = FechaDeCierreLocal.ToString();
                txtDescripcionDelCierre.Text = DescripcionDeCierreLocal;
                txtEstadoDelTicket.Text = EstadoReclamoLocal;

                btnActualizarEstado.Visible = false;
                txtDescripcionDelCierre.Visible = true;
                lblDescripcionDelCierre.Visible = true;

            }
            else
            {
                fechaDeUltimaActualizacion = DateTime.Now;
                txtFechaDeUltimaActualizacion.Text = fechaDeUltimaActualizacion.ToString();
                txtDescripcionDelCierre.Text = DescripcionDeCierreLocal;
                txtEstadoDelTicket.Text = EstadoReclamoLocal;
                FechaDeCierreLocal = new DateTime(0001, 01, 01);
            }
            
            string modificarReclamo = "UPDATE Reclamo SET EstadoReclamo = @var1, FechaDeUltimaActualizacion = @var2 ,FechaDeCierre = @var3 , DescripcionDeCierre = @var4 WHERE IdReclamo = @var5";

            SqlCommand cmd = new SqlCommand(modificarReclamo, conexion);
            cmd.Parameters.Add("@var1", SqlDbType.NVarChar).Value = EstadoReclamoLocal;
            cmd.Parameters.Add("@var2", SqlDbType.DateTime).Value = fechaDeUltimaActualizacion;
            cmd.Parameters.Add("@var3", SqlDbType.DateTime).Value = FechaDeCierreLocal;
            cmd.Parameters.Add("@var4", SqlDbType.NVarChar).Value = DescripcionDeCierreLocal;
            cmd.Parameters.Add("@var5", SqlDbType.Int).Value = IdReclamoLocal;


            conexion.Open();

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        private void FormTicket_Load(object sender, EventArgs e)
        {

            txtDescripcionDelCierre.Visible = false;
            lblDescripcionDelCierre.Visible = false;

            MisReclamos misReclamos = new MisReclamos();

            EstadoReclamoLocal = MisReclamos.EstadoDelTicketL;

            txtEstadoDelTicket.Text = MisReclamos.EstadoDelTicketL;
            txtFechaDeApertura.Text = MisReclamos.FechaDeAperturaL.ToString();
            txtIdReclamo.Text = MisReclamos.IdReclamoL.ToString();

            if (EstadoReclamoLocal == "aprobado" || EstadoReclamoLocal == "desaprobado")
            {

                txtFechaDeUltimaActualizacion.Text = MisReclamos.FechaDeUltimaActualizacionL.ToString();
                txtFechaDeCierre.Text = MisReclamos.FechaDeCierreL.ToString();
                txtDescripcionDelCierre.Text = MisReclamos.DescripcionDelCierreL;
                txtEstadoDelTicket.Text = EstadoReclamoLocal;

                btnActualizarEstado.Visible = false;
                txtDescripcionDelCierre.Visible = true;
                lblDescripcionDelCierre.Visible = true;

            }

        }

    }
}
