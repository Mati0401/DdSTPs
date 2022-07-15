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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            txtContrase�a.PasswordChar = '*';
            txtContraRepetida.PasswordChar = '*';
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listaResultados = Program.gpt.VerificarRegistro(txtDni.Text, txtNombreYapellido.Text,
                    DateOnly.Parse(txtFechaDeNacimiento.Text), txtTelefono.Text, txtEmail.Text, txtNombreDeUsuario.Text, 
                    txtContrase�a.Text, txtContraRepetida.Text);
                if (listaResultados != null)
                {
                    errorProv.Clear();
                    for (int r = 0; r < listaResultados.Count; r++)
                    {
                        switch (listaResultados[r])
                        {
                            case "dni":
                                r++;
                                errorProv.SetError(txtDni, listaResultados[r]);
                                break;
                            case "nombreApellido":
                                r++;
                                errorProv.SetError(txtNombreYapellido, listaResultados[r]);
                                break;
                            case "fechaDeNacimiento":
                                r++;
                                errorProv.SetError(txtFechaDeNacimiento, listaResultados[r]);
                                break;
                            case "telefono":
                                r++;
                                errorProv.SetError(txtTelefono, listaResultados[r]);
                                break;
                            case "email":
                                r++;
                                errorProv.SetError(txtEmail, listaResultados[r]);
                                break;
                            case "usuario":
                                r++;
                                errorProv.SetError(txtNombreDeUsuario, listaResultados[r]);
                                break;
                            case "contrase�a":
                                r++;
                                errorProv.SetError(txtContrase�a, listaResultados[r]);
                                break;
                            case "contraRepetida":
                                r++;
                                errorProv.SetError(txtContraRepetida, listaResultados[r]);
                                break;
                        }
                    }
                }
                else
                {
                    Program.menu.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                errorProv.SetError(txtFechaDeNacimiento, "Fecha inv�lida, debe tener el formato dd/mm/aaaa");
            }
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarFormato.soloNumeros(e);
            if (!validar)
            {
                errorProv.SetError(txtDni, null);
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtDni))
            {
                errorProv.SetError(txtDni, "Este campo no puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtNombreYapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarFormato.soloLetras(e);
            if (!validar)
            {
                errorProv.SetError(txtNombreYapellido, null);
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtNombreYapellido_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtNombreYapellido))
            {
                errorProv.SetError(txtNombreYapellido, "Este campo no puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtFechaDeNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarFormato.soloNumerosFecha(e);
            if (!validar)
            {
                errorProv.SetError(txtFechaDeNacimiento, null);
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtFechaDeNacimiento_Leave(object sender, EventArgs e)
        {
            DateOnly fdn;
            if (!DateOnly.TryParse(txtFechaDeNacimiento.Text, out fdn))
            {
                errorProv.SetError(txtFechaDeNacimiento, "Fecha inv�lida dd/mm/aaaa");
            }
            else
            {           
                errorProv.Clear();
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = ValidarFormato.soloNumeros(e);
            if (!validar)
            {
                errorProv.SetError(txtTelefono, null);
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtTelefono))
            {
                errorProv.SetError(txtTelefono, "No puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtEmail))
            {
                errorProv.SetError(txtEmail, "No puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtNombreDeUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtNombreDeUsuario))
            {
                errorProv.SetError(txtNombreDeUsuario, "No puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtContrase�a))
            {
                errorProv.SetError(txtContrase�a, "No puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void txtContraRepetida_Leave(object sender, EventArgs e)
        {
            if (ValidarFormato.textosVacios(txtContraRepetida))
            {
                errorProv.SetError(txtContraRepetida, "Este campo no puede estar vac�o");
            }
            else
            {
                errorProv.Clear();
            }
        }
        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
        private void ocultarContrase�a_Click(object sender, EventArgs e)
        {
            verContrase�a.BringToFront();
            txtContrase�a.PasswordChar = '*';
        }
        private void verContrase�a_Click(object sender, EventArgs e)
        {
            ocultarContrase�a.BringToFront();
            txtContrase�a.PasswordChar = '\0';
        }
    }
}