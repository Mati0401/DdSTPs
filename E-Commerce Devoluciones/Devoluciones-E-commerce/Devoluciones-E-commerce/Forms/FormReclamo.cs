using System.Data;
using System.Data.SqlClient;

namespace Devoluciones_E_commerce
{
    public partial class FormReclamo : Form
    {
        public FormReclamo()
        {

            InitializeComponent();

        }

        private void btnCargarImagenes_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionados no es un tipo de imagen válido");
            }*/
        }

        private SqlConnection conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\matit\OneDrive\Escritorio\Devoluciones-E-commerce\Devoluciones-E-commerce\Base de Datos\DatabaseReclamos.mdf;Integrated Security = True");

        private void btnCargarReclamo_Click(object sender, EventArgs e)
        {

            Reclamo reclamo = new Reclamo();


            reclamo.Tipo = cboTipo.Text;
            reclamo.Motivo = cboMotivo.Text;
            reclamo.Descripcion = txtDescripcion.Text;
            //reclamo.IdCompra = ?;

            reclamo.NuevoReclamo(conexion);

            MessageBox.Show("El reclamo ha sido registrado exitosamente.");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            InicioUsuario inicio = new InicioUsuario();
            inicio.ShowDialog();
            this.Hide();

        }
    }
}