using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;

namespace PobreTITO
{
    public class ValidarPersona : AbstractValidator<Persona>
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matit\source\repos\PobreTITO\PobreTITO\BD\BaseDeDatos.mdf;Integrated Security=True");
        public ValidarPersona()
        {
            RuleFor(x => x.dni).Length(7,8).WithMessage("El DNI debe tener 7 o 8 números")
                                .Must(VerificarDni).WithMessage("El DNI ingresado ya está registrado")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
            RuleFor(x => x.nombreApellido).MaximumLength(50).WithMessage("Máximo 50 caracteres")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
            RuleFor(x => x.fechaDeNacimiento).Must(VerificarFechaNacimiento).WithMessage("Fecha de nacimiento inválida")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío"); ;
            RuleFor(x => x.telefono).Length(10).WithMessage("Teléfono no válido")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
            RuleFor(x => x.email).EmailAddress().WithMessage("Email no válido")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
            RuleFor(x => x.usuario).MaximumLength(20).WithMessage("Máximo 20 caracteres")
                                .Must(VerificarUsuario).WithMessage("El nombre de usuario ya está registrado")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
            RuleFor(x => x.contraseña).Length(8,20).WithMessage("La contraseña debe tener entre 8 y 20 caracteres")
                                .Must(VerificarContraseña).WithMessage("Debe tener al menos una letra, un número y un caracter especial")
                                .NotEmpty().WithMessage("No puede dejar este campo vacío");
        }
        private bool VerificarDni(string txtDni)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"SELECT dni FROM Persona WHERE dni = '{txtDni}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                lector.Close();
                conexion.Close();
                return false;
            }
            else
            {
                lector.Close();
                conexion.Close();
                return true;
            }
        }
        private bool VerificarFechaNacimiento(DateOnly txtfechaDeNacimiento)
        {
            //Verifica que la persona no tenga mas de 119 años.
            if (txtfechaDeNacimiento.Year > 1903 && txtfechaDeNacimiento.Year < DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool VerificarUsuario(string txtNombreDeUsuario)
        {
            //Verifica que no exista otra persona con el mismo nombre de usuario.
            conexion.Open();
            SqlCommand select = new SqlCommand($"SELECT dni FROM Persona WHERE usuario = '{txtNombreDeUsuario}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                lector.Close();
                conexion.Close();
                return false;
            }
            else
            {
                lector.Close();
                conexion.Close();
                return true;
            }
        }
        private bool VerificarContraseña(string txtContraseña)
        {
            //La contraseña debe contener letras, numeros y caracteres especiales.
            Regex soloLetras = new Regex(@"[a-zA-z]");
            Regex soloNumeros = new Regex(@"[0-9]");
            Regex soloCaractEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");
            if (!soloLetras.IsMatch(txtContraseña))
            {
                return false;
            }
            if (!soloNumeros.IsMatch(txtContraseña))
            {
                return false;
            }
            if (!soloCaractEsp.IsMatch(txtContraseña))
            {
                return false;
            }
            return true;
        }
    }
}
