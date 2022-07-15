using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PobreTITO
{
    public class Persona
    {
        public string dni { get; set; }
        public string nombreApellido { get; set; }
        public DateOnly fechaDeNacimiento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }


        //METODO CONSTRUCTOR
        public Persona(string dni, string nombreApellido, DateOnly fechaDeNacimiento, string telefono, string email, string usuario, string contraseña)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.telefono = telefono;
            this.email = email;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        //AGREGAR LA NUEVA PERSONA A LA BD
        public void NuevaPersona(SqlConnection c)
        {

            SqlCommand insert = new SqlCommand($"INSERT INTO Persona VALUES('{dni}', '{nombreApellido}', '{fechaDeNacimiento}', '{telefono}', '{email}', '{usuario}', '{contraseña}')", c);
            insert.ExecuteNonQuery();

        }
    }
}
