using PobreTITO.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PobreTITO
{
    public class GestorPobreTITO
    {
        int idPersona;
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matit\source\repos\PobreTITO\PobreTITO\BD\BaseDeDatos.mdf;Integrated Security=True");

        //GESTIONAR EL REGISTRO DE LA PERSONA
        public List<string> VerificarRegistro(string dni, string nombreApellido, DateOnly fechaDeNacimiento, string telefono, string email, string usuario, string contraseña, string contraRepetida)
        {
            Persona pers = new Persona(dni, nombreApellido, fechaDeNacimiento, telefono, email, usuario, contraseña);
            var results = Program.vp.Validate(pers);
            List<string> listaResultados = new List<string>();
            if (!results.IsValid || contraseña != contraRepetida)
            {
                foreach (var error in results.Errors)
                {
                    listaResultados.Add(error.PropertyName);
                    listaResultados.Add(error.ErrorMessage);
                }
                if (contraseña != contraRepetida)
                {
                    listaResultados.Add("contraseña");
                    listaResultados.Add("Las contraseñas no son iguales");
                }
                return listaResultados;
            }
            else
            {
                conexion.Open();
                pers.NuevaPersona(conexion);
                MessageBox.Show("Persona registrada con éxito");
                conexion.Close();
                return null;
            }
        }

        //GESTIONAR EL INICIO DE SESION 
        public bool VerificarInicioSesion(string usuario, string contra)
        {
            //VERIFICA QUE EL USUARIO EXISTA Y QUE LA CONTRASEÑA COINCIDA
            conexion.Open();
            SqlCommand select = new SqlCommand($"SELECT Id, usuario, contraseña FROM Persona WHERE usuario = '{usuario}'", conexion);
            SqlDataReader lector = select.ExecuteReader();
            if (lector.Read())
            {
                idPersona = lector.GetInt32(0);
                if (contra == lector.GetString(2))
                {
                    MessageBox.Show("Sesión iniciada con éxito");
                    conexion.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    conexion.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El Usuario ingresado no existe");
                conexion.Close();
                return false;
            }
        }
        //BUSCA LOS INCIDENTES REGISTRADOS EN LA BD
        public DataTable BuscarIncidentes()
        {
            conexion.Open();
            SqlCommand select = new SqlCommand("SELECT * FROM Incidente", conexion);
            DataTable resultados = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(resultados);
            conexion.Close();
            return resultados;
        }

        //BUSCA LOS SUB_INCIDENTES REGISTRADOS EN LA BD
        public DataTable BuscarSubIncidentes(int id)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"SELECT * FROM SubIncidente WHERE Incidente_Id = {id}", conexion);
            DataTable resultados = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(resultados);
            conexion.Close();
            return resultados;
        }
        //GESTIONAR LA CARGA DEL RECLAMO
        public void GestionarReclamo(int subincidente, string direccion, string descripcion)
        {
            conexion.Open();
            Reclamo rc = new Reclamo(direccion, descripcion);
            rc.NuevoReclamo(idPersona, subincidente, conexion);
            MessageBox.Show("Reclamo registrado exitosamente");
            conexion.Close();
        }
    }
}
