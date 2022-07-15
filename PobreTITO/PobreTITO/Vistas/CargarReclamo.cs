using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    public partial class CargarReclamo : Form
    {
        public CargarReclamo()
        {
            InitializeComponent();
        }
        private void LlenarIncidentes()
        {
            DataTable tabla = Program.gpt.BuscarIncidentes();
            cboIncidente.ValueMember = "Id";
            cboIncidente.DisplayMember = "tipo";
            cboIncidente.DataSource = tabla;
        }

        private void LlenarSubincidentes(int id)
        {
            DataTable tabla = Program.gpt.BuscarSubIncidentes(id);
            cboSubIncidente.ValueMember = "Id";
            cboSubIncidente.DisplayMember = "tipo";
            cboSubIncidente.DataSource = tabla;
        }
        private void cboIncidente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)cboIncidente.SelectedValue;
            if ((int)cboIncidente.SelectedIndex != -1)
            {
                LlenarSubincidentes(id);
            }
        }
        private void CargarReclamo_Load(object sender, EventArgs e)
        {
            LlenarIncidentes();
        }
        private void CargarReclamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtDireccion))
            {
                errorProv.SetError(txtDireccion, "Este campo no puede estar vacío");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtDireccion))
            {
                errorProv.SetError(txtDireccion, "Este campo no puede estar vacío");
            }
            else
            {
                errorProv.Clear();
                Program.gpt.GestionarReclamo((int)cboSubIncidente.SelectedValue, txtDireccion.Text, txtDescripcion.Text);
            }
        }
    }
}
