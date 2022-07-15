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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }
        private void verContraseña_Click(object sender, EventArgs e)
        {
            ocultarContraseña.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }
        private void ocultarContraseña_Click(object sender, EventArgs e)
        {
            verContraseña.BringToFront();
            txtContraseña.PasswordChar = '*';
        }
        private void txtNombreDeUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtNombreDeUsuario))
            {
                errorProv.SetError(txtNombreDeUsuario, "No puede dejar este campo vacío");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtContraseña))
            {
                errorProv.SetError(txtContraseña, "No puede dejar este campo vacío");
            }
            else
            {
                errorProv.Clear();
            }
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool validar = Program.gpt.VerificarInicioSesion(txtNombreDeUsuario.Text, txtContraseña.Text);
            if (validar)
            {
                Program.cr.ShowDialog();
                this.Hide();
            }
        }
        private void IniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
    }
}

