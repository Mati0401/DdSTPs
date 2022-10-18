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
        private string idCompra;


        public int IdReclamo { get => idReclamo; set => idReclamo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string EstadoReclamo { get => estadoReclamo; set => estadoReclamo = value; } // APROBADO / DESAPROBADO / EN EVALUCACIÓN
        public string IdCompra { get => idCompra; set => idCompra = value; }


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
