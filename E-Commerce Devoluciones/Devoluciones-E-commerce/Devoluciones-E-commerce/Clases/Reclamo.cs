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
        static private int idReclamo;
        static private string fecha;
        static private string tipo;
        static private string motivo;
        static private string descripcion;
        static private string estadoReclamo;
        static private int idCompra;


        static public int IdReclamo { get => idReclamo; set => idReclamo = value; }
        static public string Fecha { get => fecha; set => fecha = value; }
        static public string Motivo { get => motivo; set => motivo = value; }
        static public string Tipo { get => tipo; set => tipo = value; }
        static public string Descripcion { get => descripcion; set => descripcion = value; }
        static public string EstadoReclamo { get => estadoReclamo; set => estadoReclamo = value; } // APROBADO / DESAPROBADO / EN EVALUCACIÓN
        static public int IdCompra { get => idCompra; set => idCompra = value; }


        public Reclamo() { }


        public void NuevoReclamo(SqlConnection conexion)
        {

            conexion.Open();

            Fecha = DateTime.Now.ToString();
            IdReclamo = GenerarCodigoDeReclamo();
            EstadoReclamo = "En Evaluación";

            SqlCommand insert = new SqlCommand($"INSERT INTO Reclamo VALUES('{IdReclamo}', '{Fecha}', '{IdCompra}', '{Tipo}', '{Motivo}', '{Descripcion}', '{EstadoReclamo}')", conexion); 
            insert.ExecuteNonQuery();

            conexion.Close();
        }


        public int GenerarCodigoDeReclamo()
        {

            Random myObject = new Random();
            int ranNum = myObject.Next(1, 99999999);
            
            return ranNum;

        }

    }
}
