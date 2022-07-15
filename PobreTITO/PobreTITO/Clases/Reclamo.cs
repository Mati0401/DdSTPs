using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobreTITO.Clases
{
    public class Reclamo
    {
        public DateTime fecha { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }

        public Reclamo(string direccion, string descripcion)
        {
            fecha = DateTime.Now;
            this.direccion = direccion;
            this.descripcion = descripcion;
        }
        public void NuevoReclamo(int idI, int idSI, SqlConnection conexion)
        {
            SqlCommand insert = new SqlCommand($"INSERT INTO Reclamo VALUES('{fecha}','{direccion}','{descripcion}', {idI}, {idSI})", conexion);
            insert.ExecuteNonQuery();
        }
    }
}
