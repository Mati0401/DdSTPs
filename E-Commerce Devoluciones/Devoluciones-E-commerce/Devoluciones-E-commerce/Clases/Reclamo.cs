using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Devoluciones_E_commerce
{
    internal class Reclamo
    {

        private int idReclamo;
        private string fecha;
        private string tipo;
        private string motivo;
        private string descripcion;
        private string estadoReclamo;
        static private int idCompra;


        private string fechaDeUltimaActualizacion;
        private string fechaDeCierre;
        private string descripcionDeCierre;


        public int IdReclamo { get => idReclamo; set => idReclamo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string EstadoReclamo { get => estadoReclamo; set => estadoReclamo = value; } // APROBADO / DESAPROBADO / EN EVALUACIÓN
        static public int IdCompra { get => idCompra; set => idCompra = value; }


        public string FechaDeUltimaActualizacion { get => fechaDeUltimaActualizacion; set => fechaDeUltimaActualizacion = value; }
        public string FechaDeCierre { get => fechaDeCierre; set => fechaDeCierre = value; }
        public string DescripcionDeCierre { get => descripcionDeCierre; set => descripcionDeCierre = value; }


        public Reclamo() { }


        public void CargarNuevoReclamo(SqlConnection conexion)
        {

            conexion.Open();

            Fecha = DateTime.Now.ToString();
            IdReclamo = GenerarCodigoDeReclamo();
            EstadoReclamo = "En Evaluación";
            FechaDeUltimaActualizacion = "";
            FechaDeCierre = "";
            DescripcionDeCierre = "";


            SqlCommand insert = new SqlCommand($"INSERT INTO Reclamo VALUES('{IdReclamo}', '{Fecha}', '{IdCompra}', '{Tipo}', '{Motivo}', '{Descripcion}', '{EstadoReclamo}', '{FechaDeUltimaActualizacion}', '{FechaDeCierre}', '{DescripcionDeCierre}')", conexion); 
            insert.ExecuteNonQuery();

            conexion.Close();
        }


        public int GenerarCodigoDeReclamo()
        {

            Random myObject = new Random();
            int ranNum = myObject.Next(1, 99999999);
            
            return ranNum;

        }


        public string NuevoEstadoDeReclamo()
        {

            if (EstadoReclamo != "aprobado" || EstadoReclamo != "desaprobado")
            {

                if (Tipo == "Sin Entrega")
                {

                    List<string> estados = new List<string>() { "aprobado", "en análisis" };

                    Random rnd = new Random();
                    int randIndex = rnd.Next(estados.Count);
                    string random = estados[randIndex];

                    EstadoReclamo = random;

                }
                else
                {

                    List<string> estados = new List<string>() { "aprobado", "desaprobado", "en análisis" };

                    Random rnd = new Random();
                    int randIndex = rnd.Next(estados.Count);
                    string random = estados[randIndex];

                    EstadoReclamo = random;

                }

            }

            return EstadoReclamo;

        }


        public string DescripcionDeCierreCorrespondiente(string EstadoReclamoLocal, string TipoLocal)
        {
            if (EstadoReclamoLocal == "aprobado")
            {

                if (TipoLocal == "Sin Entrega")
                {

                    DescripcionDeCierre = "El producto finalmente ha sido entregado exitosamente.";

                }
                else
                {

                    DescripcionDeCierre = "Un representante del área correspondiente se estará comunicando a la brevedad con usted.";

                }

            }
            else if (EstadoReclamoLocal == "desaprobado")
            {

                DescripcionDeCierre = "Su reclamo no cumplió con los requisitos necesarios para ser aprobado.";

            }

            return DescripcionDeCierre;

        }

    }
}
