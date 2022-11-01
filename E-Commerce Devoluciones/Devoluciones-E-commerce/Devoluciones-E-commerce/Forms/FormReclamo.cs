using System.Data;
using System.Data.SqlClient;
using FluentValidation;
using FluentValidation.Results;
using System.Linq;

namespace Devoluciones_E_commerce
{
    public partial class FormReclamo : Form
    {
        public FormReclamo()
        {

            InitializeComponent();

        }


        private SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");


        private void btnCargarReclamo_Click(object sender, EventArgs e)
        {

            Reclamo reclamo = new Reclamo();

            reclamo.Tipo = cboTipo.Text;
            reclamo.Motivo = cboMotivo.Text;
            reclamo.Descripcion = txtDescripcion.Text;

            var validarReclamo = new ValidarReclamo();

            ValidationResult result = validarReclamo.Validate(reclamo);

            string errores = "";

            if (result.IsValid)
            {

                reclamo.CargarNuevoReclamo(conexion);

                MessageBox.Show("El reclamo ha sido registrado exitosamente.");

                MisReclamos misReclamos = new MisReclamos();
                misReclamos.Show();
                this.Hide();

            }
            else
            {

                foreach (var error in result.Errors)
                {

                    errores += error.ErrorMessage + Environment.NewLine;

                }

                MessageBox.Show(errores);

            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {

            InicioUsuario inicio = new InicioUsuario();
            inicio.ShowDialog();
            this.Hide();

        }


        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTipo.Text == "Sin Entrega")
            {

                cboMotivo.Items.Clear();
                cboMotivo.Items.Add("No llego el producto");

            }
            else
            {

                cboMotivo.Items.Clear();
                cboMotivo.Items.Add("El producto tiene un problema o está incompleto"); 
                cboMotivo.Items.Add("Es diferente de lo que pediste");
                cboMotivo.Items.Add("Te arrepentiste de comprar el producto");

            }

        }
    }
}